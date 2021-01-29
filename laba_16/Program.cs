using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_16
{
    class Program
    {
        static List<T>IntersectionTwoList<T>(List<T> list1, List<T> list2) => list1.Intersect(list2).ToList();
        
        static void FirstTask()
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            Console.WriteLine("Enter count value list1:");
            int count1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < count1; i++)
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
            foreach (var item in IntersectionTwoList(list1, list2))
            {
                Console.WriteLine(item);
            }
        }
        static void SecondTask()
        {
            Stack<char> stack = new Stack<char>();
            stack.Push('A');
            stack.Push('+');
            stack.Push('B');
            stack.Push('*');
            stack.Push('C');
            Console.WriteLine("Префиксная запись!");
            for(int i = 0; i < stack.Count; i++)
            {
                if (stack.ElementAt(i) == '+')
                {
                    //stack.
                    stack.Push('+');
                }
            }
        }
        static void Main(string[] args)
        {
            FirstTask();
            Console.ReadLine();
        }
    }
}
