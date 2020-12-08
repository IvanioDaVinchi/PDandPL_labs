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
        public int N
        {
            get
            {
                return n;
            }
            set
            {
                if(value > 9)
                {
                    throw new OverFlowProgression("u so bad boy!!");
                }
            }
        }

        public List<int> arithmeticList = new List<int>();
        public ArithmeticProgression(int d, int n)
        {
            this.d = d;
            try
            {
                N = --n;
            }
            catch (OverFlowProgression e)
            {
                Console.WriteLine(e.Message);
            }
            SetProgressionElement();
        }
        private void SetProgressionElement()
        {
            arithmeticList.Add(d);
            for(int i = 0; i < n; i++)
            {
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
            int element = 0;
            try
            {
                element = arithmeticList[--index];
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            return element;
        }
    }
}
