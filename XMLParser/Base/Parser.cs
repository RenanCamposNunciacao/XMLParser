using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLParser
{
    public class ParseXML
    {
        public static T Parse<T>(TextReader pXMLContent)
        {
            T lReturn = default(T);

            try
            {
                XmlSerializer lXmlSerializer = new XmlSerializer(typeof(T));
                lReturn = (T)lXmlSerializer.Deserialize(pXMLContent);
            }
            catch
            {
                lReturn = default(T);
            }

            return lReturn;
        }
    }
}
