using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Floppa()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            checkBox10.Visible = false;
            checkBox11.Visible = false;
            checkBox12.Visible = false;
            checkBox13.Visible = false;
            checkBox14.Visible = false;
        }
        private int RandomChance()
        {
            Random rnd = new Random();
            return rnd.Next(0, 100);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
            }
            else
            checkBox2.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox2.Visible = false;
            }
            else
            checkBox3.Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox3.Visible = false;
            }
            else
            checkBox4.Visible = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox4.Visible = false;
            }
            else
            checkBox5.Visible = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox5.Visible = false;
            }
            else
            checkBox6.Visible = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox6.Visible = false;
            }
            else
            checkBox7.Visible = true;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox7.Visible = false;
            }
            else
            checkBox8.Visible = true;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox8.Visible = false;
            }
            else
            checkBox9.Visible = true;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox9.Visible = false;
            }
            else
            checkBox10.Visible = true;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox10.Visible = false;
            }
            else
            checkBox11.Visible = true;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox11.Visible = false;
            }
            else
            checkBox12.Visible = true;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox12.Visible = false;
            }
            else
            checkBox13.Visible = true;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox13.Visible = false;
            }
            else
            checkBox14.Visible = true;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            int pipy = RandomChance();
            if (pipy == 15 || pipy == 25 || pipy == 78 || pipy == 5 || pipy == 11 || pipy == 22 || pipy == 87 || pipy == 93)
            {
                Floppa();
                checkBox14.Visible = false;
            }
            else
            MessageBox.Show("Совершенный успех!! поздравляю", "yeeeeee", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Yellow;
                button4.BackColor = Color.Yellow;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                button1.BackColor = Color.Yellow;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                button2.BackColor = Color.Yellow;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                button3.BackColor = Color.Yellow;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                button4.BackColor = Color.Yellow;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
                button3.BackColor = Color.Blue;
                button4.BackColor = Color.Blue;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                button1.BackColor = Color.Blue;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                button2.BackColor = Color.Blue;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                button3.BackColor = Color.Blue;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                button4.BackColor = Color.Blue;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                button1.BackColor = Color.Red;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                button2.BackColor = Color.Red;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                button3.BackColor = Color.Red;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                button4.BackColor = Color.Red;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Green;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                button1.BackColor = Color.Green;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                button2.BackColor = Color.Green;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                button3.BackColor = Color.Green;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                button4.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.BackColor == Color.Yellow)
            {
                MessageBox.Show("fhdn" ,"fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (button1.BackColor == Color.Blue)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (button1.BackColor == Color.Red)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (button1.BackColor == Color.Green)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Yellow)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (button2.BackColor == Color.Blue)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (button2.BackColor == Color.Red)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (button2.BackColor == Color.Green)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Yellow)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (button3.BackColor == Color.Blue)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (button3.BackColor == Color.Red)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (button3.BackColor == Color.Green)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Yellow)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (button4.BackColor == Color.Blue)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (button4.BackColor == Color.Red)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (button4.BackColor == Color.Green)
            {
                MessageBox.Show("fhdn", "fbhtghr", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Floppa();
            BackColor = Color.Gray;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
        }
    }
}
