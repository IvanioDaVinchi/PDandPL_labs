using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodgotovkaOKR
{
    public class FileHelper
    {
        public List<int> ReadFromFile(string path)
        {
            List<int> list = new List<int>(); 
            using (StreamReader reader = new StreamReader(path))
            {
                while(reader.EndOfStream)
                {
                    list.Add(reader.Read());
                }
            }
            return list;
        }
        public void WriteToFile(int digit,string path)
        {
            using (StreamWriter writer = new StreamWriter(path,true))
            {
                writer.Write(" " + digit);
            }
        }
    }
}
