using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_15._2
{
    public class Game
    {
        public int CountPeasants
        {
            get
            {
                return CountPeasants;
            }
            set
            {
                CountPeasants = value;
            }
        }
        public int CountGold
        {
            get
            {
                return CountGold;
            }
            set
            {
                CountGold = value;
            }
        }
        public double ProccentSpawnPeasants
        {
            get
            {
                return ProccentSpawnPeasants;
            }
            set
            {
                ProccentSpawnPeasants = value;
            }
        }
        public int LimitPeasants
        {
            get
            {
                return LimitPeasants;
            }
            set
            {
                LimitPeasants = value;
            }
        }
        public void RiseGold(int delta)
        {
            CountGold += delta;
        }
        public void DeclineGold(int delta)
        {
            CountGold -= delta;
        }
        public void RisePeasants(int delta)
        {
            CountPeasants += delta;
        }
        public void DeclinePeasants(int delta)
        {
            CountPeasants -= delta;
        }
        public void RiseTax(int delta)
        {
            CountGold += 1;
            ProccentSpawnPeasants -= 0.2;
        }
        public void DeclineTax(int delta)
        {
            CountGold -= delta;
            ProccentSpawnPeasants += 0.2;
        }
        public void BuildShallow()
        {
            CountGold -= 10;
            LimitPeasants += 4;
        }
        public void GiveFreeRein()
        {
            CountPeasants -= 1;
            ProccentSpawnPeasants += 5;
        }
        public void HoldCelebration()
        {
            CountPeasants += 1;
            ProccentSpawnPeasants += 1;
        }

    }
}
