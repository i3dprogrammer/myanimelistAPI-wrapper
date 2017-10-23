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
    public class Manga
    {
        /// <summary>
        /// The count of chapters you've read from this manga.
        /// </summary>
        [XmlElement("chapter")]
        public int Chapter { get; set; }
        /// <summary>
        /// The count of volumes you've read from this manga.
        /// </summary>
        [XmlElement("volume")]
        public int Volume { get; set; }
        /// <summary>
        /// The status of the manga Currently reading, dropped, onhold, etc...
        /// </summary>
        [XmlElement("status")]
        public MangaListStatus Status { get; set; }
        /// <summary>
        /// The score you give this manga.
        /// </summary>
        [XmlElement("score")]
        public int Score { get; set; }
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
        /// The date youve started reading this manga.
        /// </summary>
        [XmlIgnore]
        public DateTime DateStart { get; set; }
        [XmlElement("date_start")]
        internal string DateStartStr
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
        [XmlElement("date_finish")]
        internal string DateEndStr
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
