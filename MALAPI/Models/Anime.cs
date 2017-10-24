using MALAPI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static MALAPI.GenericXMLDeserializer;
namespace MALAPI.Models
{
    /// <summary>
    /// A model to manage myanimelist anime API.
    /// </summary>
    public class Anime
    {
        private API m_api;

        internal Anime(API api)
        {
            m_api = api;
        }

        /// <summary>
        /// Adds anime to specific user's list.
        /// </summary>
        /// <param name="addedAnime">The new added anime to the list.</param>
        /// <param name="animeId">The ID of the new added anime.</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public string AddAnime(AnimeEntry addedAnime, int animeId)
        {
            m_api.CheckAuth();

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(addedAnime)),
            });
            return m_api.m_client.PostAsync(string.Format(MAL.url_addAnime, animeId), content).Result.Content.ReadAsStringAsync().Result;
        }

        /// <summary>
        /// Adds anime to specific user's list.
        /// </summary>
        /// <param name="searchEntry">The search entry you found.</param>
        /// <param name="status">The status of the anime Watching, Completed, Onhold, Dropped...</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public string AddAnime(Dto.AnimeSearchEntry searchEntry, AnimeListStatus status)
        {
            m_api.CheckAuth();
            AnimeEntry anime = new AnimeEntry()
            {
                Status = status,
            };

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(anime)),
            });
            return m_api.m_client.PostAsync(string.Format(MAL.url_addAnime, searchEntry.Id), content).Result.Content.ReadAsStringAsync().Result;
        }

        /// <summary>
        /// Updates existing anime in user's list.
        /// </summary>
        /// <param name="newAnimeInfo">The updated anime object.</param>
        /// <param name="animeId">the ID of the anime you want to update.</param>
        /// <returns>A string represnting the state of updating "Updated" or detailed error message.</returns>
        public string UpdateAnime(AnimeEntry newAnimeInfo, int animeId)
        {
            m_api.CheckAuth();

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(newAnimeInfo)),
            });
            return m_api.m_client.PostAsync(string.Format(MAL.url_updateAnime, animeId), content).Result.Content.ReadAsStringAsync().Result;
        }

        /// <summary>
        /// Deletes existing anime from user's list.
        /// </summary>
        /// <param name="animeId">The anime ID to delete from the list.</param>
        /// <returns>A string represnting the state of deleting "Deleted" or detailed error message.</returns>
        public string DeleteAnime(int animeId)
        {
            m_api.CheckAuth();

            return m_api.m_client.PostAsync(string.Format(MAL.url_deleteAnime, animeId), null).Result.Content.ReadAsStringAsync().Result;
        }

        /// <summary>
        /// Adds anime to specific user's list.
        /// </summary>
        /// <param name="addedAnime">The new added anime to the list.</param>
        /// <param name="animeId">The ID of the new added anime.</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public async Task<string> AddAnimeAsync(AnimeEntry addedAnime, int animeId)
        {
            m_api.CheckAuthAsync();

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(addedAnime)),
            });
            return await m_api.m_client.PostAsync(string.Format(MAL.url_addAnime, animeId), content).Result.Content.ReadAsStringAsync();
        }


        /// <summary>
        /// Adds anime to specific user's list.
        /// </summary>
        /// <param name="searchEntry">The search entry you found.</param>
        /// <param name="status">The status of the anime Watching, Completed, Onhold, Dropped...</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public async Task<string> AddAnimeAsync(Dto.AnimeSearchEntry searchEntry, AnimeListStatus status)
        {
            m_api.CheckAuthAsync();
            AnimeEntry anime = new AnimeEntry()
            {
                Status = status,
            };

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(anime)),
            });
            return await m_api.m_client.PostAsync(string.Format(MAL.url_addAnime, searchEntry.Id), content).Result.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Updates existing anime in user's list.
        /// </summary>
        /// <param name="newAnimeInfo">The updated anime object.</param>
        /// <param name="animeId">the ID of the anime you want to update.</param>
        /// <returns>A string represnting the state of updating "Updated" or detailed error message.</returns>
        public async Task<string> UpdateAnimeAsync(AnimeEntry newAnimeInfo, int animeId)
        {
            m_api.CheckAuthAsync();

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(newAnimeInfo)),
            });
            return await m_api.m_client.PostAsync(string.Format(MAL.url_updateAnime, animeId), content).Result.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Deletes existing anime from user's list.
        /// </summary>
        /// <param name="animeId">The anime ID to delete from the list.</param>
        /// <returns>A string represnting the state of deleting "Deleted" or detailed error message.</returns>
        public async Task<string> DeleteAnimeAsync(int animeId)
        {
            m_api.CheckAuthAsync();

            return await m_api.m_client.PostAsync(string.Format(MAL.url_deleteAnime, animeId), null).Result.Content.ReadAsStringAsync();
        }
    }
}
