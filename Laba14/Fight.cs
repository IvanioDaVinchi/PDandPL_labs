using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14
{
    public class Fight
    {
        public int winPlayerOne = 0;
        public int winPlayerTwo = 0;
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
                //index++;  
                if(++index % 2 != 0)
                {
                    FirstCharecterHit(one, two);
                    if(two.Dead())
                    {
                        Console.WriteLine("Второй персонаж умер! Первый победил!!");
                        winPlayerOne++;
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
                        winPlayerTwo++;
                        break;
                    }
                    if (two.OglyshenieHit())
                    {
                        index++;
                    }
                }
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
                        winPlayerOne++;
                        break;
                    }
                    if (one.FreezeHit())
                    {
                        index++;
                        FirstCharecterHit(one, two);
                    }
                }
                else
                {
                    SecondCharecterAttack(one, two);
                    if (one.Dead())
                    {
                        Console.WriteLine("Первый персонаж умер! Второй победил!!");
                        winPlayerTwo++;
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
            Console.WriteLine("Первый выйграл - " + winPlayerOne);
            Console.WriteLine("Второй выйграл - " + winPlayerTwo);
            winPlayerOne = 0;
            winPlayerTwo = 0;
        }
        public void SecondFight()
        {
            for (int i = 0; i < 50; i++)
            {
                FightWnenCharacterTwoStartedFirst();
            }
            Console.WriteLine("Первый выйграл - " + winPlayerOne);
            Console.WriteLine("Второй выйграл - " + winPlayerTwo);
            winPlayerOne = 0;
            winPlayerTwo = 0;
        }
        public void Displayed(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
