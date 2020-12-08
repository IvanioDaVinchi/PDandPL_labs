using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
    public class Tabyretka
    {
        public int Height { get; set; }
        public string Quality { get; set; }
        public Tabyretka(int height, string quality)
        {
            Height = height;
            Quality = quality;
        }
        public virtual int CountDrevisini()
        {
            if(Quality == "низкое")
            {
                return 4 * Height + 12;
            }
            if (Quality == "среднее" || Quality == "высокое")
            {
                return 5 * Height + 14;
            }
            throw new ArgumentOutOfRangeException("Izverg yudi ot suda!!");
        }
        public virtual int Cost()
        {
            if (Quality == "низкое")
            {
                return CountDrevisini()*2;
            }
            if (Quality == "среднее")
            {
                return CountDrevisini()*3;
            }
            if(Quality == "высокое")
            {
                return CountDrevisini()*4;
            }
            throw new ArgumentOutOfRangeException("Izverg yudi ot suda!!");
        }
        public virtual string Info()
        {
           return $"1) Height: {Height}\n 2) Quality: {Quality}\n 3) CountDrevisini: {CountDrevisini()}\n 4) Cost: {Cost()}";
        }
    }
}
