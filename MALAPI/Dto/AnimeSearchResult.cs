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
    /// The insatnce returned when searching for a specific anime query.
    /// </summary>
    [XmlRoot("anime")]
    public class AnimeSearchResult
    {
        /// <summary>
        /// List of entries found by the search or a null list if nothing is found.
        /// </summary>
        [XmlElement("entry")]
        public List<AnimeSearchEntry> Entries { get; set; }
    }

    /// <summary>
    /// Found anime search entry.
    /// </summary>
    [XmlRoot("entry")]
    public class AnimeSearchEntry
    {
        /// <summary>
        /// Anime id in database.
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }
        /// <summary>
        /// Anime title.
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
        /// <summary>
        /// Anime english title if found.
        /// </summary>
        [XmlElement("english")]
        public string EnglishTitle { get; set; }
        /// <summary>
        /// Anime synonyms titles if found.
        /// </summary>
        [XmlElement("synonyms")]
        public string Synonyms { get; set; }
        /// <summary>
        /// Anime total episodes count if known.
        /// </summary>
        [XmlElement("episodes")]
        public int EpisodesCount { get; set; }
        /// <summary>
        /// Anime score by total members.
        /// </summary>
        [XmlElement("score")]
        public float Score { get; set; }
        /// <summary>
        /// Anime type TV, OVA, ONA, etc...
        /// </summary>
        [XmlElement("type")]
        public AnimeType EntryType { get; set; }
        /// <summary>
        /// Anime status Finished, Airing, etc...
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// Anime start date if known, or 0 Ticks if not.
        /// </summary>
        [XmlIgnore]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Anime start date as a string.
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
        /// Anime end date if known, or 0 ticks if not.
        /// </summary>
        [XmlIgnore]
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Anime end date as a string.
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
        /// Anime description.
        /// </summary>
        [XmlElement("synopsis")]
        public string Synopsis { get; set; }
        /// <summary>
        /// Anime image link.
        /// </summary>
        [XmlElement("image")]
        public string ImageLink { get; set; }
        /// <summary>
        /// Simple ToString override that returns a nice representation of the anime entry.
        /// </summary>
        /// <returns>#{EntryType} - {Id}#{Title}</returns>
        public override string ToString()
        {
            return $"#{EntryType} - {Id}#{Title}";
        }
    }
}
