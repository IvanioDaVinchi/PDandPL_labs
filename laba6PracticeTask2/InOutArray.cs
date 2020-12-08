using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6PracticeTask2
{
    public static class InOutArray
    {
        public static double[] GetArray(string str)
        {
            double[] array = str.Split().Select(double.Parse).ToArray();
            return array;
        }
        public static void PrintArray(double[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintArray(double[] array, string name, int amount)
        {
            int count1 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count1++;
                Console.Write($"{name}[{i}]= {array[i]} ");
                if(count1 % amount == 0)
                    Console.WriteLine();
            }
        }
    }
}
