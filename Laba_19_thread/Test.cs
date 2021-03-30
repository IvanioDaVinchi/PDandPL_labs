using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laba_19_thread
{
    public class Test
    {
        public void Print1()
        {
            while(true)
            {
                Console.WriteLine("1");
            }
        }
        public void Print2()
        {
            while (true)
            {
                Console.WriteLine("2");
            }
        }
    }
}
