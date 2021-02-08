using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWithLinqAndXML
{
    public class xmlHelper
    {
        public void WriteListToFile(List<Dog> dogs)
        {
            XDocument document = new XDocument();
            XElement _dogs = new XElement("Dogs");
            for (int i = 0; i < dogs.Count; i++)
            {
                XElement element = new XElement("dog",
                new XAttribute("name", dogs[i].name),
                new XElement("breed", dogs[i].breed),
                new XElement("age", dogs[i].age),
                new XElement("placeLiving", dogs[i].placeLiving),
                new XElement("nameOrner", dogs[i].nameOrner));
                _dogs.Add(element);
            }
            document.Add(_dogs);
            document.Save("dogs.xml");
        }
        public XDocument GetDogsList()
        {
            List<Dog> dogs = new List<Dog>();
            XDocument document = XDocument.Load("dogs.xml");
            return document;
        }
    }
}
