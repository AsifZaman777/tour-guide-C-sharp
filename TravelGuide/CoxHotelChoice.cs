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
    public delegate void totalCox(int a, int b);

    public partial class CoxHotelChoice : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//asif
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romona Sarker\OneDrive - American International University-Bangladesh\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//Angela DB
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//Rayied DB
        int test = 0;
        int sum = 0;
        int saymon_Cost= 2000;
        int sea_Cost = 4000;
        int royal_Cost = 5000;
        int travelGuide = 2000;
        public CoxHotelChoice()
        {
            InitializeComponent();
        }
        public void additionCox(int a, int b)
        {
            sum = a + b;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            homePage h = new homePage();
            h.Show();
            this.Hide();
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


                totalCox cox = this.additionCox;
                cox(saymon_Cost, travelGuide);

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


                totalCox cox = this.additionCox;
                cox(sea_Cost, travelGuide);

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


                totalCox cox = this.additionCox;
                cox(royal_Cost, travelGuide);
            }
            MessageBox.Show("Hotel and Local Guide Cost = " + sum + "/-");
        }

        private void radioHill_CheckedChanged(object sender, EventArgs e)
        {
            test = 1;
        }

        private void radioRose_CheckedChanged(object sender, EventArgs e)
        {
            test = 2;
        }

        private void radioResort_CheckedChanged(object sender, EventArgs e)
        {
            test = 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hotel ht = new Hotel();
            this.Hide();
            ht.Show();
        }
    }
}
