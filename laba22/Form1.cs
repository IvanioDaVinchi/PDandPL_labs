using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba22
{
    public partial class Form1 : Form
    {
        public bool check = false;
        List<PriceList> list = new List<PriceList>();
        public Form1()
        {
            InitializeComponent();
        }

        double generalPrice = 0;
        double skidka = 0;
        double price = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(new PriceList(comboBox1.Text, Convert.ToInt32(textBox1.Text), 5.6));
            ShowFilms();
        }

        private void очиститьПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            list.Clear();
            generalPrice = 0;
            skidka = 0;
            price = 0;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
            {
                sw.Write(richTextBox1.Text);
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            if(check)
            {
                list.RemoveAt(list.Count - 1);
                ShowFilms();
            }
        }

        private void ShowFilms()
        {
            richTextBox1.Text = "";
            richTextBox1.Text = "Кинотеатр:Зльвинный Лев\n";
            foreach (var film in list)
            {
                richTextBox1.Text += $"фильм:{film.seans}\n" +
                $"кол-во билетов:{film.countTikets}\n";
                richTextBox1.Text += film.countTikets > 5 ? $"Стоимость сеанса:{(film.countTikets * film.price) - (film.countTikets * film.price * 0.02)};\n " : $"Стоимость сеанса:{film.countTikets * film.price };\n";
                generalPrice += film.countTikets > 5 ? (film.countTikets * film.price) -(film.countTikets * film.price * 0.02) : (film.countTikets * film.price);
                skidka += film.countTikets > 5 ? film.countTikets * film.price * 0.02: 0;
                price += film.countTikets * film.price;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += $"\n---------------------------\n" +
                $"Стоимость без скидки: {price} \n" +
                $"Скидка: {skidka} \n" +
                $"Общая стоимость: {generalPrice} \n" +
                "**** Приятного просмотра ****";
        }
    }
}
