using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XMLStructure.InputDocumentStructure
{
    [XmlRoot(ElementName = "Reference")]
    public class Reference
    {
        [XmlElement(ElementName = "RefText")]
        public string RefText { get; set; }

        [XmlAttribute(AttributeName = "RefCode")]
        public string RefCode { get; set; }
    }
}
