using System;
using System.Threading;

namespace Laba_19_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Thread thread1 = new Thread(new ThreadStart(test.Print1));
            Thread thread2 = new Thread(new ThreadStart(test.Print2));
            thread1.Start();
            thread2.Start();
            Console.ReadLine();
        }
    }
}
