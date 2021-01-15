using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Laba15
{
    public static class FileReader
    {
        public static int[][] ReadMatrix()
        {
            StreamReader s = File.OpenText("input1.txt");
            string read = null;
            int n = int.Parse(s.ReadLine());
            int[][] matrix = new int[n][];
            for(int i = 0; i < n; i++)
            {
                read = s.ReadLine();
                string[] stringArray = new string[read.Length];
                stringArray = read.Split();
                int[] arrayForMatrix = new int[stringArray.Length];
                for (int j = 0; j < stringArray.Length; j++)
                {
                    arrayForMatrix[j] = int.Parse(stringArray[j]);
                }
                matrix[i] = arrayForMatrix;
            }
            s.Close();
            return matrix;    
        }
        public static void Write(int[] array)
        {
            FileInfo f = new FileInfo("output1.txt");
            StreamWriter w = f.CreateText();
            for(int i = 0; i < array.Length; i++)
            {
                w.WriteLine(array[i]);
            }
            w.Close();
        }
        public static string ReadTextFromFileTxt()
        {
            string text = null;
            StreamReader s = File.OpenText("input2.txt");
            text = s.ReadToEnd();
            s.Close();
            return text;
        }
    }
}
