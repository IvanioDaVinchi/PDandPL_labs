using PDandPL.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDandPL
{
    class Program
    {
        delegate double[,] Dele();
        private static void Menu()
        {
            TablePainter obj = new TablePainter();
            Console.WriteLine("Выберите пункт меню:");
            Console.WriteLine(" 1 - Синус");
            Console.WriteLine(" 2 - Синус Квадрат Плюс Кос");
            Console.WriteLine(" 3 - 1/х");
            int sw = int.Parse(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    {
                        Dele dele = new Dele(obj.SinTable);
                        double[,] table = dele();
                        Console.WriteLine("Table sin");
                        Console.WriteLine("0\t30\t45\t90\t180\t270\t360");
                        for (int i = 1; i < table.GetLength(0); i++)
                        {
                            for (int j = 0; j < table.GetLength(1); j++)
                            {
                                Console.Write(Math.Round(table[i, j], 2) + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case 2:
                    {
                        Dele dele = new Dele(obj.SinAndCosTable);
                        double[,] table2 = dele();
                        Console.WriteLine("Table sinAndCos ");
                        Console.WriteLine("0\t30\t45\t90\t180\t270\t360");
                        for (int i = 1; i < table2.GetLength(0); i++)
                        {
                            for (int j = 0; j < table2.GetLength(1); j++)
                            {
                                Console.Write(Math.Round(table2[i, j], 2) + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case 3:
                    {
                        Dele dele = new Dele(obj.OneDelX);
                        double[,] table3 = dele();
                        Console.WriteLine("Table 1 / x ");
                        Console.WriteLine("0\t30\t45\t90\t180\t270\t360");
                        for (int i = 1; i < table3.GetLength(0); i++)
                        {
                            for (int j = 0; j < table3.GetLength(1); j++)
                            {
                                Console.Write(Math.Round(table3[i, j], 2) + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
            }

        }
        static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();
        }
    }
}
