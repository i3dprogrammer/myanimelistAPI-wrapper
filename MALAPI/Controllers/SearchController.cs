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
    /// A controller to manage myanimelist search API.
    /// </summary>
    public class SearchController
    {
        private MAL m_api;

        internal SearchController(MAL api)
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
            return m_api.GetDeserializedObject<AnimeSearchResult>(string.Format(MAL.url_search, RetrieveType.Anime.ToString().ToLower(), searchQuery));
        }

        /// <summary>
        /// Searches myanimelist for manga, Auth required.
        /// </summary>
        /// <param name="searchQuery">The query to search for.</param>
        /// <returns>Returns an instance of MangaSearchResult on success.</returns>
        public MangaSearchResult SearchForManga(string searchQuery)
        {
            m_api.CheckAuth();
            return m_api.GetDeserializedObject<MangaSearchResult>(string.Format(MAL.url_search, RetrieveType.Manga.ToString().ToLower(), searchQuery));
        }

        /// <summary>
        /// Searches myanimelist for anime, Auth required.
        /// </summary>
        /// <param name="searchQuery">The query to search for.</param>
        /// <returns></returns>
        public async Task<AnimeSearchResult> SearchForAnimeAsync(string searchQuery)
        {
            m_api.CheckAuth();
            return await m_api.GetDeserializedObjectAsync<AnimeSearchResult>(string.Format(MAL.url_search, RetrieveType.Anime.ToString().ToLower(), searchQuery));
        }

        /// <summary>
        /// Searches myanimelist for manga, Auth required.
        /// </summary>
        /// <param name="searchQuery">The query to search for.</param>
        /// <returns></returns>
        public async Task<MangaSearchResult> SearchForMangaAsync(string searchQuery)
        {
            m_api.CheckAuth();
            return await m_api.GetDeserializedObjectAsync<MangaSearchResult>(string.Format(MAL.url_search, RetrieveType.Manga.ToString().ToLower(), searchQuery));
        }
    }
}
