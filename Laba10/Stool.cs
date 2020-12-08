using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
    public class Stool : Tabyretka
    {
        public int HeightSpinki { get; set; }
        public Stool(int height, int h2, string quality) : base(height, quality)
        {
            Height = height;
            HeightSpinki = h2;
            Quality = quality;
        }
        public override int CountDrevisini()
        {
            return base.CountDrevisini() + HeightSpinki + 5;
        }
        public override string Info()
        {
            return $"Stool: {base.Info()}\n 6) HeightSpinki: {HeightSpinki}";
        }
    }
}
