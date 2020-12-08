using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace RegexLaba
{
    class Program
    {
        private static string ReadFile()
        {
            string text;
            using (StreamReader reader = new StreamReader("1.txt"))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }
        private static void Ftask()
        {
            Regex regex = new Regex(@"([A-F0-9]{2}-[A-F0-9]{2}-[A-F0-9]{2}-[A-F0-9]{2}-[A-F0-9]{2}-[A-F0-9]{2})", RegexOptions.IgnoreCase);
            MatchCollection match = regex.Matches(ReadFile());
            foreach(Match item in match)
                    Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            Ftask();
            RegexHtml regex = new RegexHtml($"{Directory.GetCurrentDirectory()}//html.txt");
            regex.Parse();
            Console.ReadKey();
        }
    }
}
