using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Laba_16._2
{
    public class MySet<T>
    {
        public int n = 0;
        public HashSet<T> hashSet = new HashSet<T>();
        public MySet()
        {
            n = LoadCountFromFile();
            
        }
        private int LoadCountFromFile()
        {
            int count = 0;
            using (FileStream fs = new FileStream($"{Directory.GetCurrentDirectory()}\\1.txt", FileMode.OpenOrCreate))
            {
                StreamReader reader = new StreamReader(fs);
                count = int.Parse(reader.ReadToEnd());
            }
            return count;
        }
        public void AddNewElementInSet( T value )
        {
            hashSet.Add(value);
        }
        public static HashSet<T> operator + (MySet<T> set1 ,MySet<T> set2)
        {
            set1.hashSet.UnionWith(set2.hashSet);
            return set1.hashSet;
        }
        public static MySet<T> operator ++(MySet<T> set1)
        {
            Random rnd = new Random();
            var newSet = (dynamic)set1;
            newSet.hashSet.Add(rnd.Next(1,20));
            set1 = (dynamic)newSet;
            return set1;
        }
    }
}
