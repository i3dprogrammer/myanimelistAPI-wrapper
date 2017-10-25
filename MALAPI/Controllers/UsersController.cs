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
            return m_api.GetDeserializedObject<UserAnimeList>(string.Format(MAL.url_userlist, CheckUserName(user), RetrieveType.Anime.ToString().ToLower()));
        }

        /// <summary>
        /// Retrieves manga list for specific user, no Auth required.
        /// </summary>
        /// <param name="user">The username you want to retrieve the list to (if not specified uses myanimelist username).</param>
        /// <returns>Returns an instance of UserMangaList on success.</returns>
        public UserMangaList GetUserMangaList(string user = "")
        {
            return m_api.GetDeserializedObject<UserMangaList>(string.Format(MAL.url_userlist, CheckUserName(user), RetrieveType.Manga.ToString().ToLower()));
        }

        /// <summary>
        /// Retrieves anime list for specific user, no Auth required asynchronously.
        /// </summary>
        /// <param name="user">The username you want to retrieve the list to (if not specified uses myanimelist username).</param>
        /// <returns></returns>
        public async Task<UserAnimeList> GetUserAnimeListAsync(string user = "")
        {
            return await m_api.GetDeserializedObjectAsync<UserAnimeList>(string.Format(MAL.url_userlist, CheckUserName(user), RetrieveType.Anime.ToString().ToLower()));
        }

        /// <summary>
        /// Retrieves manga list for specific user, no Auth required asynchronously.
        /// </summary>
        /// <param name="user">The username you want to retrieve the list to (if not specified uses myanimelist username).</param>
        /// <returns></returns>
        public async Task<UserMangaList> GetUserMangaListAsync(string user = "")
        {
            return await m_api.GetDeserializedObjectAsync<UserMangaList>(string.Format(MAL.url_userlist, CheckUserName(user), RetrieveType.Manga.ToString().ToLower()));
        }

        private string CheckUserName(string user)
        {
            if (user == "") user = m_api.m_username;
            if (user == "") throw new Exception("No username entered.");
            return user;
        }
    }
}
