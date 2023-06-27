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
using System.Windows.Input;

namespace HospitalManagementSystemCSharp
{
    public partial class PatientRegistration : Form
    {
        Database database = new Database();
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

                MySqlCommand cmd = new MySqlCommand(str, database.getConnection());
                cmd.ExecuteNonQuery();
                string str1 = "select max(Id) from patient;";
                database.openConnection();
                MySqlCommand cmd1 = new MySqlCommand(str1, database.getConnection());
                MySqlDataReader dr = cmd1.ExecuteReader();
                
                adapter.SelectCommand = cmd1;
                adapter.Fill(table);
                if (dr.Read())
                {
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
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            database.closeConnection();
        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            
            string str1 = "select max(id) from patient;";

            MySqlCommand cmd1 = new MySqlCommand(str1, database.getConnection());

            database.openConnection();
            MySqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox_id.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox_id.Text = a.ToString();
                }
            }
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
