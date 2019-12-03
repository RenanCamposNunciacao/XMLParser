using System;
using System.Xml.Serialization;

namespace XMLStructure.InputDocumentStructure
{
    public class InputDocument
    {
        [XmlElement]
        public DeclarationList DeclarationList { get; set; }
    }
}
