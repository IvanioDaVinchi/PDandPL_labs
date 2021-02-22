using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodgotovkaOKR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имена трех файлов");
            string FirstFile = Console.ReadLine();
            string SecondFile = Console.ReadLine();
            string TherdFile = Console.ReadLine();
            FileHelper helper = new FileHelper();
            List<int> list = helper.ReadFromFile(FirstFile);
            if (list.Count % 2 != 0)
            {
                int i = 0;
                while(i != (list.Count() / 2) + 1)
                {

                }
            }
            list.Distinct();
            list.Sort();
            
        }
    }
}
