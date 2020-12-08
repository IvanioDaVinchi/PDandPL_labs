using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShootPeopleOnPistol onPistol = new ShootPeopleOnPistol();
            onPistol.EnterPeople();
            onPistol.Shooting();
            Console.ReadLine();
        }
    }
}
