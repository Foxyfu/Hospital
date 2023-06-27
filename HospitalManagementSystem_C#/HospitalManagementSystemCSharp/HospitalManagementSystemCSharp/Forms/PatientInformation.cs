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
    public partial class PatientInformation : Form
    {
        Database database = new Database();
        public PatientInformation()
        {
            InitializeComponent();
        }

        private void PatientInformation_Load(object sender, EventArgs e)
        {
            
            this.patientTableAdapter.Fill(this.hospitalDataSet1.patient);
            {

                string str2 = "SELECT * FROM patient";
                MySqlCommand cmd2 = new MySqlCommand(str2, database.getConnection());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kurs\HospitalManagementSystem_C#\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True");

            database.openConnection();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select name,gen,age,date,cont,addr,disease,status,r_type,building,r_no,price from patient where id=" + Convert.ToInt32(textBox1.Text) + " ;";

                    MySqlDataAdapter cmd = new MySqlDataAdapter(getCust, database.getConnection());
                    MySqlDataReader dr = new MySqlDataReader(getCust,);
                    dr = 
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
                        textBox4.Text = dr.GetValue(3).ToString();
                        textBox5.Text = dr.GetValue(4).ToString();
                        textBox6.Text = dr.GetValue(5).ToString();
                        textBox7.Text = dr.GetValue(6).ToString();
                        textBox8.Text = dr.GetValue(7).ToString();
                        textBox10.Text = dr.GetValue(8).ToString();
                        textBox9.Text = dr.GetValue(9).ToString();
                        textBox11.Text = dr.GetValue(10).ToString();
                        textBox12.Text = dr.GetValue(11).ToString();
                        
                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID, " + textBox1.Text + " Staff is not Available.   ");
                        textBox1.Text = "";
                    }
                }
                catch (MySqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                database.closeConnection();
            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kurs\HospitalManagementSystem_C#\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True");
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
                string str = " Update patient set name='" + textBox2.Text + "',gen='" + gen + "',age='" + textBox3.Text + "',date='" + textBox4.Text + "',cont='" + textBox5.Text + "',addr='" + textBox6.Text + "',disease='" + textBox7.Text + "',status='" + textBox8.Text  + "',r_type='" + textBox10.Text + "',building='" + textBox9.Text + "',r_no='" + textBox11.Text + "',price='" + textBox12.Text + "' where id='" + textBox1.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from patient;";

                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Cведения о " + textBox2.Text + " успешно обновлены.. ", "Important Message");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    using (MySqlConnection con1 = new MySqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kurs\HospitalManagementSystem_C#\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True"))
                    {

                        string str2 = "SELECT * FROM patient";
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
            MySqlConnection con = new MySqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kurs\HospitalManagementSystem_C#\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True");
            con.Open();
            try
            {

                string str = "DELETE FROM patient WHERE id = '" + textBox1.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Запись пациента успешно удалена ");
                using (con)
                {

                    string str2 = "SELECT * FROM patient";
                    MySqlCommand cmd2 = new MySqlCommand(str2, con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Пожалуйста, введите идентификатор пациента.");
            }
        }
    }
    
}
