using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
    public class EnterData
    {
        int height = 0;
        string quality = "";
        int heightSpinki = 0;
        public void EnterHeight()
        {
            Console.WriteLine("Введите высоту изделия:");
            height = int.Parse(Console.ReadLine());
        }
        public void EnterQuality()
        {
            Console.WriteLine("Введите качество изделия(Вводим только низкое, среднее, высокое!!!!!!! еще раз повторяю: низкое, среднее, высокое):");
            quality = Console.ReadLine();
            Check(quality);
        }
        public void Check(string quality)
        {
            if (quality != "низкое" && quality != "среднее" && quality != "высокое")
            {
                Console.WriteLine("Ну вот скажи ЧТО НЕ ЯСНО БЫЛО НАПИСАНО?? ТОЛЬКО!!!! - НИЗКОЕ, СРЕДНЕЕ И ВЫСОКОЕ КАЧЕСТВО!!!!!!");
                EnterQuality();
            }
        }
        public Tabyretka GetTabyr()
        {
            EnterHeight();
            EnterQuality();
            Tabyretka tabyretka = new Tabyretka(height, quality);
            return tabyretka;
        }
        public void EnterHeightSpinki()
        {
            Console.WriteLine("Введите высоту спинки стула:");
            heightSpinki = int.Parse(Console.ReadLine());
        }
        public Stool GetStool()
        {
            EnterHeight();
            EnterHeightSpinki();
            EnterQuality();
            Stool stool = new Stool(height, heightSpinki, quality);
            return stool;
        }
    }
}
