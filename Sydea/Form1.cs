using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sydea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int team1 = 0;
        private int team2 = 0;
        _from2 f2 = new _from2();
        private void button1_Click(object sender, EventArgs e)
        {
            f2.Show();
            f2.label1.Text = textBox1.Text;
            f2.label2.Text = textBox2.Text;
            f2.label3.Text = team1.ToString();
            f2.label4.Text = team2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            team1++;
            label4.Text = "Команда 1 - " + team1;
            f2.label3.Text = team1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            team1--;
            f2.label3.Text = team1.ToString();
            label4.Text = "Команда 1 - " + team1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            team2++;
            f2.label4.Text = team2.ToString();
            label5.Text = "Команда 2 - " + team2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            team2--;
            f2.label4.Text = team2.ToString();
            label5.Text = "Команда 2 - " + team2;
        }
    }
}
