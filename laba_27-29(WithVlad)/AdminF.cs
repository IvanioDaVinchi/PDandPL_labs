using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace laba_27_29_WithVlad_
{
    public partial class AdminF : Form
    {
        public AdminF()
        {
            InitializeComponent();
        }

        private void AdminF_Load(object sender, EventArgs e)
        {
            using (var context= new FlowerContext())
            {
                context.Flowers.Load();
                context.FlowersInShop.Load();
                dataGridView1.DataSource = context.Flowers.Local.ToList();
                dataGridView2.DataSource = context.FlowersInShop.Local.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new FlowerContext())
            {
                var asd= context.FlowersInShop.Find(int.Parse(textBox1.Text));
                asd.Price = int.Parse(textBox2.Text);
                context.SaveChanges();
                context.FlowersInShop.Load();
                dataGridView2.DataSource = context.FlowersInShop.Local.ToList();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var flower = new Flowers();
            flower.Id = int.Parse(textBox3.Text);
            flower.FlowerName = textBox4.Text;
            flower.Photo = textBox5.Text;
            flower.DateReleas = textBox6.Text;
            using (var context = new FlowerContext())
            {
                context.Flowers.Add(flower);
                context.SaveChanges();
                context.Flowers.Load();
                dataGridView1.DataSource = context.Flowers.Local.ToList();
            }
        }
    }
}
