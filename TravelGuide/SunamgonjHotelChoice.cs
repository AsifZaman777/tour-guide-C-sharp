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
    public delegate void totalSun(int a, int b);
    public partial class SunamgonjHotelChoice : Form
    {
        int test = 0;
        int sum = 0;
        int river_Cost = 2000;
        int mama_Cost = 4000;
        int wel_Cost = 5000;
        int travelGuide = 2000;


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");


        public SunamgonjHotelChoice()
        {
            InitializeComponent();
        }
        public void additionSun(int a, int b)
        {
            sum = a + b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homePage h = new homePage();
            h.Show();
            this.Hide();
        }
    
      public void choice()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            //string query1 = null;
            //string query2 = null;
            //string query3 = null;
            //con.Open();
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

                // query1 = "SELECT H1_T1 FROM HOTEL_INFO WHERE SPOT_CODE = 'SP3'";


                totalSun sun = this.additionSun;
                sun(river_Cost, travelGuide);


            }
            else if(test == 2)
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
                //query2 = "SELECT H1_T2 FROM HOTEL_INFO WHERE SPOT_CODE = 'SP3'";


                totalSun sun = this.additionSun;
                sun(mama_Cost, travelGuide);
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
                // query3 = "SELECT H1_T3 FROM HOTEL_INFO WHERE SPOT_CODE = 'SP3'";


                totalSun sun = this.additionSun;
                sun(wel_Cost, travelGuide);
            }
           /* SqlCommand cmd = new SqlCommand(query1, con);
            SqlCommand cma = new SqlCommand(query2, con);
            SqlCommand cmb = new SqlCommand(query3, con);
            SqlDataReader dr1 = cmd.ExecuteReader();
            SqlDataReader dr2 = cma.ExecuteReader();
            SqlDataReader dr3 = cmb.ExecuteReader();
            while (dr1.Read() && dr2.Read() && dr3.Read())
            {
                label2.Text = dr1.GetValue(0).ToString();
                label3.Text = dr2.GetValue(0).ToString();
                label4.Text = dr3.GetValue(0).ToString();
            }
            con.Close(); */
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void SunamgonjHotelChoice_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hotel ht = new Hotel();
            this.Hide();
            ht.Show();
        }
    }
}
