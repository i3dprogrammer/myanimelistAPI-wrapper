using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MALAPI.Dto
{
    /// <summary>
    /// The instance returned when getting a specific user anime list.
    /// </summary>
    [Serializable, XmlRoot("myanimelist")]
    public class UserAnimeList
    {
        /// <summary>
        /// Info about the user list.
        /// </summary>
        [XmlElement("myinfo")]
        public UserAnimeInfo Info { get; set; }

        /// <summary>
        /// The animes in that user list.
        /// </summary>
        [XmlElement("anime")]
        public List<UserAnime> Animes { get; set; }
    }

    /// <summary>
    /// Info about the anime list user.
    /// </summary>
    [Serializable, XmlRoot("myinfo")]
    public class UserAnimeInfo
    {
        /// <summary>
        /// User Id.
        /// </summary>
        [XmlElement("user_id")]
        public int Id { get; set; }
        /// <summary>
        /// User name.
        /// </summary>
        [XmlElement("user_name")]
        public string Name { get; set; }
        /// <summary>
        /// Animes Currently watching count.
        /// </summary>
        [XmlElement("user_watching")]
        public int WatchingCount { get; set; }
        /// <summary>
        /// Animes compeleted count.
        /// </summary>
        [XmlElement("user_completed")]
        public int CompletedCount { get; set; }
        /// <summary>
        /// Animes onhold count.
        /// </summary>
        [XmlElement("user_onhold")]
        public int OnholdCount { get; set; }
        /// <summary>
        /// Animes dropped count.
        /// </summary>
        [XmlElement("user_dropped")]
        public int DroppedCount { get; set; }
        /// <summary>
        /// Animes planned to watch count.
        /// </summary>
        [XmlElement("user_plantowatch")]
        public int PlanToWatchCount { get; set; }
        /// <summary>
        /// Days user spent watching animes.
        /// </summary>
        [XmlElement("user_days_spent_watching")]
        public float DaysSpentWatching { get; set; }

        /// <summary>
        /// A simple ToString override to return user name + Id
        /// </summary>
        /// <returns>Returns {Name}#{Id}</returns>
        public override string ToString()
        {
            return $"{Name}#{Id}";
        }
    }

    /// <summary>
    /// Anime entry in the user list.
    /// </summary>
    [Serializable, XmlRoot("anime")]
    public class UserAnime
    {
        /// <summary>
        /// Anime ID in the database.
        /// </summary>
        [XmlElement("series_animedb_id")]
        public int SeriesId { get; set; }
        /// <summary>
        /// Anime series title.
        /// </summary>
        [XmlElement("series_title")]
        public string SeriesTitle { get; set; }
        /// <summary>
        /// Synonyms titles for that anime.
        /// </summary>
        [XmlElement("series_synonyms")]
        public string SeriesSynonyms { get; set; }
        /// <summary>
        /// Series type TV, OVA, ONA, Music, Special, Movie...
        /// </summary>
        [XmlIgnore]
        public AnimeType SeriesType { get; set; }
        [XmlElement("series_type")]
        internal int seriesType
        {
            set
            {
                SeriesType = (AnimeType)value;
            }
        }
        /// <summary>
        /// Series total episodes count.
        /// </summary>
        [XmlElement("series_episodes")]
        public int SeriesEpisodesCount { get; set; }
        /// <summary>
        /// Series status Finished, Airing, Not aired, cancelled...
        /// </summary>
        [XmlElement("series_status")]
        public string SeriesStatus { get; set; }
        /// <summary>
        /// The start date of anime series, or 0 Ticks if it's unknown.
        /// </summary>
        [XmlIgnore]
        public DateTime SeriesStartDate { get; set; }
        [XmlElement("series_start")]
        internal string SeriesStartStr
        {
            get
            {
                return SeriesStartDate.ToShortDateString();
            }
            set
            {
                DateTime temp;
                DateTime.TryParse(value, out temp);
                SeriesStartDate = temp;
            }
        }
        /// <summary>
        /// The end date of anime series, or 0 Ticks if it's unknown.
        /// </summary>
        [XmlIgnore]
        public DateTime SeriesEndDate { get; set; }
        [XmlElement("series_end")]
        internal string SeriesEndStr
        {
            get
            {
                return SeriesEndDate.ToShortDateString();
            }
            set
            {
                DateTime temp;
                DateTime.TryParse(value, out temp);
                SeriesEndDate = temp;
            }
        }
        /// <summary>
        /// Anime series image link.
        /// </summary>
        [XmlElement("series_image")]
        public string SeriesImage { get; set; }
        /// <summary>
        /// This anime entry ID in database.
        /// </summary>
        [XmlElement("my_id")]
        public int MyId { get; set; }
        /// <summary>
        /// Your Watched episodes count.
        /// </summary>
        [XmlElement("my_watched_episodes")]
        public int MyWatchedEpisodesCount { get; set; }
        /// <summary>
        /// The date you started watching the anime series, or 0 Ticks if it's unknown.
        /// </summary>
        [XmlIgnore]
        public DateTime MyStartDate { get; set; }
        [XmlElement("my_start_date")]
        internal string MyStartDateStr
        {
            get
            {
                return MyStartDate.ToShortDateString();
            }
            set
            {
                DateTime temp;
                DateTime.TryParse(value, out temp);
                MyStartDate = temp;
            }
        }
        /// <summary>
        /// The date you finished watching the anime series, or 0 Ticks if it's unknown.
        /// </summary>
        [XmlIgnore]
        public DateTime MyFinishDate { get; set; }
        [XmlElement("my_finish_date")]
        internal string MyFninishDateStr
        {
            get
            {
                return MyFinishDate.ToShortDateString();
            }
            set
            {
                DateTime.TryParse(value, out DateTime temp);
                MyFinishDate = temp;
            }
        }
        /// <summary>
        /// The score you gave this anime series.
        /// </summary>
        [XmlElement("my_score")]
        public int MyScore { get; set; }
        /// <summary>
        /// The anime entry status Watching, Completed, Dropped, Onhold and PlanToWatch.
        /// </summary>
        [XmlIgnore]
        public AnimeListStatus MyStatus { get; set; }
        [XmlElement("my_status")]
        public int myStatus
        {
            set
            {
                MyStatus = (AnimeListStatus)value;
            }
        }
        /// <summary>
        /// The number of times you rewatched that anime series.
        /// </summary>
        [XmlIgnore]
        public int MyRewatchingCount { get; set; }
        [XmlElement("my_rewatching")]
        internal string MyRewatchingStr
        {
            get
            {
                return MyRewatchingCount.ToString();
            }
            set
            {
                int.TryParse(value, out int temp);
                MyRewatchingCount = temp;
            }
        }
        /// <summary>
        /// Your current rewatch episode number.
        /// </summary>
        [XmlElement("my_rewatching_ep")]
        public int MyReawtchingEp { get; set; }
        /// <summary>
        /// The last time you updated this anime entry.
        /// </summary>
        [XmlElement("my_last_updated")]
        public long MyLastUpdated { get; set; }
        /// <summary>
        /// Unknown. ???
        /// </summary>
        [XmlElement("my_tags")]
        public string MyTags { get; set; }

    }
}
