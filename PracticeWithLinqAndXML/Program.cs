using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWithLinqAndXML
{
    class Program
    {
        static void SearchOnPlaceLiving(string place)
        {
            xmlHelper helper = new xmlHelper();
            XDocument document = helper.GetDogsList();
            var items = from element in document.Element("dogs").Elements("dog")
                        where element.Element("dog").Value == place
                        select new Dog()
                        {
                            name = element.Attribute("name").Value,
                            breed = element.Element("breed").Value,
                            age = element.Element("age").Value,
                            placeLiving = element.Element("placeLiving").Value,
                            nameOrner = element.Element("nameOrner").Value
                        };
            foreach(var item in items)
                Console.WriteLine(item);
        }
        static void Menu()
        {
            Console.WriteLine("Выбирите пункт меню");
            Console.WriteLine("1) Запись нового песика");
            Console.WriteLine("2) Поиск по жилью");
            Console.WriteLine("3) Выход");
            int sw = int.Parse(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    {

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите тип жилья:");
                        string place = Console.ReadLine();
                        SearchOnPlaceLiving(place);
                        break;
                    }
                case 3:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }


        }
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("name1", "breed1", "1", "Flat", "name1"));
            dogs.Add(new Dog("name2", "breed2", "2", "Street", "name2"));
            dogs.Add(new Dog("name3", "breed3", "3", "Home", "name3"));
            dogs.Add(new Dog("name4", "breed4", "4", "Home", "name4"));
            dogs.Add(new Dog("name5", "breed5", "5", "Flat", "name5"));
            dogs.Add(new Dog("name6", "breed6", "6", "Home", "name6"));
            dogs.Add(new Dog("name7", "breed7", "7", "Steet", "name7"));
            dogs.Add(new Dog("name8", "breed8", "8", "Flat", "name8"));
            xmlHelper helper = new xmlHelper();
            helper.WriteListToFile(dogs);
            //Menu();
            Console.ReadLine();
        }
    }
}
