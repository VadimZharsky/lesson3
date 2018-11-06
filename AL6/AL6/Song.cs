using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AL6
{
    [Serializable()]
    public class Song
    {
        [XmlElement("title")]
        public string title { get; set; }
        [XmlElement("author")]
        public string author { get; set; }
        [XmlElement("duration")]
        public double duration { get; set; }
        [XmlElement("year")]
        public string year { get; set; }
    }
}
