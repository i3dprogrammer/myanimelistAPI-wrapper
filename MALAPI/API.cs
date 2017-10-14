using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MALAPI.Dto;
using static MALAPI.GenericXMLDeserializer;
using static MALAPI.ParseEnums;

namespace MALAPI
{
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

        public API()
        {
            m_client = new HttpClient();
        }

        public API(string username, string password)
        {
            m_username = username;
            m_password = password;

            m_client = new HttpClient();
            var encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            m_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);

            CheckAuth();
        }

        public async Task<UserList> GetUserListAsync(string user = "", RetrieveType listType = RetrieveType.Anime)
        {
            if (user == "") user = m_username;
            string data = await m_client.GetAsync(string.Format(url_userlist, user, listType.ToString().ToLower())).Result.Content.ReadAsStringAsync();
            return XMLDeserialize<UserList>(data);
        }

        public async Task<SearchResult> SearchForAsync(string searchQuery, RetrieveType searchType = RetrieveType.Anime)
        {
            CheckAuth();

            if (string.IsNullOrEmpty(searchQuery))
                return null;
            string data = await m_client.GetAsync(string.Format(url_search, searchType.ToString().ToLower(), searchQuery)).Result.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(data) || string.IsNullOrWhiteSpace(data))
                return null;
            return XMLDeserialize<SearchResult>(data);
        }

        public async Task<string> AddAnime(Anime addedAnime, int animeId)
        {
            CheckAuth();

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(addedAnime)),
            });
            return await m_client.PostAsync(string.Format(url_addAnime, animeId), content).Result.Content.ReadAsStringAsync();
        }

        public async Task<string> UpdateAnime(Anime newAnime, int animeId)
        {
            CheckAuth();

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(newAnime)),
            });
            return await m_client.PostAsync(string.Format(url_updateAnime, animeId), content).Result.Content.ReadAsStringAsync();
        }

        public async Task<string> DeleteAnime(int animeId)
        {
            CheckAuth();

            return await m_client.PostAsync(string.Format(url_deleteAnime, animeId), null).Result.Content.ReadAsStringAsync();
        }

        public async Task<string> AddManga(Manga addedManga, int mangaId)
        {
            CheckAuth();

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(addedManga)),
            });
            return await m_client.PostAsync(string.Format(url_addManga, mangaId), content).Result.Content.ReadAsStringAsync();
        }

        public async Task<string> UpdateManga(Manga newManga, int mangaId)
        {
            CheckAuth();

            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(newManga)),
            });
            return await m_client.PostAsync(string.Format(url_updateManga, mangaId), content).Result.Content.ReadAsStringAsync();
        }

        public async Task<string> DeleteManga(int mangaId)
        {
            CheckAuth();

            return await m_client.PostAsync(string.Format(url_deleteManga, mangaId), null).Result.Content.ReadAsStringAsync();
        }

        private async void CheckAuth()
        {
            if (string.IsNullOrEmpty(m_username) || string.IsNullOrEmpty(m_password))
                throw new Exception("Couldn't use this operations because it requires correct authentication.\n" +
                    "Try using authentication overload for the constructor.");

            if (!validCredentials)
            {
                string data = await m_client.GetAsync(url_verifycredentials).Result.Content.ReadAsStringAsync();
                if (data == "Invalid credentials")
                {
                    throw new Exception(data);
                }
                validCredentials = true;
            }
        }
    }
}
