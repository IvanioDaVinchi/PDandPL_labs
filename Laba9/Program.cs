using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    class Program
    {
        private static void Menu()
        {
            List<Human> list = new List<Human>();
            while (true)
            {
                Console.WriteLine("1) Ввод массива");
                Console.WriteLine("2) Изменение заданной структуры");
                Console.WriteLine("3) Удаление структуры");
                Console.WriteLine("4) Вывод");
                Console.WriteLine("5) Вывести количество людей с одинаковым именем для каждого имени");
                Console.WriteLine("6) Посчитать общий возраст людей, зарегистрированных у одного оператора");
                Console.WriteLine("7) Выход");
                int sw = int.Parse(Console.ReadLine());
                switch(sw)
                {
                    case 1:
                        {
                            EnterStruct(list);
                            break;
                        }
                    case 2:
                        {
                            ChengeStruct(list);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Name:");
                            string name = Console.ReadLine();
                            Delete(list, name);
                            break;
                        }
                    case 4:
                        {
                            Print(list);
                            break;
                        }
                    case 5:
                        {
                            CountName(list);
                            break;
                        }
                    case 6:
                        {
                            CountOnOneOperator(list);
                            break;
                        }
                    case 7:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                }
            }
        }
        private static void CountOnOneOperator(List<Human> list)
        {
            int temp = 0;
            var listOfOperators = list.Select(x => x.oper).Distinct();
            List<Human> listOfPeople = new List<Human>();
            foreach (var item in listOfOperators)
            {
                listOfPeople = list.FindAll(x => x.oper == item);
                for(int i = 0; i < listOfPeople.Count; i++)
                {
                    temp += listOfPeople[i].age; 
                }
                    Console.WriteLine($"{item} : { temp / list.Count(x => x.oper == item)}");
                temp = 0;
            }
        }
        private static void Print(List<Human> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine($"Фамилия  - {item.Fname}");
                Console.WriteLine($"Имя      - {item.Name}");
                Console.WriteLine($"Отчество - {item.FatherName}");
                Console.WriteLine($"Адрес    - {item.HomeStreet}");
                Console.WriteLine($"Телефон  - {item.PhoneNumber}");
                Console.WriteLine($"Оператор - {item.oper}");
                Console.WriteLine($"Возраст  - {item.age}");
                Console.WriteLine("////////////////////////////////");
            }
        }
        private static void ChengeStruct(List<Human> list)
        {
            Console.WriteLine("Введите Fname человека информацию, о котором, вы хотите поменять:");
            string name = Console.ReadLine();
            Human chengesHuman = list.SingleOrDefault(x => x.Fname == name);
            if(chengesHuman.Name == null)
            {
                Console.WriteLine("Такого нету!");
            }
            else
            {
                list.Remove(list.SingleOrDefault(x => x.Name == name));
                Console.WriteLine("Введите - фамилию - имя - отчество - домашний адрес - номер телефона - оператора - возраст:");
                list.Add(new Human() { Fname = Console.ReadLine(), Name = Console.ReadLine(), FatherName = Console.ReadLine(), HomeStreet = Console.ReadLine(), PhoneNumber = Console.ReadLine(), oper = EnterEnum(), age = int.Parse(Console.ReadLine()) });
            }
        }
        private static void CountName(List<Human> list)
        {
            var listOfName = list.Select(x => x.Name).Distinct();
            foreach(var item in listOfName)
                Console.WriteLine($"{item} : {list.Count(x => x.Name == item)}");
        }
        private static void Delete(List<Human> list, string name)
        {
            list.Remove(list.Find(x => x.Name == name));
        }
        private static Operator EnterEnum()
        {
            Operator op = Operator.A1;
            Console.WriteLine("Enter number:");
            Console.WriteLine("1) Mts");
            Console.WriteLine("2) Life");
            Console.WriteLine("3) A1");
            Console.WriteLine("4) Bilain");
            int sw = int.Parse(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    {
                        op = Operator.Mts;
                        break;
                    }
                case 2:
                    {
                        op = Operator.Life;
                        break;
                    }
                case 3:
                    {
                        op = Operator.A1;
                        break;
                    }
                case 4:
                    {
                        op = Operator.Bilain;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
            }
            return op;
        }
        private static int EnterCount()
        {
            int count = 0;
            bool check = true;
            while(check)
            {
                Console.WriteLine("Введите количество человек:");
                if (int.TryParse(Console.ReadLine(), out count))
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("Enter again!");
                }
            }
            return count;
        }
        private static void EnterStruct(List<Human> list)
        {
            int count = EnterCount();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите - фамилию - имя - отчество - домашний адрес - номер телефона - оператора - возраст:");
                list.Add(new Human() { Fname = Console.ReadLine(), Name = Console.ReadLine(), FatherName = Console.ReadLine(), HomeStreet = Console.ReadLine(), PhoneNumber = Console.ReadLine(), oper = EnterEnum(), age = int.Parse(Console.ReadLine()) });
            }
        }
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
    }
}
