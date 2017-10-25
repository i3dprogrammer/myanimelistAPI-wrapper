using MALAPI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MALAPI.GenericXMLDeserializer;

namespace MALAPI.Controllers
{
    /// <summary>
    /// A controller to manage myanimelist user lists API.
    /// </summary>
    public class UsersController
    {
        private MAL m_api;

        internal UsersController(MAL api)
        {
            m_api = api;
        }

        /// <summary>
        /// Retrieves anime list for specific user.
        /// </summary>
        /// <param name="user">The username you want to retrieve the list to (if not specified uses myanimelist username).</param>
        /// <returns>Returns an instance of UserAnimeList on success.</returns>
        public UserAnimeList GetUserAnimeList(string user = "")
        {
            if (user == "") user = m_api.m_username;
            if (user == "") throw new Exception("No username entered.");
            string data = m_api.m_client.GetAsync(string.Format(MAL.url_userlist, user, RetrieveType.Anime.ToString().ToLower())).Result.Content.ReadAsStringAsync().Result;
            return XMLDeserialize<UserAnimeList>(data);
        }

        /// <summary>
        /// Retrieves manga list for specific user, no Auth required.
        /// </summary>
        /// <param name="user">The username you want to retrieve the list to (if not specified uses myanimelist username).</param>
        /// <returns>Returns an instance of UserMangaList on success.</returns>
        public UserMangaList GetUserMangaList(string user = "")
        {
            if (user == "") user = m_api.m_username;
            if (user == "") throw new Exception("No username entered.");
            string data = m_api.m_client.GetAsync(string.Format(MAL.url_userlist, user, RetrieveType.Manga.ToString().ToLower())).Result.Content.ReadAsStringAsync().Result;
            return XMLDeserialize<UserMangaList>(data);
        }

        /// <summary>
        /// Retrieves anime list for specific user, no Auth required asynchronously.
        /// </summary>
        /// <param name="user">The username you want to retrieve the list to (if not specified uses myanimelist username).</param>
        /// <returns></returns>
        public async Task<UserAnimeList> GetUserAnimeListAsync(string user = "")
        {
            if (user == "") user = m_api.m_username;
            if (user == "") throw new Exception("No username entered.");
            string data = await m_api.m_client.GetAsync(string.Format(MAL.url_userlist, user, RetrieveType.Anime.ToString().ToLower())).Result.Content.ReadAsStringAsync();
            return XMLDeserialize<UserAnimeList>(data);
        }

        /// <summary>
        /// Retrieves manga list for specific user, no Auth required asynchronously.
        /// </summary>
        /// <param name="user">The username you want to retrieve the list to (if not specified uses myanimelist username).</param>
        /// <returns></returns>
        public async Task<UserMangaList> GetUserMangaListAsync(string user = "")
        {
            if (user == "") user = m_api.m_username;
            if (user == "") throw new Exception("No username entered.");
            string data = await m_api.m_client.GetAsync(string.Format(MAL.url_userlist, user, RetrieveType.Manga.ToString().ToLower())).Result.Content.ReadAsStringAsync();
            return XMLDeserialize<UserMangaList>(data);
        }
    }
}
