using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MALAPI.Dto
{
    /// <summary>
    /// The instance returned when getting a specific user manga list.
    /// </summary>
    [Serializable, XmlRoot("myanimelist")]
    public class UserMangaList
    {
        /// <summary>
        /// Info about the user list.
        /// </summary>
        [XmlElement("myinfo")]
        public UserAnimeInfo Info { get; set; }
        /// <summary>
        /// The mangas in that user list.
        /// </summary>
        [XmlElement("manga")]
        public List<UserAnime> Mangas { get; set; }
    }

    [Serializable, XmlRoot("myinfo")]
    public class UserMangaInfo
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
        /// Mangas Currently reading count.
        /// </summary>
        [XmlElement("user_reading")]
        public int ReadingCount { get; set; }
        /// <summary>
        /// Mangas compeleted count.
        /// </summary>
        [XmlElement("user_completed")]
        public int CompletedCount { get; set; }
        /// <summary>
        /// Mangas onhold count.
        /// </summary>
        [XmlElement("user_onhold")]
        public int OnholdCount { get; set; }
        /// <summary>
        /// Mangas dropped count.
        /// </summary>
        [XmlElement("user_dropped")]
        public int DroppedCount { get; set; }
        /// <summary>
        /// Mangas planned to read count.
        /// </summary>
        [XmlElement("user_plantoread")]
        public int PlanToReadCount { get; set; }
        /// <summary>
        /// Days user spent reading mangas.
        /// </summary>
        [XmlElement("user_days_spent_watching")]
        public float DaysSpentReading { get; set; }

        /// <summary>
        /// A simple ToString override to return user name + Id
        /// </summary>
        /// <returns>Returns "USERNAME"#"ID"</returns>
        public override string ToString()
        {
            return Name + "#" + Id;
        }
    }

    /// <summary>
    /// Manga entry in the user list.
    /// </summary>
    [Serializable, XmlRoot("manga")]
    public class UserManga
    {
        /// <summary>
        /// Manga ID in the database.
        /// </summary>
        [XmlElement("series_mangadb_id")]
        public int SeriesId { get; set; }
        /// <summary>
        /// manga title.
        /// </summary>
        [XmlElement("series_title")]
        public string SeriesTitle { get; set; }
        /// <summary>
        /// Synonyms titles for that manga.
        /// </summary>
        [XmlElement("series_synonyms")]
        public string SeriesSynonyms { get; set; }
        /// <summary>
        /// Unknown. ???
        /// </summary>
        [XmlElement("series_type")]
        public int SeriesType { get; set; }
        /// <summary>
        /// Manga total chapters count.
        /// </summary>
        [XmlElement("series_chapters")]
        public int SeriesChaptersCount { get; set; }
        /// <summary>
        /// Manga total volumes count.
        /// </summary>
        [XmlElement("series_volumes")]
        public int SeriesVolumesCount { get; set; }
        /// <summary>
        /// Manga status Finished, Publishing, Hiatus...
        /// </summary>
        [XmlElement("series_status")]
        public int SeriesStatus { get; set; }
        /// <summary>
        /// The start date of manga series, or 0 Ticks if it's unknown.
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
        /// The end date of manga series, or 0 Ticks if it's unknown.
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
        /// This manga entry ID in database.
        /// </summary>
        [XmlElement("my_id")]
        public int MyId { get; set; }
        /// <summary>
        /// Your read chapters count.
        /// </summary>
        [XmlElement("my_read_chapters")]
        public int MyReadChapters { get; set; }
        /// <summary>
        /// Your read volumes count.
        /// </summary>
        [XmlElement("my_read_volumes")]
        public int MyReadVolumes { get; set; }
        /// <summary>
        /// The date you started reading the manga series, or 0 Ticks if it's unknown.
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
        /// The date you finished reading the manga series, or 0 Ticks if it's unknown.
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
                DateTime temp;
                DateTime.TryParse(value, out temp);
                MyFinishDate = temp;
            }
        }
        /// <summary>
        /// The score you gave this manga series.
        /// </summary>
        [XmlElement("my_score")]
        public int MyScore { get; set; }
        /// <summary>
        /// The manga entry status Reading, Completed, Dropped, Onhold and PlanToRead.
        /// </summary>
        [XmlElement("my_status")]
        public MangaListStatus MyStatus { get; set; }
        /// <summary>
        /// The number of times you reread the manga series.
        /// </summary>
        [XmlIgnore]
        public int MyRereadingCount { get; set; }

        [XmlElement("my_rereading")]
        internal string MyRereadingStr
        {
            get
            {
                return MyRereadingCount.ToString();
            }
            set
            {
                int temp = 0;
                int.TryParse(value, out temp);
                MyRereadingCount = temp;
            }
        }
        /// <summary>
        /// Your current reread chapter number.
        /// </summary>
        [XmlElement("my_rereading_chap")]
        public int MyReadingChapter { get; set; }
        /// <summary>
        /// The last time you updated this manga entry.
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
