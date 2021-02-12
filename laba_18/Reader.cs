using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_18
{
    public class Reader
    {
        public string name;
        public string numberReaderTicket;
        public string nameBook;
        public string timeOfreturn;
        public override string ToString()
        {
            return $"name - {name}\nNumberReaderTicket - {numberReaderTicket}\nNameBook - {nameBook}\ntimeOfReturn - {timeOfreturn}";
        }
    }
}
