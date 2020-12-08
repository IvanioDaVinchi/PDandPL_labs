using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Laba5
{
    public class Product
    {
        string name;
        double cost;
        string brend;
        int year;
        public string Name {
            set
            {
               int num;
                bool IsNum = int.TryParse(value, out num);
                if (IsNum)
                {
                    Console.WriteLine("Цифры вводить в имя нельзя!");
                    Name = "";
                }
                else
                    name = value;
            }
        }
        public double Cost
        {
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Цена не может быть отрицательной! Присвоем 0");
                    cost = 0;
                }
                else
                    cost = value;
            }
        }
        public string Brend {
            set
            {
                int num;
                bool IsNum = int.TryParse(value, out num);
                if (IsNum)
                {
                    Console.WriteLine("Цифры вводить в имя бренда! Присвоем пустую строчку");
                    brend = "";
                }
                else
                    brend = value;
            }
        }
        public int Year {
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Год не может быть отрицательный! Присвоем 0");
                    year = 0;
                }
                else
                    year = value;
            }
        }
        public Product(string name, double cost, string brend, int year)
        {
            Name = name;
            Cost = cost;
            Brend = brend;
            Year = year;
        }
        public void CurrancyExchenge(double dollar, double euro)
        {
            Console.WriteLine($"cost {name} on $: {(cost / dollar):0.##}; cost on euro: {(cost / euro):0.##};");
        }
        public void AgeProduct()
        {
            Console.WriteLine($"Age product {name} is: {DateTime.Today.Year - year}");
        }
        public void CostOfTV()
        {
            if(name.Contains("TV") == true)
            {
                cost = cost * 1.2;
                Console.WriteLine($"cost of product {name}:{cost}");
            }
        }
    }
}
