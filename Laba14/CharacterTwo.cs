using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14
{
    public class CharacterTwo
    {
        Random rnd = new Random();
        public int countLife = 150;
        int[] damage = new int[2] { 5,15};
        public delegate void SpecialHit(string Message);
        public event SpecialHit Oglyshenie;
        public bool OglyshenieHit()
        {
            Random rnd = new Random();
            int check = rnd.Next(0, 100);
            if (check < 6)
            {
                Oglyshenie?.Invoke("Оглушение");
                return true;
            }

            else
                return false;
        }

        public int Hit()
        {
            int damageHit = rnd.Next(damage[0], damage[1]);
            return damageHit;
        }
        public bool Dead()
        {
            if (countLife == 0 || countLife < 0)
                return true;
            else
                return false;
        }
    }
}
