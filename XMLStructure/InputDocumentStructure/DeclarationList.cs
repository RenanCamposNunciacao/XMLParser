using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XMLStructure.InputDocumentStructure
{
    [XmlRoot(ElementName = "DeclarationList")]
    public class DeclarationList
    {
        [XmlElement(ElementName = "Declaration")]
        public Declaration Declaration { get; set; }
    }
}