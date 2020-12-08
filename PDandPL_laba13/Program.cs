using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDandPL
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression progression = new ArithmeticProgression(7,20);
            progression.PrintArithmeticProgression();
            Console.WriteLine($"Sum progression element = {progression.SumElementsProgression()}");
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"{index} element - {progression.GetNElement(index)}");
            Console.ReadLine();
        }
    }
}
