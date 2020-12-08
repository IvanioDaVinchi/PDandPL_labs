using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            PerimetersTenPointsFugere();
            Task2();
            Console.ReadKey();
        }

        private static void Task2()
        {
            SummDigits(5105);
            SummDigits(55);
            SummDigits(51);
            SummDigits(51051234);
        }

        private static void SummDigits(int digit)
        {
            int sum = 0;
            while (digit != 0)
            {
                sum += digit % 10;
                digit /= 10;
            }
            Console.WriteLine($"Summa ravna {sum}");
        }

        private static void PerimetersTenPointsFugere()
        {
            int x1 = 2, y1 = 3, x2 = 3, y2 = 5, x3 = 5, y3 = 6, x4 = 7, y4 = 6, x5 = 9, y5 = 5, x6 = 10, y6 = 3, x7 = 9, y7 = 1, x8 = 7, y8 = 0, x9 = 5, y9 = 0, x10 = 3, y10 = 1;
            double V1 = GetValueVector(x1, y1, x2, y2);
            double V2 = GetValueVector(x2, y2, x3, y3);
            double V3 = GetValueVector(x3, y3, x4, y4);
            double V4 = GetValueVector(x4, y4, x5, y5);
            double V5 = GetValueVector(x5, y5, x6, y6);
            double V6 = GetValueVector(x6, y6, x7, y7);
            double V7 = GetValueVector(x7, y7, x8, y8);
            double V8 = GetValueVector(x8, y8, x9, y9);
            double V9 = GetValueVector(x9, y9, x10, y10);
            double V10 = GetValueVector(x10, y10, x1, y1);
            WritePerimetrs(V1, V2, V3, V4, V5, V6, V7, V8, V9, V10);
        }
        private static double GetValueVector(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        private static void WritePerimetrs(params double[] vectors)
        {
            double perimetrs = 0;
            foreach (var item in vectors)
            {
                perimetrs += item;
            }
            Console.WriteLine($"Perimetrs = {perimetrs}");
        }
    }
}
