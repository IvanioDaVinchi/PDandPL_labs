using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14
{
    public class Fight
    {
        public void FirstCharecterHit(CharacterOne one, CharacterTwo two)
        {
            two.countLife -= one.Hit();
        }
        public void SecondCharecterAttack(CharacterOne one, CharacterTwo two)
        {
            one.countLife -= two.Hit();
        }
        public void FightWnenCharacterOneStartedFirst()
        {
            Console.WriteLine(" !! Бой начинает первый персонаж !! ");
            CharacterOne one = new CharacterOne();
            CharacterTwo two = new CharacterTwo();
            one.Freeze += Displayed;
            two.Oglyshenie += Displayed;
            int index = 0;
            while (true)
            {
                index++;
                if(index % 2 != 0)
                {
                    FirstCharecterHit(one, two);
                    if(two.Dead())
                    {
                        Console.WriteLine("Второй персонаж умер! Первый победил!!");
                        break;
                    }
                    if(one.FreezeHit())
                    {
                        index++;
                    }
                }
                else
                {
                    SecondCharecterAttack(one,two);
                    if (one.Dead())
                    {
                        Console.WriteLine("Первый персонаж умер! Второй победил!!");
                        break;
                    }
                    if (two.OglyshenieHit())
                    {
                        index++;
                    }
                }
                //Console.WriteLine(one.countLife);
                //Console.WriteLine(two.countLife);
            }
        }
        public void FightWnenCharacterTwoStartedFirst()
        {
            Console.WriteLine(" !! Бой начинает второй персонаж !! ");
            CharacterOne one = new CharacterOne();
            CharacterTwo two = new CharacterTwo();
            one.Freeze += Displayed;
            two.Oglyshenie += Displayed;
            int index = 0;
            while (true)
            {
                index++;
                if (index % 2 == 0)
                {
                    FirstCharecterHit(one, two);
                    if (two.Dead())
                    {
                        Console.WriteLine("Второй персонаж умер! Первый победил!!");
                        break;
                    }
                    if (one.FreezeHit())
                    {
                        index++;
                    }
                }
                else
                {
                    SecondCharecterAttack(one, two);
                    if (one.Dead())
                    {
                        Console.WriteLine("Первый персонаж умер! Второй победил!!");
                        break;
                    }
                    if (two.OglyshenieHit())
                    {
                        index++;
                    }
                }
            }
        }
        public void FirstFight()
        {
            for (int i = 0; i < 50; i++)
            {
                FightWnenCharacterOneStartedFirst();
            }
        }
        public void SecondFight()
        {
            for (int i = 0; i < 50; i++)
            {
                FightWnenCharacterTwoStartedFirst();
            }
        }
        public void Displayed(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
