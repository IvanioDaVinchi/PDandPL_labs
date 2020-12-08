using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите курс доллара и евро:");
            double dollar = double.Parse(Console.ReadLine());
            double euro = double.Parse(Console.ReadLine());
            Product obj = new Product("Phone", 1750, "Apple", 2019);
            obj.CurrancyExchenge(dollar,euro);
            obj.AgeProduct();
            Product obj1 = new Product("iTV" , 1450, "Samsung", 2018);
            obj1.AgeProduct();
            obj1.CostOfTV();
            obj1.CurrancyExchenge(dollar, euro);
            Console.ReadKey();
        }
    }
}
