using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_11
{
    public class Circle : IComparable<Circle>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
        public Circle(int x, int y, int r)
        {
            X = x;
            Y = y;
            R = r;
        }
        public double Square()
        {
            return 3.14 * Math.Sqrt(R);
        }
        public override string ToString()
        {
            return $"({X},{Y} - {R} - {Square():0.###})";
        }
        public int CompareTo(Circle other)
        {
            return Square().CompareTo(other.Square());
        }
    }
}
