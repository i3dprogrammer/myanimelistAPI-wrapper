using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MALAPI.Dto
{
    [XmlRoot("entry")]
    public class Manga
    {
        [XmlElement("chapter")]
        public int Chapter { get; set; }
        [XmlElement("volume")]
        public int Volume { get; set; }
        [XmlElement("status")]
        public string Status { get; set; }
        [XmlElement("score")]
        public int Score { get; set; }
        [XmlElement("times_reread")]
        public int TimesReread{ get; set; }
        [XmlElement("reread_value")]
        public int RereadValue { get; set; }

        [XmlElement("date_start")]
        public string DateStartStr
        {
            get
            {
                return DateStart.ToString("mmddyyyy");
            }
        }
        [XmlIgnore]
        public DateTime DateStart { get; set; }
        [XmlElement("date_finish")]
        public string DateEndStr
        {
            get
            {
                return DateEnd.ToString("mmddyyyy");
            }
        }
        [XmlIgnore]
        public DateTime DateEnd { get; set; }

        [XmlElement("priority")]
        public int Priority { get; set; }
        [XmlElement("enable_discussion")]
        public int Enable_discussion { get; set; }
        [XmlElement("enable_rereading")]
        public int EnableRereading { get; set; }
        [XmlElement("comments")]
        public string Comments { get; set; }
        [XmlElement("scan_group")]
        public string ScanGroup { get; set; }
        [XmlElement("retail_volumes")]
        public string RetailVolumes { get; set; }
    }
}
