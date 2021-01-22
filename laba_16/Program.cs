using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_16
{
    class Program
    {
        static List<T> FirstTask<T>(List<T> list1, List<T> list2) => list1.Intersect(list2).ToList();
        
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            Console.WriteLine("Enter count value list1:");
            int count1 = int.Parse(Console.ReadLine());
            for(int i = 0; i < count1; i++)
            {
                Console.WriteLine("Enter value:");
                list1.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Enter count value list2:");
            int count2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < count2; i++)
            {
                Console.WriteLine("Enter value:");
                list2.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("-------");
            foreach (var item in FirstTask(list1, list2))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
