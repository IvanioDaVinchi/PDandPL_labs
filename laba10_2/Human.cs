using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10_2
{
    public abstract class Human
    {
        public string Name { get; set; }
        public int Age {get; set;}
        public int YearStudy { get; set; }
        protected Human(string name, int age, int yearStudy)
        {
            Name = name;
            Age = age;
            YearStudy = yearStudy;
        }
        public abstract bool Shoot();
    }
}
