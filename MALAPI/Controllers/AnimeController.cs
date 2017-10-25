using MALAPI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static MALAPI.GenericXMLDeserializer;
namespace MALAPI.Controllers
{
    /// <summary>
    /// A controller to manage myanimelist anime API.
    /// </summary>
    public class AnimeController
    {
        private MAL m_api;

        internal AnimeController(MAL api)
        {
            m_api = api;
        }

        /// <summary>
        /// Adds anime entry to specific user's list.
        /// </summary>
        /// <param name="addedAnime">The anime entry you want to add to the list.</param>
        /// <param name="animeId">The ID of the new added anime.</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public string AddAnime(AnimeEntry addedAnime, int animeId)
        {
            m_api.CheckAuth();

            return m_api.PostSerializedObject(addedAnime, string.Format(MAL.url_addAnime, animeId));
        }

        /// <summary>
        /// Adds found anime search entry to specific user's list.
        /// </summary>
        /// <param name="searchEntry">The search entry you found.</param>
        /// <param name="status">The status of the anime Watching, Completed, Onhold, Dropped...</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public string AddAnime(AnimeSearchEntry searchEntry, AnimeListStatus status)
        {
            m_api.CheckAuth();

            AnimeEntry addedAnime = new AnimeEntry()
            {
                Status = status,
            };

            return m_api.PostSerializedObject(addedAnime, string.Format(MAL.url_addAnime, searchEntry.Id));
        }

        /// <summary>
        /// Updates existing anime in user's list.
        /// </summary>
        /// <param name="newAnimeInfo">The updated anime entry.</param>
        /// <param name="animeId">the ID of the anime entry you want to update.</param>
        /// <returns>A string represnting the state of updating "Updated" or detailed error message.</returns>
        public string UpdateAnime(AnimeEntry newAnimeInfo, int animeId)
        {
            m_api.CheckAuth();

            return m_api.PostSerializedObject(newAnimeInfo, string.Format(MAL.url_updateAnime, animeId));
        }

        /// <summary>
        /// Deletes existing anime from user's list.
        /// </summary>
        /// <param name="animeId">The anime ID to delete from the list.</param>
        /// <returns>A string represnting the state of deleting "Deleted" or detailed error message.</returns>
        public string DeleteAnime(int animeId)
        {
            m_api.CheckAuth();
            return m_api.Post(string.Format(MAL.url_deleteAnime, animeId));
        }

        /// <summary>
        ///Adds anime entry to specific user's list asynchronously.
        /// </summary>
        /// <param name="addedAnime">The new added anime to the list.</param>
        /// <param name="animeId">The ID of the new added anime.</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public async Task<string> AddAnimeAsync(AnimeEntry addedAnime, int animeId)
        {
            m_api.CheckAuthAsync();

            return await m_api.PostSerializedObjectAsync(addedAnime, string.Format(MAL.url_addAnime, animeId));
        }


        /// <summary>
        /// Adds found anime search entry to specific user's list asynchronously.
        /// </summary>
        /// <param name="searchEntry">The search entry you found.</param>
        /// <param name="status">The status of the anime Watching, Completed, Onhold, Dropped...</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public async Task<string> AddAnimeAsync(AnimeSearchEntry searchEntry, AnimeListStatus status)
        {
            m_api.CheckAuthAsync();
            AnimeEntry addedAnime = new AnimeEntry()
            {
                Status = status,
            };

            return await m_api.PostSerializedObjectAsync(addedAnime, string.Format(MAL.url_addAnime, searchEntry.Id));
        }

        /// <summary>
        /// Updates existing anime in user's list asynchronously.
        /// </summary>
        /// <param name="newAnimeInfo">The updated anime object.</param>
        /// <param name="animeId">the ID of the anime you want to update.</param>
        /// <returns>A string represnting the state of updating "Updated" or detailed error message.</returns>
        public async Task<string> UpdateAnimeAsync(AnimeEntry newAnimeInfo, int animeId)
        {
            m_api.CheckAuthAsync();
            return await m_api.PostSerializedObjectAsync(newAnimeInfo, string.Format(MAL.url_updateAnime, animeId));
        }

        /// <summary>
        /// Deletes existing anime from user's list asynchronously.
        /// </summary>
        /// <param name="animeId">The anime ID to delete from the list.</param>
        /// <returns>A string represnting the state of deleting "Deleted" or detailed error message.</returns>
        public async Task<string> DeleteAnimeAsync(int animeId)
        {
            m_api.CheckAuthAsync();

            return await m_api.PostAsync(string.Format(MAL.url_deleteAnime, animeId));
        }
    }
}
