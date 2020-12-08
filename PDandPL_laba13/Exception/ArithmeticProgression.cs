using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDandPL
{
    public class ArithmeticProgression
    {
        int d = 0;
        int n = 0;
        public List<int> arithmeticList = new List<int>();
        public ArithmeticProgression(int d, int n)
        {
            this.d = d;
            this.n = --n;
            SetProgressionElement();
        }
        private void SetProgressionElement()
        {
            arithmeticList.Add(d);
            for(int i = 0; i < n; i++)
            {
                if(i >= 9)
                {
                    throw new OverFlowProgression("Как не культурно!!");
                }
                arithmeticList.Add(arithmeticList[i] + d);
            }
        }
        public void PrintArithmeticProgression()
        {
            foreach(var item in arithmeticList)
            {
                Console.WriteLine(item);
            }
        }
        public int SumElementsProgression()
        {
            int sum = 0;
            sum = arithmeticList.Sum();
            return sum;
        }
        public int GetNElement(int index)
        {
            if (index > arithmeticList.Count())
            {
                throw new OverFlowProgression();
            }
            int element = arithmeticList[--index];
            return element;
        }
    }
}
