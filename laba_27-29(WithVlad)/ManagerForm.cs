using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_27_29_WithVlad_
{

    public partial class ManagerForm : Form
    {
        List<FlowersInShop> flowersInShop;
        List<Order> orders = new List<Order>();
        public ManagerForm()
        {
            InitializeComponent();
            using (var context = new FlowerContext())
            {
                context.FlowersInShop.Load();
                context.PreOrders.Load();
                context.Sells.Load();
                flowersInShop = context.FlowersInShop.ToList();
                dataGridView1.DataSource = context.FlowersInShop.Local.ToList();
                dataGridView2.DataSource = context.PreOrders.Local.ToList();
                dataGridView3.DataSource = context.Sells.Local.ToList();
            }
            comboBox1.Items.AddRange(flowersInShop.Select(x=>x.Flower).ToArray());
        }
        List<Sells> GetSellsList(List<Order> orders)
        {
            List<Sells> sells = new List<Sells>();
            for(int i = 0; i < orders.Count; i++)
            {
                sells.Add(new Sells(i+1, orders[i].flower, orders[i].count, DateTime.Now.Date.ToString(), 5));
            }
            return sells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox2.Text+ " " + comboBox1.Text + "\r\n";
            orders.Add(new Order(comboBox1.Text,int.Parse(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ успешен");
            textBox1.Clear();
            using (var context = new FlowerContext())
            {
                foreach (var order in orders)
                {
                    var fl = context.FlowersInShop.FirstOrDefault(x => x.Flower == order.flower);
                    fl.Count -= order.count;
                    context.SaveChanges();
                }

                context.FlowersInShop.Load();
                dataGridView1.DataSource = context.FlowersInShop.Local.ToList();
            }
            using (var context = new FlowerContext())
            {
                var listOrders = GetSellsList(orders);
                foreach (var item in listOrders)
                {
                    context.Sells.Add(item);
                }
                context.SaveChanges();
                context.Sells.Load();
                dataGridView3.DataSource = context.Sells.Local.ToList();
            }
            orders.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Пред заказ выполнен успешно");
            string preOrder = "";
            PreOrders asd= new PreOrders();
            using (var context = new FlowerContext())
            {
                foreach (var order in orders)
                {
                    preOrder += context.FlowersInShop.FirstOrDefault(x => x.Flower == order.flower).Id + ",";
                }
                preOrder = preOrder.Substring(0, preOrder.Length - 1);
                if (context.PreOrders.FirstOrDefault()!=null)
                {
                    asd = context.PreOrders.FirstOrDefault(x => x.id == context.PreOrders.Max(y => y.id));
                }
                context.PreOrders.Add(new PreOrders { FIO = textBox3.Text,id=asd.id+1,idFlower = preOrder });
                context.SaveChanges();
                context.PreOrders.Load();
                dataGridView2.DataSource = context.PreOrders.Local.ToList();
            }
            textBox3.Clear();
            textBox1.Clear();
            orders.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var context=new FlowerContext())
            {
                context.PreOrders.Load();
                dataGridView2.DataSource = context.PreOrders.Local.Where(x=>x.FIO==textBox4.Text).ToList();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var context = new FlowerContext())
            {
                context.FlowersInShop.Load();
                dataGridView1.DataSource = context.FlowersInShop.Where(x => x.Flower == textBox5.Text).ToList();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var context = new FlowerContext())
            {
                using (StreamWriter sw = new StreamWriter($"{Directory.GetCurrentDirectory()}\\1.txt"))
                {
                    context.Sells.Load();
                    var list = context.Sells.ToList();
                    foreach(var item in list)
                    {
                        sw.WriteLine($"Цветок - {item.FlowerName}");
                        sw.WriteLine($"Количество - {item.FlowerName}");
                    }
                    
                }
            }
        }
    }

    class Order
    {
        public string flower;
        public int count;

        public Order(string flower, int count)
        {
            this.flower = flower;
            this.count = count;
        }
    }
}
