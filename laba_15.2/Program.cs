using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_15._2
{
    class Program
    {
        static void Start()
        {
            while(true)
            {
                Console.WriteLine("1) увеличить налог                  **");
                Console.WriteLine("2) уменьшить налог                  **");
                Console.WriteLine("3) построить лочугу (10 золота)     **");
                Console.WriteLine("4) дать вольную                     **");
                Console.WriteLine("5) провести торжество (20 золота)   **");
                Console.WriteLine("6) сохраниться                      **");
                Console.WriteLine("7) Загрузить последнее сохранение   **");
                Console.WriteLine("8) выйти с игры                     **");
                int sw = int.Parse(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, вы играте в игру феодал!Ваша задача накопить n крестьян\n" +
                "(если количество крестьян уменьшается меньше 0 игрок проигрывает) при наличии m золота\n" +
                "(если золота падает меньше 0 игрок проигрывает). Разработчик ИванШаплыкоГеймс.");
            Start();
            Console.ReadLine();
        }
    }
}
