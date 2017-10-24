using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALAPI
{
    /// <summary>
    /// The retrieve type you want from the method Anime/Manga.
    /// </summary>
    internal enum RetrieveType
    {
        /// <summary>
        /// Use Anime when you want to retrieve the animes using the method.
        /// </summary>
        Anime,
        /// <summary>
        /// Use Manga when you want to retrieve the mangas using the method.
        /// </summary>
        Manga,
    }

    /// <summary>
    /// Represents the status of anime in the list.
    /// </summary>
    public enum AnimeListStatus
    {
        /// <summary>
        /// Anime is in currently watching list.
        /// </summary>
        Watching = 1,
        /// <summary>
        /// Anime is in completed list.
        /// </summary>
        Completed,
        /// <summary>
        /// Anime is in onhold list.
        /// </summary>
        Onhold,
        /// <summary>
        /// Anime is in dropped list.
        /// </summary>
        Dropped,
        /// <summary>
        /// Anime is in plan to watch list.
        /// </summary>
        PlatToWatch = 6,
    }

    /// <summary>
    /// Represents the status of manga in the list.
    /// </summary>
    public enum MangaListStatus
    {
        /// <summary>
        /// Manga is in currently reading list.
        /// </summary>
        Reading = 1,
        /// <summary>
        /// Manga is in completed list.
        /// </summary>
        Completed,
        /// <summary>
        /// Manga is in onhold list.
        /// </summary>
        Onhold,
        /// <summary>
        /// Manga is in dropped list.
        /// </summary>
        Dropped,
        /// <summary>
        /// Manga is in plan to watch list.
        /// </summary>
        PlanToRead = 6,
    }

    //TODO: Complete this / assign correct values.
    /// <summary>
    /// Represents the status of an anime.
    /// </summary>
    public enum AnimeStatus
    {
        /// <summary>
        /// The anime air date is unkown.
        /// </summary>
        Unknown,
        /// <summary>
        /// The anime finished airing.
        /// </summary>
        FinishedAiring,
        /// <summary>
        /// The anime is currently airing.
        /// </summary>
        CurrentlyAiring,
        /// <summary>
        /// The anime is not yet aired.
        /// </summary>
        NotYetAired,
        /// <summary>
        /// Anime is cancelled.
        /// </summary>
        Cancelled,
    }

    //TODO: assign correct values.
    /// <summary>
    /// Represents the type of an anime.
    /// </summary>
    public enum AnimeType
    {
        /// <summary>
        /// TV Anime, it means the anime is broadcasted on TV.
        /// </summary>
        TV,
        /// <summary>
        /// Original video anime.
        /// </summary>
        OVA,
        /// <summary>
        /// Anime is a movie.
        /// </summary>
        Movie,
        /// <summary>
        /// Anime is a special episode.
        /// </summary>
        Special,
        /// <summary>
        /// Original network anime.
        /// </summary>
        ONA,
        /// <summary>
        /// The anime is based on certain Music.
        /// </summary>
        Music
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum EntryScore
    {
        Appealing = 1,
        Horrible,
        VeryBad,
        Bad,
        Average,
        Fine,
        Good,
        VeryGood,
        Great,
        Masterpiece
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
