using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace laba_18
{
    public class XMLHelper
    {
        public int GetLenthXmlDocument(string nameFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Readers.xml");
            int count = 0;
            foreach (XmlNode n in doc.SelectNodes("/readers/reader"))
            {
                count++;
            }
            return count;
        }
        public void WriteInCenter(Reader reader)
        {
            XDocument doc = XDocument.Load("Readers.xml");
            XElement elements = doc.Element("readers");
            XElement newElement = new XElement("reader");
            XAttribute attribute = new XAttribute("numberReaderTicket", reader.numberReaderTicket);
            XElement name = new XElement("name", reader.name);
            XElement nameBook = new XElement("nameBook", reader.nameBook);
            XElement timeReturn = new XElement("timeOfreturn", reader.timeOfreturn);
            newElement.Add(attribute);
            newElement.Add(name);
            newElement.Add(nameBook);
            newElement.Add(timeReturn);
            
            doc.Add(elements);
            doc.Save("Readers.xml");
        }
        public XDocument GetDogsList()
        {
            XDocument document = XDocument.Load("Readers.xml");
            return document;
        }
    }
}
