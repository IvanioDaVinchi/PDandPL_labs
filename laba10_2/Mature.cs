﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10_2
{
    public class Mature : Human
    {
        public Mature(string name, int age, int yearStudy) : base(name, age, yearStudy)
        {
        }

        public override bool Shoot()
        {
            Random rnd = new Random();
            double p = 0.05 * YearStudy;
            if (rnd.NextDouble() <= p)
            {
                return true;
            }
            return false;
        }
    }
}
