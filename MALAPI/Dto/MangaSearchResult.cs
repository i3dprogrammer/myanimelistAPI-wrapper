using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MALAPI.Dto
{
    /// <summary>
    /// The instance returned when searching for specific manga query.
    /// </summary>
    [XmlRoot("manga")]
    public class MangaSearchResult
    {
        /// <summary>
        /// List of entries found by the search or a null list if nothing is found.
        /// </summary>
        [XmlElement("entry")]
        public List<MangaSearchEntry> Entries { get; set; }
    }

    /// <summary>
    /// Found manga search entry.
    /// </summary>
    [XmlRoot("entry")]
    public class MangaSearchEntry
    {
        /// <summary>
        /// Manga id in database.
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }
        /// <summary>
        /// Manga title.
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
        /// <summary>
        /// Manga english title if found.
        /// </summary>
        [XmlElement("english")]
        public string EnglishTitle { get; set; }
        /// <summary>
        /// Manga synonyms titles if found.
        /// </summary>
        [XmlElement("synonyms")]
        public string Synonyms { get; set; }
        /// <summary>
        /// Manga score by total members.
        /// </summary>
        [XmlElement("score")]
        public float Score { get; set; }
        /// <summary>
        /// Manhwa, Manga, etc..???
        /// </summary>
        [XmlElement("type")]
        public string EntryType { get; set; }
        /// <summary>
        /// Manga status Finished, Publishing, Hiatus, etc...
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// Manga start date if known, or 0 Ticks if not.
        /// </summary>
        [XmlIgnore]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Manga start date as a string.
        /// </summary>
        [XmlElement("start_date")]
        public string StartDateStr
        {
            get
            {
                return StartDate.ToShortDateString();
            }
            set
            {
                DateTime.TryParse(value, out DateTime temp);
                StartDate = temp;
            }
        }
        /// <summary>
        /// Manga end date if known, or 0 Ticks if not.
        /// </summary>
        [XmlIgnore]
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Manga end date as a string.
        /// </summary>
        [XmlElement("end_date")]
        public string EndDateStr
        {
            get
            {
                return EndDate.ToShortDateString();
            }
            set {
                DateTime.TryParse(value, out DateTime temp);
                EndDate = temp;
            }
        }
        /// <summary>
        /// Manga description.
        /// </summary>
        [XmlElement("synopsis")]
        public string Synopsis { get; set; }
        /// <summary>
        /// Manga image link.
        /// </summary>
        [XmlElement("image")]
        public string ImageLink { get; set; }
        /// <summary>
        /// Manga total chapters count.
        /// </summary>
        [XmlElement("chapters")]
        public int Chapters { get; set; }
        /// <summary>
        /// Manga total volumes count.
        /// </summary>
        [XmlElement("volumes")]
        public int Volumes { get; set; }

        /// <summary>
        /// Simple ToString override that returns a nice representation of the manga entry.
        /// </summary>
        /// <returns>#{EntryType} - {Id}#{Title}</returns>
        public override string ToString()
        {
            return $"#{EntryType} - {Id}#{Title}";
        }
    }
}
