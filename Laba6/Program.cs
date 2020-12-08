using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    class Program
    {
        private static double[] GetArray(int size)
        {
            double[] array = new double[size];
            Console.WriteLine("Выберите способ заполнения:(1.Рандом -- 2.Кривые ручки)");
            int sw = int.Parse(Console.ReadLine());
            if(sw == 1)
            {
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(-50, 100);
                }
                return array;
            }
            else
            {
                for(int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToDouble(Console.ReadLine());
                }
                return array;
            }
        }
        private static void FirstTask(int[] array)
        {
            int count = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] < (array[i - 1] + array[i + 1]) / 2)
                {
                    count++;
                    Console.WriteLine($"{array[i]} -- {i}");
                }
            }
            Console.WriteLine($"Количество подходящих под условие -- {count}");
        }
        private static void SecoundTask(int[] array)
        {
            int indexMin = 0;
            int indexMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[indexMin] > array[i])
                {
                    indexMin = i;
                }
                if (array[indexMax] < array[i])
                {
                    indexMax = i;
                }
            }
            int temp = array[indexMin];
            array[indexMin] = array[indexMax];
            array[indexMax] = temp;
            PrintArray(array);
        }
        private static void ThreeTask(int[] array)
        {
            bool check = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    check = true;
                    break;
                }
            }
            if (check)
                Console.WriteLine("есть убывание");
            else
                Console.WriteLine("неубывающий");

        }
        private static void PrintArray(int[] array)
        {
            foreach(var item in array)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = new int[8] { 1,2,3,4,5,6,7,8};
            FirstTask(array);
            SecoundTask(array);
            ThreeTask(array);
            Console.ReadKey();
        }
    }
}
