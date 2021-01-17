using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_15._2
{
    [Serializable]
    public class Game
    {
        private int countGold = 10;
        private int countPeasants = 20;
        private double proccentSpawnPeasants = 5;
        private int limitPeasants = 100;
        public delegate void EventPrint(string Messege);
        public event EventPrint Spawning;
        public event EventPrint Died;
        public event EventPrint Limit;
        public event EventPrint NotEnoughGold;

        public void IncreaseTax()
        {
            countGold += 1;
            proccentSpawnPeasants -= 0.2;
            if(CheckOnDied())
            SpawnPeasants();
        }
        public void ReduceTax()
        {
            countGold -= 1;
            proccentSpawnPeasants += 0.2;
            if (CheckOnDied())
                SpawnPeasants();
        }
        public void BuildShallow()
        {
            countGold -= 10;
            limitPeasants += 4;
            if (CheckOnDied())
                SpawnPeasants();
        }
        public void GiveFreeRein()
        {
            countPeasants -= 1;
            proccentSpawnPeasants += 5;
            if (CheckOnDied())
                SpawnPeasants();
        }
        public void HoldCelebration()
        {
            if (countGold > 20)
            {
                countGold -= 20;
                countPeasants += 1;
                proccentSpawnPeasants += 1;
                if (CheckOnDied())
                    SpawnPeasants();
            }
            else
                NotEnoughGold?.Invoke("!! У вас не достаточно золота !!");
            
        }
        private void SpawnPeasants()
        {
            countPeasants += Convert.ToInt32(countPeasants * proccentSpawnPeasants / 100);
            Spawning?.Invoke("!! У вас прибавление крестьян !!");
        }
        private bool CheckOnDied()
        {
            if (countGold <= 0 || countPeasants <= 0)
            {
                Died?.Invoke("Вы проиграли!");
                return false;
            }
            else
                return true;
                
        }
        public int GetCountGold() => countGold;
        public int GetCountPeasants() => countPeasants;
        public int GetLimitPeasants() => limitPeasants;
    }
}