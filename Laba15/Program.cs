using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba15
{
    class Program
    {
        static int[] ArrayAfterMullAllStringAndAvg(int[][] matrix)
        {
            int[] array = new int[matrix.GetLength(0)];
            int mull = 1, avg = 0, counter = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] % 2 == 0)
                    {
                        avg += matrix[i][j];
                        counter++;
                    }
                    mull *= matrix[i][j];
                }
                avg /= counter;
                array[i] = mull + avg;
                mull = 1;
            }
            return array;
        }
        static string GetMinThingString(string text)
        {
            int indexOfBiggestStrings = 0;
            string resultString = null;
            string[] strings = text.Split('.');
            char[] arrayOfSimbols = new char[] { ',', '-', ';', ':'};
            int[] arrayCounter = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                for(int j = 0; j < arrayOfSimbols.Length; j++)
                {
                    if (strings[i].Contains(arrayOfSimbols[j]))
                    {
                        arrayCounter[i]++;
                    }
                }
            }
            int min = arrayCounter[0];
            for(int i = 0; i < arrayCounter.Length; i++)
            {
                if(arrayCounter[i] < min)
                {
                    min = arrayCounter[i];
                    indexOfBiggestStrings = i;
                }
            }
            resultString = strings[indexOfBiggestStrings];
            return resultString;
        }
        static void Main(string[] args)
        {
            int[][] matrix = FileReader.ReadMatrix();
            int[] array = ArrayAfterMullAllStringAndAvg(matrix);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            FileReader.Write(array);
            string text = FileReader.ReadTextFromFileTxt();
            Console.WriteLine(GetMinThingString(text));
            Console.ReadLine();
        }
    }
}
