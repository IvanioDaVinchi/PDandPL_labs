using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaStudents
{
    public class Runner
    {
        public void WriteSdudents()
        {
            Console.WriteLine("Введите кол-во студентов");
            Students[]
        }
        public void Start()
        {
            while(true)
            {
                Console.WriteLine("** 1) Вывести всех студентов. ");
                Console.WriteLine("** 2) Вывести студента по фамилии.");
                Console.WriteLine("** 3) Вывести всех студентов из одной группы. ");
                Console.WriteLine("** 4) Вывести всех студентов у которых срю балл больше, чем вы введете.");
                Console.WriteLine("** 5) Вывести всех студентов у которых три и больше не зачетов.");
                Console.WriteLine("** 6) Выход из программы");
                int sw = int.Parse(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        {

                            break;
                        }
                    case 2:
                        {

                            break;
                        }
                    case 3:
                        {

                            break;
                        }
                    case 4:
                        {

                            break;
                        }
                    case 5:
                        {

                            break;
                        }
                    case 6:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;
                }

            }
        }
    }
}
