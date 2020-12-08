using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7Stroki
{
    public static class Poet
    {
        static char[] vowels = new char[] { 'а', 'и', 'е', 'ё', 'о', 'у', 'ы', 'э', 'ю', 'я' };
        public static string text = "У лукоморья дуб зелёный;\n" +
                            "Златая цепь на дубе том:\n" +
                            "И днём и ночью кот учёный\n" +
                            "Всё ходит по цепи кругом;\n" +
                            "Идёт направо — песнь заводит,\n" +
                            "Налево — сказку говорит.\n" +
                            "Там чудеса: там леший бродит,\n" +
                            "Русалка на ветвях сидит;\n" +
                            "Там на неведомых дорожках\n" +
                            "Следы невиданных зверей;\n" +
                            "Избушка там на курьих ножках\n" +
                            "Стоит без окон, без дверей;\n" +
                            "Там лес и дол видений полны;\n" +
                            "Там о заре прихлынут волны\n" +
                            "На брег песчаный и пустой,\n" +
                            "И тридцать витязей прекрасных\n" +
                            "Чредой из вод выходят ясных,\n" +
                            "И с ними дядька их морской;\n" +
                            "Там королевич мимоходом\n" +
                            "Пленяет грозного царя;\n" +
                            "Там в облаках перед народом\n" +
                            "Через леса, через моря\n" +
                            "Колдун несёт богатыря;\n" +
                            "В темнице там царевна тужит,\n" +
                            "А бурый волк ей верно служит;\n" +
                            "Там ступа с Бабою Ягой\n" +
                            "Идёт, бредёт сама собой,\n" +
                            "Там царь Кащей над златом чахнет;\n" +
                            "Там русский дух… там Русью пахнет!\n" +
                            "И там я был, и мёд я пил;\n" +
                            "У моря видел дуб зелёный;\n" +
                            "Под ним сидел, и кот учёный\n" +
                            "Свои мне сказки говорил.";

        static char[] forSplit = new char[] { ' ', ',', '.', ';', ':', '\n', '—', '!' };
        public static string[] oneWord = text.Split(forSplit);

        public static string[] Swap()
        {
            for(int i = 0; i < oneWord.Length; i++)
            {
                if(oneWord[i].Length < 7 && oneWord[i].Length > 4)
                {
                    oneWord[i] = oneWord[i].Remove(3);
                    oneWord[i] = oneWord[i].Insert(3, "#");
                }
                else
                {
                    if(oneWord[i].Length > 6)
                    {
                        oneWord[i] = oneWord[i].Remove(3,1);
                        oneWord[i] = oneWord[i].Remove(5,1);
                        oneWord[i] = oneWord[i].Insert(3,"#");
                        oneWord[i] = oneWord[i].Insert(6,"#");
                    }
                }
            }
            return oneWord;
        }
        public static void FindRepeatWordCount()
        {
            int count = 0;
            for(int i = 0; i < oneWord.Length; i++)
            {
                for(int j = 0; j < oneWord.Length; j++)
                {
                    if(oneWord[i] == oneWord[j] && oneWord[i] != "")
                    {
                        count++;
                    }
                }
                if(oneWord[i] != "")
                {
                    Console.WriteLine($"word - {oneWord[i]} repeat - {count}");
                }
                count = 0;
            }
        }
        public static void Three()
        {
            for(int i = 0; i < oneWord.Length; i++)
            {
                for(int j = 0; j < vowels.Length; j++)
                {
                    if(oneWord[i] != "" && oneWord[i].First() != vowels[j] && oneWord[i].Last() == vowels[j])
                    {
                        Console.WriteLine(oneWord[i]);
                    }
                }
            }
        }
    }
}
