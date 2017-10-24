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
        public Controllers.AnimeController Anime { get; set; }
        /// <summary>
        /// An object to manage myanimelist manga API.
        /// </summary>
        public Controllers.MangaController Manga { get; set; }
        /// <summary>
        /// An object to manage myanimelist users list API.
        /// </summary>
        public Controllers.UsersController Users { get; set; }
        /// <summary>
        /// An object to manage myanimelist search API.
        /// </summary>
        public Controllers.SearchController Search { get; set; }

        /// <summary>
        /// Initializes new client without authentication.
        /// <para>Using methods that require Auth will throw an exception e.g. SearchFor, AddAnime, etc..</para>
        /// </summary>
        public API() : base()
        {
            Anime = new Controllers.AnimeController(this);
            Manga = new Controllers.MangaController(this);
            Users = new Controllers.UsersController(this);
            Search = new Controllers.SearchController(this);
        }
        /// <summary>
        /// Initializes new client with authentication.
        /// </summary>
        /// <param name="user">myanimelist Username</param>
        /// <param name="pass">myanimelist Password</param>
        public API(string user, string pass) : base(user, pass)
        {
            Anime = new Controllers.AnimeController(this);
            Manga = new Controllers.MangaController(this);
            Users = new Controllers.UsersController(this);
            Search = new Controllers.SearchController(this);
        }
    }
}
