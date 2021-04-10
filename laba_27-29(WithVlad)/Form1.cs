using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_27_29_WithVlad_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void MenedgerBtn_Click(object sender, EventArgs e)
        {

        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            new AdminF().Show();
        }
    }
}
