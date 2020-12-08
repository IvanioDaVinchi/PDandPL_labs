using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_11
{
    public class SortGlasnii : IComparer<char>
    {
        char[] vovels = { 'a', 'e', 'i', 'o', 'u', 'y' };
        char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z' };
        public int Compare(char a, char b)
        {
            if (consonants.Contains(a) == true &&
               vovels.Contains(b) == true)
                return 1;
            if (vovels.Contains(a) == true &&
              consonants.Contains(b) == true)
                return -1;
            return a.CompareTo(b);
        }
    }
}
