using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6PracticeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 6,2,4,3,5,1,7};
            InOutArray.PrintArray(array, "arr", 3);
            Helper.Sort(array, false);
            InOutArray.PrintArray(array);
            Console.ReadKey();
        }
    }
}
