using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MALAPI.Dto
{
    [Serializable, XmlRoot("myanimelist")]
    public class UserList
    {
        [XmlElement("myinfo")]
        public UserInfo Info { get; set; }
        [XmlElement("anime")]
        public List<UserAnime> Animes { get; set; }
    }

    [Serializable, XmlRoot("myinfo")]
    public class UserInfo
    {
        [XmlElement("user_id")]
        public int Id { get; set; }
        [XmlElement("user_name")]
        public string Name { get; set; }
        [XmlElement("user_watching")]
        public int WatchingCount { get; set; }
        [XmlElement("user_completed")]
        public int CompletedCount { get; set; }
        [XmlElement("user_onhold")]
        public int OnholdCount { get; set; }
        [XmlElement("user_dropped")]
        public int DroppedCount { get; set; }
        [XmlElement("user_plantowatch")]
        public int PlanToWatchCount { get; set; }
        [XmlElement("user_days_spent_watching")]
        public float DaysSpentWatching { get; set; }

        public override string ToString()
        {
            return Name + "#" + Id;
        }
    }

    [Serializable, XmlRoot("anime")]
    public class UserAnime
    {
        [XmlElement("series_animedb_id")]
        public int SeriesId { get; set; }
        [XmlElement("series_title")]
        public string SeriesTitle { get; set; }
        [XmlElement("series_synonyms")]
        public string SeriesSynonyms { get; set; }
        [XmlElement("series_type")]
        public int SeriesType { get; set; }
        [XmlElement("series_episodes")]
        public int SeriesEpisodesCount { get; set; }
        [XmlElement("series_status")]
        public int SeriesStatus { get; set; }

        [XmlIgnore]
        public DateTime SeriesStart { get; set; }
        [XmlElement("series_start")]
        public string SeriesStartStr
        {
            get
            {
                return SeriesStart.ToShortDateString();
            }
            set
            {
                DateTime temp;
                DateTime.TryParse(value, out temp);
                SeriesStart = temp;
            }
        }

        [XmlIgnore]
        public DateTime SeriesEnd { get; set; }
        [XmlElement("series_end")]
        public string SeriesEndStr
        {
            get
            {
                return SeriesEnd.ToShortDateString();
            }
            set
            {
                DateTime temp;
                DateTime.TryParse(value, out temp);
                SeriesEnd = temp;
            }
        }

        [XmlElement("series_image")]
        public string SeriesImage { get; set; }
        [XmlElement("my_id")]
        public int MyId { get; set; }
        [XmlElement("my_watched_episodes")]
        public int MyWatchedEpisodes { get; set; }

        [XmlIgnore]
        public DateTime MyStartDate { get; set; }
        [XmlElement("my_start_date")]
        public string MyStartDateStr
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

        [XmlIgnore]
        public DateTime MyFinishDate { get; set; }
        [XmlElement("my_finish_date")]
        public string MyFninishDateStr
        {
            get
            {
                return MyFinishDate.ToShortDateString();
            }
            set
            {
                DateTime temp;
                DateTime.TryParse(value, out temp);
                MyFinishDate = temp;
            }
        }

        [XmlElement("my_score")]
        public int MyScore { get; set; }

        [XmlElement("my_status")]
        public int MyStatus { get; set; }

        [XmlIgnore]
        public int MyRewatchingCount { get; set; }
        [XmlElement("my_rewatching")]
        public string MyRewatchingStr
        {
            get
            {
                return MyRewatchingCount.ToString();
            }
            set
            {
                int temp = 0;
                int.TryParse(value, out temp);
                MyRewatchingCount = temp;
            }
        }

        [XmlElement("my_rewatching_ep")]
        public int MyReawtchingEp { get; set; }

        [XmlElement("my_last_updated")]
        public long MyLastUpdated { get; set; }

        [XmlElement("my_tags")]
        public string MyTags { get; set; }

    }
}
