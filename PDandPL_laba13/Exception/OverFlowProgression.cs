using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDandPL
{
    public class OverFlowProgression : Exception
    {
        private string _message = "Going beyond the progression!(!! value > 10 !!)";
        public override string Message => _message;
        public OverFlowProgression(string message) : base(message)
        {
            _message = message;
        }
        public OverFlowProgression()
        { }

    }
}
