using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_19
{
    class Program
    {
        static Semaphore SEMA = new Semaphore(1,2);
        static int LoadDigitFromFile(string path)
        {
            int digit = 0;
            SEMA.WaitOne();
            using (StreamReader reader = new StreamReader(path))
            {
                digit = int.Parse(reader.ReadToEnd());
            }
            SEMA.Release();
            return digit;
        }
        static void SumNumbers1()
        {
            int digit = LoadDigitFromFile("numbers.in.txt");
            int sum = 0;
            int i = 0;
            int n = digit.ToString().Count();
            while (digit != 0)
            {
                i++;
                int number = digit % 10;
                if(number % 2 == 0)
                {
                    sum += digit % 10;
                }
                digit /= 10;
                SEMA.WaitOne();
                using (StreamWriter writer = new StreamWriter("state.out.txt", true))
                {
                    writer.WriteLine($" Thread 1: {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}; Perhent : {((double)i / n) * 100,4:00.00}, Answer - {sum}");
                }
                SEMA.Release();
                Thread.Sleep(200);
            }
        }
        static void SumNumbers2()
        {
            int digit = LoadDigitFromFile("numbers.in.txt");
            int sum = 0;
            int i = 0;
            int n = digit.ToString().Count();
            while (digit != 0)
            {
                i++;
                int number = digit % 10;
                if (number % 2 == 0)
                {
                    sum += digit % 10;
                }
                digit /= 10;
                SEMA.WaitOne();
                using (StreamWriter writer = new StreamWriter("state.out.txt", true))
                {
                    writer.WriteLine($" Thread 2 delegate : {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}; Perhent : {((double)i / n) * 100,4:00.00}, Answer - {sum}");
                }
                SEMA.Release();
                Thread.Sleep(400);
            }
            
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(SumNumbers1));
            Thread thread2 = new Thread(new ThreadStart(SumNumbers2));
            thread1.Start();
            thread2.Start();
            Console.ReadLine();
        }
    }
}
