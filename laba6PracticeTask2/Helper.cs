using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6PracticeTask2
{
    public static class Helper
    {
        public static double FindMin(double[] array)
        {
            double min = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
        public static double FindMax(double[] array)
        {
            double max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max > array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        public static double[] Sort(double[] array, bool order)
        {
            if (order == true)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    for(int j = i; j < array.Length; j++)
                    {
                        if(array[i] > array[j])
                        {
                            var temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                return array;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            var temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                return array;
            }
        }
        /*public static double[] Mul(double[,] matrix, double[] array)
        {
            double[] answer = new double[matrix.Length];
            for(int  i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < matrix[])
                {

                }
            }
            return answer;
        }*/
    }
}
