using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_Paint
{
    public partial class Form1 : Form
    {
        string state = "";
        Point point = new Point(-1,-1);
        Bitmap mainBit = new Bitmap(1920,1080);
        Bitmap tempBit;
        private Font fnt = new Font("Arial", 10);
        Brush brush = new SolidBrush(Color.Black);

        public Form1()
        {
            InitializeComponent();
            mainBit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            tempBit = new Bitmap(mainBit);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = mainBit;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color_Button.BackColor = colorDialog1.Color;
            brush = new SolidBrush(colorDialog1.Color);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            state = "line";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point.X = e.X;
            point.Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (state == "line1")
                {
                    tempBit = mainBit;
                    Graphics graphics = Graphics.FromImage(tempBit);
                    graphics.DrawLine(new Pen(colorDialog1.Color), point, e.Location);
                    point = e.Location;
                    pictureBox1.Image = mainBit;
                }
                else if (state == "line")
                {
                    tempBit = mainBit.Clone() as Bitmap;
                    Graphics graphics = Graphics.FromImage(tempBit);
                    graphics.DrawLine(new Pen(colorDialog1.Color), point, e.Location);
                    pictureBox1.Image = tempBit;
                }
                else if (state == "ellipse")
                {
                    tempBit = new Bitmap(mainBit);
                    Graphics graphics = Graphics.FromImage(tempBit);
                    graphics.DrawEllipse(new Pen(colorDialog1.Color), point.X, point.Y, e.X - point.X, e.Y - point.Y);
                    pictureBox1.Image = tempBit;
                }
                else if (state == "Fellipse")
                {
                    tempBit = new Bitmap(mainBit);
                    Graphics graphics = Graphics.FromImage(tempBit);
                    graphics.FillEllipse(brush, point.X, point.Y, e.X - point.X, e.Y - point.Y);
                    pictureBox1.Image = tempBit;
                }
                else if (state == "rectangle")
                {
                    tempBit = new Bitmap(mainBit);
                    Graphics graphics = Graphics.FromImage(tempBit);
                    graphics.DrawRectangle(new Pen(colorDialog1.Color), point.X, point.Y, e.X - point.X, e.Y - point.Y);
                    pictureBox1.Image = tempBit;
                }
                else if (state == "Frect")
                {
                    tempBit = new Bitmap(mainBit);
                    Graphics graphics = Graphics.FromImage(tempBit);
                    graphics.FillRectangle(brush, point.X, point.Y, e.X - point.X, e.Y - point.Y);
                    pictureBox1.Image = tempBit;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (state == "line")
            {
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.DrawLine(new Pen(colorDialog1.Color), point, e.Location);
                pictureBox1.Image = mainBit;
            }
            else if (state == "ellipse")
            {
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.DrawEllipse(new Pen(colorDialog1.Color), point.X, point.Y, e.X - point.X, e.Y - point.Y);
                pictureBox1.Image = mainBit;
            }
            else if (state == "Fellipse")
            {
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.FillEllipse(brush, point.X, point.Y, e.X - point.X, e.Y - point.Y);
                pictureBox1.Image = mainBit;
            }
            else if (state == "rectangle")
            {
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.DrawRectangle(new Pen(colorDialog1.Color), point.X, point.Y, e.X - point.X, e.Y - point.Y);
                pictureBox1.Image = mainBit;
            }
            else if (state == "Frect")
            {
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.FillRectangle(brush, point.X, point.Y, e.X - point.X, e.Y - point.Y);
                pictureBox1.Image = mainBit;
            }
            else if (state == "text")
            {
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.DrawString("text", new Font("Arial", (float)24), new SolidBrush(colorDialog1.Color), point.X, point.Y);
                pictureBox1.Image = mainBit;
            }
            else if (state == "Ftext")
            {
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.FillRectangle(new SolidBrush(colorDialog1.Color),new RectangleF(new PointF(point.X, point.Y),graphics.MeasureString("text", new Font("Arial", (float)24))));
                graphics.DrawString("text", new Font("Arial", (float)24), new SolidBrush(Color.White), point.X, point.Y);
                pictureBox1.Image = mainBit;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            state = "line1";
        }

        private void Circle_Button_Click(object sender, EventArgs e)
        {
            state = "ellipse";
        }

        private void Circle2_button_Click(object sender, EventArgs e)
        {
            state = "Fellipse";
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            state = "rectangle";
        }

        private void BlackRactangleButton_Click(object sender, EventArgs e)
        {
            state = "Frect";
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            state = "text";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            state = "Ftext";
        }
    }
}
