using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10_2
{
    public class ShootPeopleOnPistol
    {
        Human[] array = new Human[4];
        public Human OnePeople()
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стаж:");
            int stage = int.Parse(Console.ReadLine());
            if(stage <= 2)
            {
                Noob noob = new Noob(name,age,stage);
                return noob;
            }
            if(stage > 2 && stage < 5)
            {
                Mature mature = new Mature(name,age,stage);
                return mature;
            }
            if(stage >= 5)
            {
                Veteran veteran = new Veteran(name, age, stage);
                return veteran;
            }
            throw new StackOverflowException("FATAL ERROR !! Ti suda kak popal malchik!! FATAL ERROR !!");
        }
        public void EnterPeople()
        {         
            for(int i = 0; i < 4; i++)
            {
                array[i] = OnePeople();            
            }
        }
        public void Shooting()
        {
            for(int i = 0; i  < array.Length; i++)
            {
                Console.WriteLine($"{array[i].Name}\n {array[i].Age}\n {array[i].YearStudy}");
                if (array[i].Shoot())
                {
                    Console.WriteLine("Попал!");
                    break;
                }
                else
                    Console.WriteLine("Не попал!");
            }
        }
    }
}
