using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace laba20
{
    class Program
    {
        class Test
        {
            double progress;
            int sum;
            public Test()
            {
                progress = 0;
                sum = 0;
            }
            public Test(double progress, int sum)
            {
                this.progress = progress;
                this.sum = sum;
            }
            public double Progress
            {
                get
                {
                    return progress;
                }
                set
                {
                    value = progress;
                }
            }
            public int Sum
            {
                get
                {
                    return sum;
                }
                set
                {
                    value = sum;
                }
            }
        }
        static void Main(string[] args)
        {
            Func<int, Test, int> F = SumDigit;
            Test t = new Test();
            IAsyncResult result = F.BeginInvoke(152646, t, AsyncCallback, t);
            Task.Run( () =>
            {
                while(t.Progress < 99)
                {
                    Console.WriteLine($"Сумма {t.Sum} прогресс {t.Progress}");
                    Thread.Sleep(5000);
                }
            });
            int answer = F.EndInvoke(result);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
        static int SumDigit(int value, Test t)
        {
            var sum = 0;
            var count = value.ToString().Length;
            while(value > 0)
            {
                sum += value % 10;
                value /= 10;
                Thread.Sleep(2000);
                t.Progress = 100f / count * (count - value.ToString().Length + 1);
                t.Sum = sum;
            }
            return sum;
        }
        static void AsyncCallback(IAsyncResult result)
        {
            Test t = result.AsyncState as Test;
            Console.WriteLine($"Async Сумма {t.Sum} progress {t.Progress}");
        }
    }
}
