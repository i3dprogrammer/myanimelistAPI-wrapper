using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MALAPI.Dto
{
    [XmlRoot("anime")]
    public class SearchResult
    {
        [XmlElement("entry")]
        public List<SearchEntry> Entries { get; set; }
    }

    [XmlRoot("entry")]
    public class SearchEntry
    {
        [XmlElement("id")]
        public int Id { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("english")]
        public string EnglishTitle { get; set; }
        [XmlElement("synonyms")]
        public string Synonyms { get; set; }
        [XmlElement("episodes")]
        public int Episodes { get; set; }
        [XmlElement("score")]
        public float Score { get; set; }
        [XmlElement("type")]
        public string EntryType { get; set; }
        [XmlElement("status")]
        public string Status { get; set; }
        [XmlIgnore]
        public DateTime StartDate { get; set; }
        [XmlElement("start_date")]
        public string StartDateStr
        {
            get
            {
                return StartDate.ToShortDateString();
            }
            set
            {
                DateTime temp;
                DateTime.TryParse(value, out temp);
                StartDate = temp;
            }
        }
        [XmlIgnore]
        public DateTime EndDate { get; set; }
        [XmlElement("end_date")]
        public string EndDateStr
        {
            get
            {
                return EndDate.ToShortDateString();
            }
            set {
                DateTime temp;
                DateTime.TryParse(value, out temp);
                EndDate = temp;
            }
        }
        [XmlElement("synopsis")]
        public string Synopsis { get; set; }
        [XmlElement("image")]
        public string ImageLink { get; set; }
        [XmlElement("chapters")]
        public int Chapters { get; set; }
        [XmlElement("volumes")]
        public int Volumes { get; set; }

        public override string ToString()
        {
            return $"{Title}#{Id}";
        }
    }
}
