using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MALAPI.Dto
{
    /// <summary>
    /// An object the holds manga data to be added or updated in a specific user manga list.
    /// </summary>
    [XmlRoot("entry")]
    public class MangaEntry
    {
        /// <summary>
        /// The count of chapters you've read from this manga.
        /// </summary>
        [XmlElement("chapter")]
        public int ReadChapters { get; set; }
        /// <summary>
        /// The count of volumes you've read from this manga.
        /// </summary>
        [XmlElement("volume")]
        public int ReadVolumes { get; set; }
        /// <summary>
        /// The status of the manga Reading, dropped, onhold, etc...
        /// </summary>
        [XmlElement("status")]
        public MangaListStatus Status { get; set; }
        /// <summary>
        /// The score you give this manga.
        /// </summary>
        [XmlIgnore]
        public EntryScore Score { get; set; }
        /// <summary>
        /// The score you give this manga as int (1-10)
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
        /// The count of times you've reread the manga.
        /// </summary>
        [XmlElement("times_reread")]
        public int TimesReread{ get; set; }
        /// <summary>
        /// Current reread chapter.
        /// </summary>
        [XmlElement("reread_value")]
        public int RereadValue { get; set; }
        /// <summary>
        /// The date you've started reading this manga.
        /// </summary>
        [XmlIgnore]
        public DateTime DateStart { get; set; }
        /// <summary>
        /// The date you've started reading this manga as a string.
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
        /// The date you've finished reading this manga.
        /// </summary>
        [XmlIgnore]
        public DateTime DateEnd { get; set; }
        /// <summary>
        /// The date you've finished reading this manga as a string.
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
        /// The manga priority on the list.
        /// </summary>
        [XmlElement("priority")]
        public int Priority { get; set; }
        /// <summary>
        /// Enable manga discussion.
        /// </summary>
        [XmlElement("enable_discussion")]
        public int Enable_discussion { get; set; }
        /// <summary>
        /// Enable manga rereading.
        /// </summary>
        [XmlElement("enable_rereading")]
        public int EnableRereading { get; set; }
        /// <summary>
        /// Comments about this manga.
        /// </summary>
        [XmlElement("comments")]
        public string Comments { get; set; }
        /// <summary>
        /// Unknown. ???
        /// </summary>
        [XmlElement("scan_group")]
        public string ScanGroup { get; set; }
        /// <summary>
        /// Unknown. ???
        /// </summary>
        [XmlElement("retail_volumes")]
        public string RetailVolumes { get; set; }
    }
}
