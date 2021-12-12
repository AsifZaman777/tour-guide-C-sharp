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
    public partial class BandarbanHotelChoice : Form
    {
        public delegate void totalBan(int a, int b);
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//Rayied DB
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//asif
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romona Sarker\OneDrive - American International University-Bangladesh\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//Angela DB
        int test = 0;
        int sum = 0;
        int lit_Cost = 2000;
        int heaven_Cost = 4000;
        int nil_Cost = 5000;
        int travelGuide = 2000;
        public BandarbanHotelChoice()
        {
            InitializeComponent();
        }
        public void additionBan(int a, int b)
        {
            sum = a + b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homePage h = new homePage();
            h.Show();
            this.Hide();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            test = 1;
        }

        private void radioNight_CheckedChanged(object sender, EventArgs e)
        {
            test = 2;
        }

        private void radioNIlam_CheckedChanged(object sender, EventArgs e)
        {
            test = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (test == 1)
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


                totalBan ban = this.additionBan;
                ban(lit_Cost, travelGuide);

            }
            else if (test == 2)
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


                totalBan ban = this.additionBan;
                ban(heaven_Cost, travelGuide);

            }
            else if (test == 3)
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


                totalBan ban = this.additionBan;
                ban(nil_Cost, travelGuide);

            }

            MessageBox.Show("Hotel and Local Guide Cost = " + sum + "/-");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hotel ht = new Hotel();
            this.Hide();
            ht.Show();
        }
    }
}
