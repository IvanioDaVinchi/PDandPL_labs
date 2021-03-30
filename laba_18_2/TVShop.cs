using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_18_2
{
    public class TVShop
    {
        List<XElement> list = new List<XElement>();
        XmlHelper helper = new XmlHelper();
        public TVShop()
        {
            list = helper.GetTelevizors();
            DefaultMenu();
        }
        public void Print()
        {
            Console.WriteLine("/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
            foreach (var item in list)
            {
                Console.WriteLine("\t name:  " + item.Element("name").Value);
                Console.WriteLine("\t model:  " + item.Element("model").Value);
                Console.WriteLine("\t diaganal:  " + item.Element("diaganal").Value);
                Console.WriteLine("\t price:  " + item.Element("price").Value);
                Console.WriteLine("\t count:  " + item.Element("count").Value);
                Console.WriteLine("/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
            }
        }
        public void Delivery()
        {
            for(int i = 0; i < list.Count; i++)
            { 
                int count = int.Parse(list[i].Element("count").Value);
                count++;
                list[i].Element("count").Value = count.ToString();
            }
            Print();
        }
        public void Buy()
        {
            bool check = false;
            Console.WriteLine("Введите название телевизора");
            string name = Console.ReadLine();
            Console.WriteLine("Введите модель телевизора");
            string model = Console.ReadLine();
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].Element("name").Value == name && list[i].Element("model").Value == model && Convert.ToInt32(list[i].Element("count").Value) > 0)
                {
                    check = true;
                    int count = int.Parse(list[i].Element("count").Value);
                    count--;
                    list[i].Element("count").Value = count.ToString();
                }
            }
            if(check)
                Console.WriteLine("Операция успешна!");
            else
                Console.WriteLine("Операция не успешна");
        }
       public void Search()
        {
            bool check = false;
            Console.WriteLine("Введите название телевизора");
            string name = Console.ReadLine();
            Console.WriteLine("Введите модель телевизора");
            string model = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Element("name").Value == name && list[i].Element("model").Value == model && Convert.ToInt32(list[i].Element("count").Value) > 0)
                {
                    check = true;
                    Console.WriteLine("\t name:  " + list[i].Element("name").Value);
                    Console.WriteLine("\t model:  " + list[i].Element("model").Value);
                    Console.WriteLine("\t diaganal:  " + list[i].Element("diaganal").Value);
                    Console.WriteLine("\t price:  " + list[i].Element("price").Value);
                    Console.WriteLine("\t count:  " + list[i].Element("count").Value);
                    Console.WriteLine("/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
                }
            }
            if(!check)
                Console.WriteLine("Поиск не успешен!");
        }
        public void Clon()
        {
            bool check = false;
            Console.WriteLine("Введите название телевизора");
            string name = Console.ReadLine();
            Console.WriteLine("Введите модель телевизора");
            string model = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Element("name").Value == name && list[i].Element("model").Value == model)
                {
                    check = true;
                    list.Add(new XElement(new XElement("name").Value = list[i].Element("name").Value, new XElement("model").Value = list[i].Element("model").Value, new XElement("diaganal").Value = list[i].Element("diaganal").Value,
                        new XElement("price").Value = list[i].Element("price").Value, new XElement("count").Value = list[i].Element("count").Value));
                }
            }
            if (!check)
                Console.WriteLine("Операция не успешна!");
        }
        public void DefaultMenu()
        {
            while(true)
            {
                Console.WriteLine("0) Вывод всего ассортимента");
                Console.WriteLine("1) Поставка");
                Console.WriteLine("2) Покупка");
                Console.WriteLine("3) Поиск");
                Console.WriteLine("4) Клон Заданной модели");
                int sw = int.Parse(Console.ReadLine());
                switch (sw)
                {
                    case 0:
                        {
                            Print();
                            break;
                        }
                    case 1:
                        {
                            Delivery();
                            break;
                        }
                    case 2:
                        {
                            Buy();
                            break;
                        }
                    case 3:
                        {
                            Search();
                            break;
                        }
                    case 4:
                        {
                            Clon();
                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
                helper.Resave(list);
            }
        }

    }
}
