using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba22_2
{
    public partial class Form1 : Form
    {
        int proc = 0;
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            progressBar1.Minimum= int.Parse(textBox1.Text);
            progressBar1.Maximum = int.Parse(textBox2.Text);
            proc= int.Parse(textBox1.Text);
            if (backgroundWorker1.IsBusy!=true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;


            for (int j = int.Parse(textBox1.Text); j <= int.Parse(textBox2.Text); j++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    worker.ReportProgress(j);
                    System.Threading.Thread.Sleep(1);

                }
            }
        }

        public static bool ProstoeChiNe(int num)
        {
            int counter = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num%i==0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                return true;
            }
            return false;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = proc;
            proc++;
            if (ProstoeChiNe(e.ProgressPercentage))
            {
                listBox1.Items.Add(e.ProgressPercentage);
            }
        }
    }
}
