using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoXmlSerializer
{
    [XmlRoot("Candidate")]
    public class Person
    {
        [XmlElement("FirstName")]
        public string Name { get; set; }
        [XmlElement("RoughAge")]
        public int Age { get; set; }
    }
}
