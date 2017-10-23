﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MALAPI.Dto;
using static MALAPI.GenericXMLDeserializer;

namespace MALAPI
{
    /// <summary>
    /// A Wrapper for myanimelist in C#.
    /// </summary>
    public class API
    {
        #region Links
        private const string url_userlist = "https://myanimelist.net/malappinfo.php?u={0}&status=all&type={1}"; //TODO Figure out status.
        private const string url_search = "https://myanimelist.net/api/{0}/search.xml?q={1}";
        private const string url_addAnime = "https://myanimelist.net/api/animelist/add/{0}.xml";
        private const string url_updateAnime = "https://myanimelist.net/api/animelist/update/{0}.xml";
        private const string url_deleteAnime = "https://myanimelist.net/api/animelist/delete/{0}.xml";
        private const string url_addManga = "https://myanimelist.net/api/mangalist/add/{0}.xml";
        private const string url_updateManga = "https://myanimelist.net/api/mangalist/update/{0}.xml";
        private const string url_deleteManga = "https://myanimelist.net/api/mangalist/delete/{0}.xml";
        private const string url_verifycredentials = "https://myanimelist.net/api/account/verify_credentials.xml";
        #endregion

        private HttpClient m_client;
        private string m_username, m_password;
        private bool validCredentials = false;

        /// <summary>
        /// Initializes new client without authentication.
        /// <para>Using methods that require Auth will throw an exception e.g. SearchForAsync, AddAnime, etc..</para>
        /// </summary>
        public API()
        {
            m_client = new HttpClient();
        }

        /// <summary>
        /// Initializes new client with authentication.
        /// </summary>
        /// <param name="username">myanimelist Username</param>
        /// <param name="password">myanimelist Password</param>
        public API(string username, string password)
        {
            m_username = username;
            m_password = password;

            m_client = new HttpClient();
            var encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            m_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);

            CheckAuth();
        }

        /// <summary>
        /// Retrieves anime/manga list for specific user, no Auth required.
        /// </summary>
        /// <param name="user">The username you want to retrieve the list to (if not specified uses myanimelist username).</param>
        /// <returns>Returns an instance of UserAnimeList on success.</returns>
        public UserAnimeList GetUserAnimeList(string user = "")
        {
            if (user == "") user = m_username;
            string data = m_client.GetAsync(string.Format(url_userlist, user, RetrieveType.Anime.ToString().ToLower())).Result.Content.ReadAsStringAsync().Result;
            return XMLDeserialize<UserAnimeList>(data);
        }

        /// <summary>
        /// Retrieves anime/manga list for specific user, no Auth required.
        /// </summary>
        /// <param name="user">The username you want to retrieve the list to (if not specified uses myanimelist username).</param>
        /// <returns>Returns an instance of UserMangaList on success.</returns>
        public UserMangaList GetUserMangaList(string user = "")
        {
            if (user == "") user = m_username;
            string data = m_client.GetAsync(string.Format(url_userlist, user, RetrieveType.Manga.ToString().ToLower())).Result.Content.ReadAsStringAsync().Result;
            return XMLDeserialize<UserMangaList>(data);
        }

        /// <summary>
        /// Searches myanimelist for anime, Auth required.
        /// </summary>
        /// <param name="searchQuery">The query to search for.</param>
        /// <returns>Returns an instance of AnimeSearchResult on success.</returns>
        public AnimeSearchResult SearchForAnime(string searchQuery)
        {
            CheckAuth();

            if (string.IsNullOrEmpty(searchQuery))
                return null;
            string data = m_client.GetAsync(string.Format(url_search, RetrieveType.Anime.ToString().ToLower(), searchQuery)).Result.Content.ReadAsStringAsync().Result;

            if (string.IsNullOrEmpty(data) || string.IsNullOrWhiteSpace(data))
                return null;
            
            return XMLDeserialize<AnimeSearchResult>(data);
        }

        /// <summary>
        /// Searches myanimelist for anime, Auth required.
        /// </summary>
        /// <param name="searchQuery">The query to search for.</param>
        /// <returns>Returns an instance of MangaSearchResult on success.</returns>
        public MangaSearchResult SearchForManga(string searchQuery)
        {
            CheckAuth();

            if (string.IsNullOrEmpty(searchQuery))
                return null;
            string data = m_client.GetAsync(string.Format(url_search, RetrieveType.Manga.ToString().ToLower(), searchQuery)).Result.Content.ReadAsStringAsync().Result;

            if (string.IsNullOrEmpty(data) || string.IsNullOrWhiteSpace(data))
                return null;

            return XMLDeserialize<MangaSearchResult>(data);
        }

        /// <summary>
        /// Adds anime to specific user's list.
        /// </summary>
        /// <param name="addedAnime">The new added anime to the list.</param>
        /// <param name="animeId">The ID of the new added anime.</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public string AddAnime(Anime addedAnime, int animeId)
        {
            CheckAuth();

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(addedAnime)),
            });
            return m_client.PostAsync(string.Format(url_addAnime, animeId), content).Result.Content.ReadAsStringAsync().Result;
        }

        /// <summary>
        /// Updates existing anime in user's list.
        /// </summary>
        /// <param name="newAnime">The updated anime object.</param>
        /// <param name="animeId">the ID of the anime you want to update.</param>
        /// <returns>A string represnting the state of updating "Updated" or detailed error message.</returns>
        public string UpdateAnime(Anime newAnime, int animeId)
        {
            CheckAuth();

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(newAnime)),
            });
            return m_client.PostAsync(string.Format(url_updateAnime, animeId), content).Result.Content.ReadAsStringAsync().Result;
        }

        /// <summary>
        /// Deletes existing anime from user's list.
        /// </summary>
        /// <param name="animeId">The anime ID to delete from the list.</param>
        /// <returns>A string represnting the state of deleting "Deleted" or detailed error message.</returns>
        public string DeleteAnime(int animeId)
        {
            CheckAuth();

            return m_client.PostAsync(string.Format(url_deleteAnime, animeId), null).Result.Content.ReadAsStringAsync().Result;
        }

        /// <summary>
        /// Adds manga to specific user's list.
        /// </summary>
        /// <param name="addedManga">The new added manga to the list.</param>
        /// <param name="mangaId">The ID of the new added manga.</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public string AddManga(Manga addedManga, int mangaId)
        {
            CheckAuth();

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(addedManga)),
            });
            return m_client.PostAsync(string.Format(url_addManga, mangaId), content).Result.Content.ReadAsStringAsync().Result;
        }

        /// <summary>
        /// Updates existing manga in user's list.
        /// </summary>
        /// <param name="newManga">The updated manga object.</param>
        /// <param name="mangaId">the ID of the manga you want to update.</param>
        /// <returns>A string represnting the state of updating "Updated" or detailed error message.</returns>
        public string UpdateManga(Manga newManga, int mangaId)
        {
            CheckAuth();

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(newManga)),
            });
            return m_client.PostAsync(string.Format(url_updateManga, mangaId), content).Result.Content.ReadAsStringAsync().Result;
        }

        /// <summary>
        /// Deletes existing manga from user's list.
        /// </summary>
        /// <param name="mangaId">The manga ID to delete from the list.</param>
        /// <returns>A string represnting the state of deleting "Deleted" or detailed error message.</returns>
        public string DeleteManga(int mangaId)
        {
            CheckAuth();

            return m_client.PostAsync(string.Format(url_deleteManga, mangaId), null).Result.Content.ReadAsStringAsync().Result;
        }

        private void CheckAuth()
        {
            if (string.IsNullOrEmpty(m_username) || string.IsNullOrEmpty(m_password))
                throw new Exception("Couldn't use this method because it requires correct authentication.\n" +
                    "Try using the authentication overload for the constructor.");

            if (!validCredentials)
            {
                string data = m_client.GetAsync(url_verifycredentials).Result.Content.ReadAsStringAsync().Result;
                if (data == "Invalid credentials")
                {
                    throw new Exception(data);
                }
                validCredentials = true;
            }
        }
    }
}
