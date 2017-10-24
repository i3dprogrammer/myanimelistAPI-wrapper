using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MALAPI.Dto
{
    /// <summary>
    /// An object the holds anime data to be added or updated in a specific user anime list.
    /// </summary>
    [XmlRoot("entry")]
    public class AnimeEntry
    {
        /// <summary>
        /// The count of episodes you watched from this anime.
        /// </summary>
        [XmlElement("episode")]
        public int WatchedEpisodes { get; set; }
        /// <summary>
        /// The status of the anime Currently watching, Dropped, Onhold, etc...
        /// </summary>
        [XmlElement("status")]
        public AnimeListStatus Status { get; set; }
        /// <summary>
        /// The score you give this anime.
        /// </summary>
        [XmlIgnore]
        public EntryScore Score { get; set; }
        /// <summary>
        /// The score you give this anime as int (1-10)
        /// </summary>
        [XmlElement("score")]
        public int ScoreInt
        {
            get
            {
                return (int)Score;
            }
            set
            {
                Score = (EntryScore)value;
            }
        }
        /// <summary>
        /// Unknown. ??? Probably where you store this anime PC/Lap??
        /// </summary>
        [XmlElement("storage_type")]
        public int StorageType { get; set; }
        /// <summary>
        /// Unknown. ???
        /// </summary>
        [XmlElement("storage_value")]
        public float StorageValue { get; set; }
        /// <summary>
        /// The count of times you've rewatched this anime.
        /// </summary>
        [XmlElement("times_rewatched")]
        public int TimesRewatched { get; set; }
        /// <summary>
        /// Current rewatch episode.
        /// </summary>
        [XmlElement("rewatch_value")]
        public int RewatchValue { get; set; }
        /// <summary>
        /// The date you started watching this anime.
        /// </summary>
        [XmlIgnore]
        public DateTime DateStart { get; set; }
        /// <summary>
        /// The date you started watching this anime as string.
        /// </summary>
        [XmlElement("date_start")]
        public string DateStartStr
        {
            get
            {
                return DateStart.ToString("mmddyyyy");
            }
        }
        /// <summary>
        /// The date you finished watching this anime.
        /// </summary>
        [XmlIgnore]
        public DateTime DateEnd { get; set; }
        /// <summary>
        /// The date you finished watching this anime as string.
        /// </summary>
        [XmlElement("date_finish")]
        public string DateEndStr
        {
            get
            {
                return DateEnd.ToString("mmddyyyy");
            }
        }
        /// <summary>
        /// The anime priority on the list.
        /// </summary>
        [XmlElement("priority")]
        public int Priority { get; set; }
        /// <summary>
        /// Enable anime discussion.
        /// </summary>
        [XmlElement("enable_discussion")]
        public int EnableDiscussion { get; set; }
        /// <summary>
        /// Enable anime rewatching.
        /// </summary>
        [XmlElement("enable_rewatching")]
        public int EnableRewatching { get; set; }
        /// <summary>
        /// Comments about this anime.
        /// </summary>
        [XmlElement("comments")]
        public string Comments { get; set; }
        /// <summary>
        /// Unknown. ???
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }
    }
}
