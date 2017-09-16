using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MALAPI.Dto
{
    [XmlRoot("entry")]
    public class Anime
    {
        [XmlElement("episode")]
        public int Episode { get; set; }
        [XmlElement("status")]
        public string Status { get; set; }
        [XmlElement("score")]
        public int Score { get; set; }
        [XmlElement("storage_type")]
        public int Storage_type { get; set; }
        [XmlElement("storage_value")]
        public float Storage_value { get; set; }
        [XmlElement("times_rewatched")]
        public int Times_rewatched { get; set; }
        [XmlElement("rewatch_value")]
        public int Rewatch_value { get; set; }
        //[XmlElement("date_start")]
        //public DateTime Date_start { get; set; }
        //[XmlElement("date_finish")]
        //public DateTime Date_end { get; set; }

        [XmlElement("date_start")]
        public string Date_start { get; set; } = "12012015";
        [XmlElement("date_finish")]
        public string Date_end { get; set; } = "12012016";

        [XmlElement("priority")]
        public int Priority { get; set; }
        [XmlElement("enable_discussion")]
        public int Enable_discussion { get; set; }
        [XmlElement("enable_rewatching")]
        public int Enable_rewatching { get; set; }
        [XmlElement("comments")]
        public string Comments { get; set; }
        [XmlElement("tags")]
        public string Tags { get; set; }
    }
}
