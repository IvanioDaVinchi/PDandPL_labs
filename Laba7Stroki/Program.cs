using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7Stroki
{
    class Program
    {
        private static string EnterText()
        {
            Console.WriteLine("Введите строку человек:");
            string text = Console.ReadLine();
            return text;
        }
        private static void PrintStr(int n, string str)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(str);
            }
        }
        private static void FirstTAsk(string str1, string str2)
        {
            if(str1.Length > str2.Length)
            {
                int n = str1.Length - str2.Length;
                PrintStr(n,str1);
            }
            else
            {
                if(str1.Length < str2.Length)
                {
                    int n = str2.Length - str1.Length;
                    PrintStr(n, str2);
                }
                else
                {
                    Console.WriteLine("Строки равны!");
                }
            }
        }
        private static void PrintForSecondTask(string[] arrayStrings)
        {
            for(int i = 0; i < arrayStrings.Length; i++)
            {
                Console.WriteLine(arrayStrings[i]);
            }
        }
        private static void SwapOnRandom(string[] arrayStrings)
        {
            Random rnd = new Random();
            for(int i = 0; i < arrayStrings.Length; i++)
            {
                if(arrayStrings[i].Length == 3)
                {
                    string str = arrayStrings[i];
                    arrayStrings[i] = str.Replace(str[1], (char)rnd.Next(0x0410, 0x44F));
                }
            }

        }
        private static void SecondTask(string str)
        {

            string[] arrayStrings = new string[(str.Length / 3) + 1];
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                arrayStrings[index] += str[i];
                if ((i + 1) % 3 == 0)
                {
                    index++;
                }
            }
            PrintForSecondTask(arrayStrings);
            SwapOnRandom(arrayStrings);
            Console.WriteLine("posle swap:");
            PrintForSecondTask(arrayStrings);
            Array.Sort(arrayStrings);
            Console.WriteLine("Print posle sort");
            PrintForSecondTask(arrayStrings);
        }
        private static void Print(string[] array)
        {
            foreach(var item in array)
            {
                if(item != "")
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            //string str1 = EnterText();
            //string str2 = EnterText();
            //FirstTAsk(str1,str2);
            //string str3 = EnterText();
            //SecondTask(str3);
            Print(Poet.oneWord);
            Console.WriteLine("/////////////////////////");
            Print(Poet.Swap());
            Console.WriteLine("/////////////////////////");
            Poet.FindRepeatWordCount();
            Console.WriteLine("//////////////////////////");
            Poet.Three();
            Console.ReadKey();
        }
    }
}
