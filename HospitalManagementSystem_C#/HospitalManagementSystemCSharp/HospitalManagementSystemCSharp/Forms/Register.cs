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
using System.Security.Cryptography;

namespace HospitalManagementSystemCSharp
{
    public partial class Register : Form
    {
        //ghbdtn
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

        private string GetHashedPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Преобразование пароля в байтовый массив
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Преобразование байтового массива в строку
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Преобразование в шестнадцатеричное представление
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            // Хэширование пароля
            string hashedPassword = GetHashedPassword(password);

            string querystring = $"insert into register(login, password) values('{login}', '{hashedPassword}') ";
            // Остальной код остается без изменений

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
    }
}
