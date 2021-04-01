using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace laba25_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadFtable()
        {
            using (var connection = new SqliteConnection("Data Source=FlowersShop.db"))
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM Flowers";

                SqliteCommand command = new SqliteCommand(sqlExpression, connection);

                SqliteDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                }
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

                reader.Close();
                connection.Close();
            }
        }
        private void LoadSecTable()
        {
            using (var connection = new SqliteConnection("Data Source=FlowersShop.db"))
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM InShop";

                SqliteCommand command = new SqliteCommand(sqlExpression, connection);

                SqliteDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                }
                foreach (string[] s in data)
                    dataGridView2.Rows.Add(s);

                reader.Close();
                connection.Close();
            }
        }
        private void LoadTherdTable()
        {
            using (var connection = new SqliteConnection("Data Source=FlowersShop.db"))
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM Sells";

                SqliteCommand command = new SqliteCommand(sqlExpression, connection);

                SqliteDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                }
                foreach (string[] s in data)
                    dataGridView3.Rows.Add(s);

                reader.Close();
                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadFtable();
            LoadSecTable();
            LoadTherdTable();
        }
    }
}
