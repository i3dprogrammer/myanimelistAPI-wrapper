using MALAPI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MALAPI.GenericXMLDeserializer;
namespace MALAPI.Models
{

    /// <summary>
    /// A model to manage myanimelist search API.
    /// </summary>
    public class Search
    {
        private API m_api;

        internal Search(API api)
        {
            m_api = api;
        }

        /// <summary>
        /// Searches myanimelist for anime, Auth required.
        /// </summary>
        /// <param name="searchQuery">The query to search for.</param>
        /// <returns>Returns an instance of AnimeSearchResult on success.</returns>
        public AnimeSearchResult SearchForAnime(string searchQuery)
        {
            m_api.CheckAuth();

            if (string.IsNullOrEmpty(searchQuery))
                return null;
            string data = m_api.m_client.GetAsync(string.Format(MAL.url_search, RetrieveType.Anime.ToString().ToLower(), searchQuery)).Result.Content.ReadAsStringAsync().Result;

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
            m_api.CheckAuth();

            if (string.IsNullOrEmpty(searchQuery))
                return null;
            string data = m_api.m_client.GetAsync(string.Format(MAL.url_search, RetrieveType.Manga.ToString().ToLower(), searchQuery)).Result.Content.ReadAsStringAsync().Result;

            if (string.IsNullOrEmpty(data) || string.IsNullOrWhiteSpace(data))
                return null;

            return XMLDeserialize<MangaSearchResult>(data);
        }

        /// <summary>
        /// Searches myanimelist for anime, Auth required.
        /// </summary>
        /// <param name="searchQuery">The query to search for.</param>
        /// <returns></returns>
        public async Task<AnimeSearchResult> SearchForAnimeAsync(string searchQuery)
        {
            m_api.CheckAuth();

            if (string.IsNullOrEmpty(searchQuery))
                return null;
            string data = await m_api.m_client.GetAsync(string.Format(MAL.url_search, RetrieveType.Anime.ToString().ToLower(), searchQuery)).Result.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(data) || string.IsNullOrWhiteSpace(data))
                return null;

            return XMLDeserialize<AnimeSearchResult>(data);
        }

        /// <summary>
        /// Searches myanimelist for anime, Auth required.
        /// </summary>
        /// <param name="searchQuery">The query to search for.</param>
        /// <returns></returns>
        public async Task<MangaSearchResult> SearchForMangaAsync(string searchQuery)
        {
            m_api.CheckAuth();

            if (string.IsNullOrEmpty(searchQuery))
                return null;
            string data = await m_api.m_client.GetAsync(string.Format(MAL.url_search, RetrieveType.Manga.ToString().ToLower(), searchQuery)).Result.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(data) || string.IsNullOrWhiteSpace(data))
                return null;

            return XMLDeserialize<MangaSearchResult>(data);
        }
    }
}
