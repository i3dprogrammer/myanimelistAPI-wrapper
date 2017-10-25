using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static MALAPI.GenericXMLDeserializer;

namespace MALAPI
{
    /// <summary>
    /// A class containing the required method/variables/constructors for myanimelist.
    /// </summary>
    public class MAL
    {
        #region Links
        internal const string url_userlist = "https://myanimelist.net/malappinfo.php?u={0}&status=all&type={1}"; //TODO Figure out status.
        internal const string url_search = "https://myanimelist.net/api/{0}/search.xml?q={1}";
        internal const string url_addAnime = "https://myanimelist.net/api/animelist/add/{0}.xml";
        internal const string url_updateAnime = "https://myanimelist.net/api/animelist/update/{0}.xml";
        internal const string url_deleteAnime = "https://myanimelist.net/api/animelist/delete/{0}.xml";
        internal const string url_addManga = "https://myanimelist.net/api/mangalist/add/{0}.xml";
        internal const string url_updateManga = "https://myanimelist.net/api/mangalist/update/{0}.xml";
        internal const string url_deleteManga = "https://myanimelist.net/api/mangalist/delete/{0}.xml";
        internal const string url_verifycredentials = "https://myanimelist.net/api/account/verify_credentials.xml";
        #endregion

        internal HttpClient m_client;
        internal string m_username, m_password;
        internal bool validCredentials = false;

        /// <summary>
        /// Initializes new client without authentication.
        /// <para>Using methods that require Auth will throw an exception e.g. SearchForAsync, AddAnime, etc..</para>
        /// </summary>
        public MAL()
        {
            m_client = new HttpClient();
        }

        /// <summary>
        /// Initializes new client with authentication.
        /// </summary>
        /// <param name="username">myanimelist Username</param>
        /// <param name="password">myanimelist Password</param>
        public MAL(string username, string password)
        {
            m_username = username;
            m_password = password;

            m_client = new HttpClient();
            var encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            m_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);
        }

        internal void CheckAuth()
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

        internal async void CheckAuthAsync()
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

        internal T GetDeserializedObject<T>(string url)
        {
            return XMLDeserialize<T>(m_client.GetAsync(url).Result.Content.ReadAsStringAsync().Result);
        }

        internal async Task<T> GetDeserializedObjectAsync<T>(string url)
        {
            return XMLDeserialize<T>(await m_client.GetAsync(url).Result.Content.ReadAsStringAsync());
        }

        internal string PostSerializedObject<T>(T obj, string url)
        {
            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(obj)),
            });
            return m_client.PostAsync(url, content).Result.Content.ReadAsStringAsync().Result;
        }

        internal async Task<string> PostSerializedObjectAsync<T>(T obj, string url)
        {
            HttpContent content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("data", XMLSerialize(obj)),
            });
            return await m_client.PostAsync(url, content).Result.Content.ReadAsStringAsync();
        }

        internal string Post(string url)
        {
            return m_client.PostAsync(url, null).Result.Content.ReadAsStringAsync().Result;
        }

        internal async Task<string> PostAsync(string url)
        {
            return await m_client.PostAsync(url, null).Result.Content.ReadAsStringAsync();
        }
    }
}
