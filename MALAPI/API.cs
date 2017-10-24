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

namespace MALAPI
{
    /// <summary>
    /// A Wrapper for myanimelist in C#.
    /// </summary>
    public class API : MAL
    {
        /// <summary>
        /// An object to manage myanimelist anime API.
        /// </summary>
        public Models.Anime Anime { get; set; }
        /// <summary>
        /// An object to manage myanimelist manga API.
        /// </summary>
        public Models.Manga Manga { get; set; }
        /// <summary>
        /// An object to manage myanimelist users list API.
        /// </summary>
        public Models.Users Users { get; set; }
        /// <summary>
        /// An object to manage myanimelist search API.
        /// </summary>
        public Models.Search Search { get; set; }

        /// <summary>
        /// Initializes new client without authentication.
        /// <para>Using methods that require Auth will throw an exception e.g. SearchFor, AddAnime, etc..</para>
        /// </summary>
        public API() : base()
        {
            Anime = new Models.Anime(this);
            Manga = new Models.Manga(this);
            Users = new Models.Users(this);
            Search = new Models.Search(this);
        }
        /// <summary>
        /// Initializes new client with authentication.
        /// </summary>
        /// <param name="user">myanimelist Username</param>
        /// <param name="pass">myanimelist Password</param>
        public API(string user, string pass) : base(user, pass)
        {
            Anime = new Models.Anime(this);
            Manga = new Models.Manga(this);
            Users = new Models.Users(this);
            Search = new Models.Search(this);
        }
    }
}
