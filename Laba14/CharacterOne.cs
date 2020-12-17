using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14
{
    public class CharacterOne
    {
        Random rnd = new Random();
        public int countLife = 110;
        int[] damage = new int[2] { 12, 14 };
        public delegate void SpecialHit(string Messege);
        public event SpecialHit Freeze;
        public bool FreezeHit()
        {
            Random rnd = new Random();
            int check = rnd.Next(0, 100);
            if (check < 11)
            {
                Freeze?.Invoke("Застынь");
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
