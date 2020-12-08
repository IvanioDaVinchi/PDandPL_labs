using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_11
{
    class Program
    {
        static void Main(string[] args)
        {
            CharArray Ca = new CharArray();
            Circle[] array = new Circle[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("X - Y - R");
                int X = int.Parse(Console.ReadLine());
                int Y = int.Parse(Console.ReadLine());
                int R = int.Parse(Console.ReadLine());
                array[i] = new Circle(X,Y,R);
            }
            Array.Sort(array);
            foreach (var item in array)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
