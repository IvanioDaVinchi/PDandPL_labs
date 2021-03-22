using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba22
{
    public partial class Form2 : Form
    {
        Form1 f = new Form1();
        public Form2(Form1 ff)
        {
            InitializeComponent();
            f = ff;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //while(true)
            //{
            //    int index = rnd.Next(1,20);
            //    BackColor = Color.FromName.;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "12345678")
            {
                f.check = true;
            }
            this.Close();
        }
    }
}
