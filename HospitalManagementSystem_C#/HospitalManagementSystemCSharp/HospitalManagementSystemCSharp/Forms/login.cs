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
    public partial class login : Form
    {
        Database database = new Database();
        public login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
           
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string hashedPassword = GetHashedPassword(passUser);
            string querystring = $"SELECT login, password FROM register WHERE login = '{loginUser}' AND password = '{hashedPassword}'";


            MySqlCommand comand = new MySqlCommand(querystring,database.getConnection());

            adapter.SelectCommand = comand;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Home obj1 = new Home();
                obj1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверное Имя пользователя или Пароль.");
            }
         }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            textBox_password.UseSystemPasswordChar = true;
            pictureBox2.Visible = false;
            pictureBox3 .Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
