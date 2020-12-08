using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_11
{
    public class CharArray
    {
        char[] array;

        public CharArray()
        {
            Start();
        }

        public void Start()
        {
            Console.WriteLine("Как будем заполнять:\n1) Рандом\n2) Ручками");
            int sw = int.Parse(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    {
                        RandomFilling();
                        Sort();
                        break;
                    }
                case 2:
                    {
                        ManuallyFiling();
                        Sort();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("error");
                        Start();
                        break;
                    }
            }
        }
        public void RandomFilling()
        {
            Random rnd = new Random();
            array = new char[rnd.Next(10, 20)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToChar(rnd.Next('a', 'a' + 27));
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        public void ManuallyFiling()
        {
            string text = Console.ReadLine();
            array = new char[text.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToChar(text[i]);
            }
        }
        public void Sort()
        {
            for(int i = 0; i < array.Length; i++)
            {
                Array.Sort(array, new SortGlasnii());
            }
            Console.WriteLine(array);
        }
    }
}
