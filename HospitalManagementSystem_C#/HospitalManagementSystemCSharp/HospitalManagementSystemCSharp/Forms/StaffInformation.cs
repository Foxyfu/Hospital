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
    public partial class StaffInformation : Form
    {
        Database database = new Database();
        public StaffInformation()
        {
            InitializeComponent();
        }

        private void StaffInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.hospitalDataSet.staff);
            using (MySqlConnection con1 = new MySqlConnection("server=localhost;user=root;database=test;password=d1k7f2l4;"))
            {
                string str2 = "SELECT * FROM staff";
                MySqlCommand cmd2 = new MySqlCommand(str2, con1);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }

            MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=test;password=d1k7f2l4;");
            con.Open();
            string str1 = "SELECT max(id) FROM staff;";
            MySqlCommand cmd1 = new MySqlCommand(str1, con);
            MySqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }
            }
            con.Close();
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
                string str = "INSERT INTO staff(name,gender,position,salary,contact,address) VALUES('" + textBox2.Text + "','" + gen + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";

                MySqlCommand cmd = new MySqlCommand(str, database.getConnection());
                cmd.ExecuteNonQuery();

                string str1 = "SELECT max(id) FROM staff;";
                MySqlCommand cmd1 = new MySqlCommand(str1, database.getConnection());
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Staff Information Saved Successfully.");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";

                    using (MySqlConnection con1 = new MySqlConnection("server=localhost;user=root;database=test;password=d1k7f2l4;"))
                    {
                        string str2 = "SELECT * FROM staff";
                        MySqlCommand cmd2 = new MySqlCommand(str2, con1);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
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
            database.openConnection();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "SELECT name,gender,position,salary,contact,address FROM staff WHERE id=" + Convert.ToInt32(textBox1.Text) + "";

                    MySqlCommand cmd = new MySqlCommand(getCust, database.getConnection());
                    MySqlDataReader dr;
                    dr = cmd.ExecuteReader();
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
                        textBox4.Text = dr.GetValue(2).ToString();
                        textBox5.Text = dr.GetValue(3).ToString();
                        textBox6.Text = dr.GetValue(4).ToString();
                        textBox7.Text = dr.GetValue(5).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, Staff with ID " + textBox1.Text + " is not available.");
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

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=test;password=d1k7f2l4;");
            con.Open();
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
                string str = "UPDATE staff SET name='" + textBox2.Text + "',gender='" + gen + "',position='" + textBox4.Text + "',salary='" + textBox5.Text + "',contact='" + textBox6.Text + "',address='" + textBox7.Text + "' WHERE id='" + textBox1.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "SELECT max(id) FROM staff;";
                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Details of " + textBox2.Text + " updated successfully.");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";

                    using (MySqlConnection con1 = new MySqlConnection("server=localhost;user=root;database=test;password=d1k7f2l4;"))
                    {
                        string str2 = "SELECT * FROM staff";
                        MySqlCommand cmd2 = new MySqlCommand(str2, con1);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox1.Text = "";
        }
    }
}
