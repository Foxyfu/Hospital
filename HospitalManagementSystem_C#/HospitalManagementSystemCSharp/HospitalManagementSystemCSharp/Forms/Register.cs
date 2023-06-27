using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace HospitalManagementSystemCSharp
{
    public partial class Register : Form
    {
        Database dataBase = new Database();
        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Register_Load_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;


            string querystring = $"insert into register(login, password) values('{login}', '{password}') ";

            MySqlCommand cmd = new MySqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            if(cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех");
                login form = new login();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            dataBase.closeConnection();
        }

        private Boolean checkuser()
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id, login, password from test_table where login = '{login}' and password = '{password}";

            MySqlCommand comand = new MySqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = comand;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else { return false; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            textBox2.UseSystemPasswordChar = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
