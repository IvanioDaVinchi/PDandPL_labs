using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba22
{
    class PriceList
    {
        public string seans;
        public int countTikets;
        public double price;

        public PriceList(string seans,int count,double price)
        {
            this.seans = seans;
            countTikets = count;
            this.price = price;
        }
    }
}
