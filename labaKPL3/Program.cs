using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaKPL3
{
    class Program
    {
        private static double weight;

        public static double GetX(double z)
        {
            double x;
            if(z >= 1)
            {
                x = z - 1;
            }
            else
            {
                x = z * z - 1;
            }
            return x;
        }
        public static double Function(double z)
        {
            double x = GetX(z);
            return (Math.Exp(Math.Sin(Math.Pow(x, 3))) + Math.Log10(x + 1)) / Math.Sqrt(x);
        }
        public static bool ChectFourPoints(int x1,int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            return x2 + x3 == x1 + x4 && y2 + y3 == y1 + y4 || x2 + x4 == x1 + x3 && y2 + y4 == y1 + y3 || x4 == x1 + x2 && y3 + y4 == y1 + y2;
        }
        public static void Massa()
        {
            Console.WriteLine("Введите единицу измерения:");
            Console.WriteLine("1. kg");
            Console.WriteLine("2. miligramm");
            Console.WriteLine("3. gramm");
            Console.WriteLine("4. tonna");
            Console.WriteLine("5. tenter");
            int sw = int.Parse(Console.ReadLine());
            Console.WriteLine("enter weight(float difit)");
            weight = double.Parse(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    {
                        Console.WriteLine(weight);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(weight / 1000000);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(weight / 1000);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(weight * 1000);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(weight * 100);
                        break;
                    }
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Massa();
            Console.WriteLine(" Function - " + Function(4));
            if(ChectFourPoints(1, 1, 5, 3, 7, 3, 5, 1) == true)
            {
                Console.WriteLine("paralelogramm");
            }
            else
            {
                Console.WriteLine("ne paralelogramm");
            }
            Console.ReadKey();
        }
    }
}
