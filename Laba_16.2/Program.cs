using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MySet<int> obj = new MySet<int>();
            for(int i = 0; i < obj.n; i++)
            {
                Console.WriteLine("Enter new element:");
                obj.AddNewElementInSet(int.Parse(Console.ReadLine()));
            }
            foreach(var item in obj.hashSet)
            {
                Console.WriteLine(item);
            }
            MySet<int> obj1 = new MySet<int>();
            for (int i = 0; i < obj1.n; i++)
            {
                Console.WriteLine("Enter new element:");
                obj.AddNewElementInSet(int.Parse(Console.ReadLine()));
            }
            foreach (var item in obj1.hashSet)
            {
                Console.WriteLine(item);
            }
            var objt = obj + obj1;
            foreach (var item in objt)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
