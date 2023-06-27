using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HospitalManagementSystemCSharp
{
    public partial class RoomInfo : Form
    {
        private Database database;

        public RoomInfo()
        {
            InitializeComponent();
            database = new Database();
        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            using (MySqlConnection con1 = new MySqlConnection("server=localhost;user=root;database=test;password=d1k7f2l4;"))
            {
                string str2 = "SELECT * FROM room";
                MySqlCommand cmd2 = new MySqlCommand(str2, con1);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            try
            {
                string str = "INSERT INTO room(building, r_type, r_no, no_bed, price, r_status) " +
                             "VALUES(@building, @r_type, @r_no, @no_bed, @price, @r_status)";

                MySqlCommand cmd = new MySqlCommand(str, database.getConnection());
                cmd.Parameters.AddWithValue("@building", textBox1.Text);
                cmd.Parameters.AddWithValue("@r_type", textBox2.Text);
                cmd.Parameters.AddWithValue("@r_no", textBox3.Text);
                cmd.Parameters.AddWithValue("@no_bed", textBox4.Text);
                cmd.Parameters.AddWithValue("@price", textBox5.Text);
                cmd.Parameters.AddWithValue("@r_status", textBox6.Text);
                cmd.ExecuteNonQuery();

                string str1 = "SELECT max(Id) FROM room;";
                MySqlCommand cmd1 = new MySqlCommand(str1, database.getConnection());
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Room Information Saved Successfully.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";

                    using (MySqlConnection con1 = new MySqlConnection("server=localhost;user=root;database=test;password=d1k7f2l4;"))
                    {
                        string str2 = "SELECT * FROM room";
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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
