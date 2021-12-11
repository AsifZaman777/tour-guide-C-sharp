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
namespace TravelGuide
{
    public partial class Sajek_Hotel_Choice : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");
        int cl = 0;
        Hotel ht = new Hotel();
        public Sajek_Hotel_Choice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Hotel ht = new Hotel();
            this.Hide();
            ht.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            homePage hp = new homePage();
            this.Hide();
            hp.Show();
        }

        private void radioRungRang_CheckedChanged(object sender, EventArgs e)
        {

            cl = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cl == 1)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT H1_T1,H1_T2,H1_T3 FROM HOTEL_INFO WHERE SPOT_CODE = 'SP3'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();



            }
            else if (cl == 2)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT H2_T1,H2_T2,H2_T3 FROM HOTEL_INFO WHERE SPOT_CODE = 'SP3'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();


            }
            else if (cl == 3)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT H3_T1,H3_T2,H3_T3 FROM HOTEL_INFO WHERE SPOT_CODE = 'SP3'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();


            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void radioResort_CheckedChanged(object sender, EventArgs e)
        {
            cl = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homePage h = new homePage();
            h.Show();
            this.Hide();
        }

        private void radioSajekResort_CheckedChanged(object sender, EventArgs e)
        {
            cl = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cl = 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hotel ht = new Hotel();
            this.Hide();
            ht.Show();
        }
    }
}
