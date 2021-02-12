using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_18_2
{
    public class UserMenu
    {
        public UserMenu()
        {

        }
        public void DefaultMenu()
        {
            while(true)
            {
                Console.WriteLine("0) Вывод всего ассортимента");
                Console.WriteLine("1) Поставка");
                Console.WriteLine("2) Покупка");
                Console.WriteLine("3) Поиск");
                Console.WriteLine("4) Клон Заданной модели");
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
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }

    }
}
