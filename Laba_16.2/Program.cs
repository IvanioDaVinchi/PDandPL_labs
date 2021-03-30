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
            Console.WriteLine("--------------------------");
            MySet<int> obj1 = new MySet<int>();
            for (int i = 0; i < obj1.n; i++)
            {
                Console.WriteLine("Enter new element(other set):");
                obj.AddNewElementInSet(int.Parse(Console.ReadLine()));
            }
            foreach (var item in obj1.hashSet)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            var objt = obj + obj1;
            Console.WriteLine("After union");
            foreach (var item in objt)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            var setLast = new MySet<int>();
            setLast.hashSet.Add(1);
            setLast.hashSet.Add(2);
            setLast.hashSet.Add(3);
            setLast++;
            Console.WriteLine("after ++");
            foreach (var item in setLast.hashSet)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}