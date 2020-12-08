using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexLaba
{
    public class RegexHtml
    {
        private string _path;

        public RegexHtml(string path)
        {
            _path = path;
        }

        private string ReadFile()
        {
            if (!File.Exists(_path)) throw new FileNotFoundException();
            string result;
            using (var stream = new StreamReader(_path))
                result = stream.ReadToEnd();
            return result;
        }

        public void Parse()
        {
            string text = ReadFile();
            text = ParsePreLine(text);
            var sizeParsedArray = ParseFontSize(text);
            text = string.Join("<Br>", sizeParsedArray);
            CreateHtmlDocument(text);
        }

        private string ParsePreLine(string text)
        {
            string pattern = "\\(P\\)";
            Regex reg = new Regex(pattern);
            while (reg.IsMatch(text))
            {
                text = reg.Replace(text, "<Pre>", 1);
                text = reg.Replace(text, "</Pre>", 1);
            }

            return text;
        }

        private string[] ParseFontSize(string text)
        {

            Regex pattern = new Regex("Fs([1-7])");
            string[] mas = text.Split('<');
            for (int i = 0; i < mas.Length; i++)
            {
                if (pattern.IsMatch(mas[i]))
                {
                    string size = "";
                    while (mas.Length != 0)
                    {
                        size = pattern.Match(mas[i]).Groups[1].Value;
                    }
                    string fontsize = $@"<Font size=""{size}""";
                    int indexOf = mas[i].IndexOf('>');
                    mas[i] = mas[i].Substring(3, indexOf - 2) + fontsize + mas[i].Substring(indexOf);
                }
            }

            return mas;
        }

        private void CreateHtmlDocument(string textInBody)
        {
            StringBuilder sb = new StringBuilder();
            string meta = @"<meta charset=""UTF-8"">";
            sb.Append("<html>").Append("<head>").Append(meta).Append("<title>").Append("</title>").Append("</head>").Append("<body>").Append(textInBody).Append("</body>").Append("</html>");
            using (StreamWriter writer = new StreamWriter($"{Directory.GetCurrentDirectory()}\\html.html"))
                writer.Write(sb.ToString());
            System.Diagnostics.Process.Start($"{Directory.GetCurrentDirectory()}\\html.html");
        }
    }
}