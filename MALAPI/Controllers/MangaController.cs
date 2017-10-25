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
    /// A controller to manage myanimelist manga API.
    /// </summary>
    public class MangaController
    {
        private MAL m_api;

        internal MangaController(MAL api)
        {
            m_api = api;
        }

        /// <summary>
        /// Adds manga to specific user's list.
        /// </summary>
        /// <param name="addedManga">The new added manga to the list.</param>
        /// <param name="mangaId">The ID of the new added manga.</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public string AddManga(MangaEntry addedManga, int mangaId)
        {
            m_api.CheckAuth();

            return m_api.PostSerializedObject(addedManga, string.Format(MAL.url_addManga, mangaId));
        }

        /// <summary>
        /// Adds manga to specific user's list
        /// </summary>
        /// <param name="searchEntry">The search entry you found.</param>
        /// <param name="status">The status of the manga Reading, Completed, Onhold, Dropped...</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public string AddManga(MangaSearchEntry searchEntry, MangaListStatus status)
        {
            m_api.CheckAuth();
            MangaEntry addedManga = new MangaEntry()
            {
                Status = status,
            };

            return m_api.PostSerializedObject(addedManga, string.Format(MAL.url_addManga, searchEntry.Id));
        }

        /// <summary>
        /// Updates existing manga in user's list.
        /// </summary>
        /// <param name="newMangaInfo">The updated manga object.</param>
        /// <param name="mangaId">the ID of the manga you want to update.</param>
        /// <returns>A string represnting the state of updating "Updated" or detailed error message.</returns>
        public string UpdateManga(MangaEntry newMangaInfo, int mangaId)
        {
            m_api.CheckAuth();

            return m_api.PostSerializedObject(newMangaInfo, string.Format(MAL.url_updateManga, mangaId));
        }

        /// <summary>
        /// Deletes existing manga from user's list.
        /// </summary>
        /// <param name="mangaId">The manga ID to delete from the list.</param>
        /// <returns>A string represnting the state of deleting "Deleted" or detailed error message.</returns>
        public string DeleteManga(int mangaId)
        {
            m_api.CheckAuth();

            return m_api.Post(string.Format(MAL.url_deleteManga, mangaId));
        }

        /// <summary>
        /// Adds manga to specific user's list.
        /// </summary>
        /// <param name="addedManga">The new added manga to the list.</param>
        /// <param name="mangaId">The ID of the new added manga.</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public async Task<string> AddMangaAsync(MangaEntry addedManga, int mangaId)
        {
            m_api.CheckAuthAsync();

            return await m_api.PostSerializedObjectAsync(addedManga, string.Format(MAL.url_addManga, mangaId));
        }

        /// <summary>
        /// Adds manga to specific user's list
        /// </summary>
        /// <param name="searchEntry">The search entry you found.</param>
        /// <param name="status">The status of the manga Reading, Completed, Onhold, Dropped...</param>
        /// <returns>A string represnting the state of adding "Created" or detailed error message.</returns>
        public async Task<string> AddMangaAsync(MangaSearchEntry searchEntry, MangaListStatus status)
        {
            m_api.CheckAuthAsync();

            MangaEntry addedManga = new MangaEntry()
            {
                Status = status,
            };

            return await m_api.PostSerializedObjectAsync(addedManga, string.Format(MAL.url_addManga, searchEntry.Id));
        }

        /// <summary>
        /// Updates existing manga in user's list.
        /// </summary>
        /// <param name="newMangaInfo">The updated manga object.</param>
        /// <param name="mangaId">the ID of the manga you want to update.</param>
        /// <returns>A string represnting the state of updating "Updated" or detailed error message.</returns>
        public async Task<string> UpdateMangaAsync(MangaEntry newMangaInfo, int mangaId)
        {
            m_api.CheckAuthAsync();

            return await m_api.PostSerializedObjectAsync(newMangaInfo, string.Format(MAL.url_updateManga, mangaId));
        }

        /// <summary>
        /// Deletes existing manga from user's list.
        /// </summary>
        /// <param name="mangaId">The manga ID to delete from the list.</param>
        /// <returns>A string represnting the state of deleting "Deleted" or detailed error message.</returns>
        public async Task<string> DeleteMangaAsync(int mangaId)
        {
            m_api.CheckAuthAsync();

            return await m_api.PostAsync(string.Format(MAL.url_deleteManga, mangaId));
        }
    }
}
