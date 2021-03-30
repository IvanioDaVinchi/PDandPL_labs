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
        Bitmap copyBit;
        private Font fnt = new Font("Arial", 10);
        Brush brush = new SolidBrush(Color.Black);

        public Form1()
        {
            InitializeComponent();
            mainBit = new Bitmap(1920, 1080);
            tempBit = new Bitmap(mainBit);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            mainBit = new Bitmap((sender as PictureBox).Image);
            PictureBox box = sender as PictureBox;
            if (state == "paste")
            {
                Graphics graphics = Graphics.FromImage(mainBit);
                graphics.DrawImage(copyBit, e.Location);
                box.Image = mainBit;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var pictureBox1 = sender as PictureBox;
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
                else if(state =="copy")
                {
                    tempBit = new Bitmap(mainBit);
                    Graphics graphics = Graphics.FromImage(tempBit);
                    graphics.DrawRectangle(new Pen(colorDialog1.Color), point.X-1, point.Y-1, e.X - point.X+1, e.Y - point.Y+1);
                    pictureBox1.Image = tempBit;
                }
                else if(state == "cut")
                {
                    tempBit = new Bitmap(mainBit);
                    Graphics graphics = Graphics.FromImage(tempBit);
                    graphics.DrawRectangle(new Pen(colorDialog1.Color), point.X-1, point.Y-1, e.X - point.X+1, e.Y - point.Y+1);
                    pictureBox1.Image = tempBit;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var pictureBox1 = sender as PictureBox;
            if (state == "line")
            {
                mainBit = new Bitmap(pictureBox1.Image);
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.DrawLine(new Pen(colorDialog1.Color), point, e.Location);
                pictureBox1.Image = mainBit;
            }
            else if (state == "ellipse")
            {
                mainBit = new Bitmap(pictureBox1.Image);
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.DrawEllipse(new Pen(colorDialog1.Color), point.X, point.Y, e.X - point.X, e.Y - point.Y);
                pictureBox1.Image = mainBit;
            }
            else if (state == "Fellipse")
            {
                mainBit = new Bitmap(pictureBox1.Image);
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.FillEllipse(brush, point.X, point.Y, e.X - point.X, e.Y - point.Y);
                pictureBox1.Image = mainBit;
            }
            else if (state == "rectangle")
            {
                mainBit = new Bitmap(pictureBox1.Image);
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.DrawRectangle(new Pen(colorDialog1.Color), point.X, point.Y, e.X - point.X, e.Y - point.Y);
                pictureBox1.Image = mainBit;
            }
            else if (state == "Frect")
            {
                mainBit = new Bitmap(pictureBox1.Image);
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.FillRectangle(brush, point.X, point.Y, e.X - point.X, e.Y - point.Y);
                pictureBox1.Image = mainBit;
            }
            else if (state == "text")
            {
                mainBit = new Bitmap(pictureBox1.Image);
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.DrawString("text", new Font("Arial", (float)24), new SolidBrush(colorDialog1.Color), point.X, point.Y);
                pictureBox1.Image = mainBit;
            }
            else if (state == "Ftext")
            {
                mainBit = new Bitmap(pictureBox1.Image);
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.FillRectangle(new SolidBrush(colorDialog1.Color), new RectangleF(new PointF(point.X, point.Y), graphics.MeasureString("text", new Font("Arial", (float)24))));
                graphics.DrawString("text", new Font("Arial", (float)24), new SolidBrush(Color.White), point.X, point.Y);
                pictureBox1.Image = mainBit;
            }
            else if (state == "copy")
            {
                copyBit = mainBit.Clone(new Rectangle(point.X, point.Y,Math.Abs(point.X - e.X),Math.Abs(point.Y - e.Y)), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                pictureBox1.Image = mainBit;
            }
            else if(state == "cut")
            {
                mainBit = tempBit;
                Graphics graphics = Graphics.FromImage(tempBit);
                copyBit = mainBit.Clone(new Rectangle(point.X , point.Y , Math.Abs(point.X - e.X), Math.Abs(point.Y - e.Y)), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                graphics.FillRectangle(new SolidBrush(this.BackColor), point.X-1, point.Y-1, e.X - point.X + 2, e.Y - point.Y + 2);
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.MdiParent = this;
            PictureBox box = new PictureBox();
            box.Dock = DockStyle.Fill;
            box.MouseDown += pictureBox1_MouseDown;
            box.MouseUp += pictureBox1_MouseUp;
            box.MouseMove+=pictureBox1_MouseMove;
            box.Image = new Bitmap(1920, 1080);
            f.Controls.Add(box);
            f.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] fs = MdiChildren;
            foreach (var item in fs)
                item.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = "copy";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = "paste";
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = "cut";
        }
    }
}
