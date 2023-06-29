using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HospitalManagementSystemCSharp
{
    public partial class PatientRegistration : Form
    {
        Database dataBase = new Database();
        public PatientRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string gen = string.Empty;
            if (radioButton1.Checked)
            {
                gen = "Male";
            }
            else
            {
                gen = "Female";
            }
            try
            {
                string str = "INSERT INTO patient(name,gen,age,date,cont,addr,disease,status,r_type,building,r_no,price) VALUES('" + textBox_name.Text + "','" + gen + "','" + textBox_age.Text + "','" + textBox_date.Text + "','" + textBox_cont.Text + "','" + textBox_addr.Text + "','" + textBox7.Text + "','" + textBox_status.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + textBox_price.Text + "'); ";
                dataBase.openConnection();
                dataBase.ExecuteNonQuery(str);
                string str1 = "SELECT MAX(Id) FROM patient;";
                int maxId = Convert.ToInt32(dataBase.ExecuteScalar(str1));
                MessageBox.Show("Информация о пациенте успешно сохранена.");
                textBox_name.Text = "";
                textBox_age.Text = "";
                textBox_date.Text = "";
                textBox_cont.Text = "";
                textBox_addr.Text = "";
                textBox7.Text = "";
                textBox_status.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox_price.Text = "";
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            dataBase.closeConnection();
        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string str1 = "SELECT MAX(id) FROM patient;";
            int maxId = Convert.ToInt32(dataBase.ExecuteScalar(str1));
            textBox_id.Text = (maxId + 1).ToString();
            dataBase.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_age.Text = "";
            textBox_date.Text = "";
            textBox_cont.Text = "";
            textBox_addr.Text = "";
            textBox7.Text = "";
            textBox_status.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox_price.Text = "";
            textBox_id.Text = "";
        }
    }
}
