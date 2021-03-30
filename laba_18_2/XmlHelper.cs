using System;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_18_2
{
    public class XmlHelper
    {
        public List<XElement> GetTelevizors()
        {
           // List<Televizor> televizors = new List<Televizor>();
            XDocument document = XDocument.Load("tv.xml");
            var televizors = document.Element(XName.Get("tvshop")).Element("televizors").Elements().ToList();
            return televizors;
        }
        public void Resave(List<XElement> list)
        {
            XDocument document = XDocument.Load("tv.xml");
            document.Element("tvshop").Element("televizors").ReplaceAll(list);
            document.Save("tv.xml");
        }
    }
}
