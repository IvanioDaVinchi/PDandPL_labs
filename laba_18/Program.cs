using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace laba_18
{
    class Program
    {
        static void SearchOnTicket(string ticket)
        {
            XMLHelper helper = new XMLHelper();
            XDocument document = helper.GetDogsList();
            var items = from element in document.Element("readers").Elements("reader")
                        where element.Attribute("numberReaderTicket").Value == ticket
                        select new Reader()
                        {
                            name = element.Element("name").Value,
                            numberReaderTicket = element.Attribute("numberReaderTicket").Value,
                            nameBook = element.Element("nameBook").Value,
                            timeOfreturn = element.Element("timeOfreturn").Value
                        };
            foreach (var item in items)
                Console.WriteLine(item);
        }
        static void Print()
        {
            XMLHelper helper = new XMLHelper();
            XmlDocument document = new XmlDocument();
            document.Load("Readers.xml");
            foreach(XmlNode n in document.SelectNodes("/readers/reader"))
            {
                Console.WriteLine($" numberReaderTicket - {n.Attributes["numberReaderTicket"].Value}");
                Console.WriteLine($" name - {n.SelectSingleNode("name").InnerText}");
                Console.WriteLine($" nameBook - {n.SelectSingleNode("nameBook").InnerText}");
                Console.WriteLine($" timeOfreturn - {n.SelectSingleNode("timeOfreturn").InnerText}");
                Console.WriteLine("---------------------------------------------------------------");
            }
        }
        static void Menu()
        {
            while(true)
            {
                Console.WriteLine("Выберите пункт меню, что бы продалжить:");
                Console.WriteLine("1) Добавление в середину");
                Console.WriteLine("2) Поиск по номеру билета");
                int sw = int.Parse(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите ФИО - Номер читательского билета - Название книги - время до сдачи");
                            string _name = Console.ReadLine();
                            string _numberTicket = Console.ReadLine();
                            string _nameBook = Console.ReadLine();
                            string _time = Console.ReadLine();
                            Reader reader = new Reader()
                            {
                                name = _name,
                                numberReaderTicket = _numberTicket,
                                nameBook = _nameBook,
                                timeOfreturn = _time
                            };
                            XMLHelper helper = new XMLHelper();
                            helper.WriteInCenter(reader);
                            Print();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Введите номер билета читателя, которого хотите найти:");
                            var number = Console.ReadLine();
                            SearchOnTicket(number);
                            break;
                        }
                    case 3:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Print();
            Menu();
        }
    }
}
