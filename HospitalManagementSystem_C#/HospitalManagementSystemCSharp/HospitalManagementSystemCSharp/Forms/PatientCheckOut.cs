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
    public partial class PatientCheckOut : Form
    {
        Database database = new Database();

        public PatientCheckOut()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            database.openConnection();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "SELECT name, gen, age, cont, addr, disease FROM patient WHERE id=" + Convert.ToInt32(textBox1.Text) + ";";

                    MySqlCommand cmd = new MySqlCommand(getCust, database.getConnection());
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox2.Text = dr.GetValue(0).ToString();
                        if (dr[1].ToString() == "Male")
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                        textBox3.Text = dr.GetValue(2).ToString();
                        textBox5.Text = dr.GetValue(3).ToString();
                        textBox6.Text = dr.GetValue(4).ToString();
                        textBox7.Text = dr.GetValue(5).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ip = , " + textBox1.Text + " не найден.");
                        textBox1.Text = "";
                    }
                }
                catch (MySqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                database.closeConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
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
                string str = "INSERT INTO checkout(name, gen, age, contact, addr, disease, date_in, date_out, build, r_no, r_type, status, med_price, total) " +
                             "VALUES('" + textBox2.Text + "','" + gen + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" +
                             textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox14.Text + "','" +
                             textBox13.Text + "','" + textBox15.Text + "')";

                MySqlCommand cmd = new MySqlCommand(str, database.getConnection());
                cmd.ExecuteNonQuery();

                string str1 = "SELECT max(Id) FROM checkout;";
                MySqlCommand cmd1 = new MySqlCommand(str1, database.getConnection());
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Ифнормация о пациенте сохранена.");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                }
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            database.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
        }
    }
}
