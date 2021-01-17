using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_15._2
{
    class Program
    {
        static bool gameOver = false;
        static void GamePlay()
        {
            var game = new Game();
            game.Spawning += PrintMessege;
            game.Limit += PrintMessege;
            game.Limit += Died;
            game.Died += PrintMessege;
            game.Died += Died;
            game.NotEnoughGold += PrintMessege;
            while (gameOver == false)
            {
                Console.WriteLine($"Баланс золота: {game.GetCountGold()}");
                Console.WriteLine($"Кол-во крестьян: {game.GetCountPeasants()}");
                Console.WriteLine($"Лимит крестьян: {game.GetLimitPeasants()}");
                Console.WriteLine("1) увеличить налог                  **");
                Console.WriteLine("2) уменьшить налог                  **");
                Console.WriteLine("3) построить лочугу (10 золота)     **");
                Console.WriteLine("4) дать вольную                     **");
                Console.WriteLine("5) провести торжество (20 золота)   **");
                Console.WriteLine("6) сохраниться                      **");
                Console.WriteLine("7) Загрузить последнее сохранение   **");
                Console.WriteLine("8) выйти с игры                     **");
                int sw = int.Parse(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        {
                            game.IncreaseTax();
                            break;
                        }
                    case 2:
                        {
                            game.ReduceTax();
                            break;
                        }                       
                    case 3:
                        {
                            game.BuildShallow();
                            break;
                        }
                    case 4:
                        {
                            game.GiveFreeRein();
                            break;
                        }
                    case 5:
                        {
                            game.HoldCelebration();
                            break;
                        }
                    case 6:
                        {
                            SaveManager saving = new SaveManager();
                            saving.BinarySave(game);
                            break;
                        }
                    case 7:
                        {
                            SaveManager loadSaving = new SaveManager();
                            game = loadSaving.BinaryLoad();
                            break;
                        }
                    case 8:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
        static void PrintMessege(string mes)
        {
            Console.WriteLine(mes);
        }
        static void Died(string mes)
        {
            gameOver = true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, вы играте в игру феодал!Ваша задача накопить n крестьян\n" +
                "(если количество крестьян уменьшается меньше 0 игрок проигрывает) при наличии m золота\n" +
                "(если золота падает меньше 0 игрок проигрывает). Разработчик ИванШаплыкоГеймс.");
            GamePlay();
            Console.ReadLine();
        }
    }
}
