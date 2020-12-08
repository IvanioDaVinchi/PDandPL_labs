using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterData data = new EnterData();
            Tabyretka tab = data.GetTabyr();
            Stool stool = data.GetStool();
            Console.WriteLine(tab.Info());
            Console.WriteLine(stool.Info());
            Console.ReadLine();
        }
    }
}
