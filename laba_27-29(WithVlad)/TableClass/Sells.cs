using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_27_29_WithVlad_
{
    public class Sells
    {
        public int id { get; set; }
        public string FlowerName { get; set; }
        public int Count { get; set; }
        public string DateSell { get; set; }
        public int Discount { get; set; }
        public Sells(int _id, string flowers, int count, string date, int discount)
        {
            id = _id;
            FlowerName = flowers;
            Count = count;
            DateSell = date;
            Discount = discount;
        }
        public Sells()
        { }
    }
}
