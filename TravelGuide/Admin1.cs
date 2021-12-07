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
using DataAccessLayer;

namespace TravelGuide
{
    public partial class Admin1 : Form
    {
        int test = 0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");

        public Admin1()
        {
            InitializeComponent();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void displayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " SELECT * FROM TRANSPORT_INFO";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {

            displayData();
          
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            /*if (test == 1)
            {
                cmd.CommandText = " SELECT * FROM USER_INFO WHERE USER_ID = '" + textBox9.Text + "'";

            }
            if (test == 2)
            {
                cmd.CommandText = " SELECT * FROM HISTORY_INFO WHERE USER_ID = '" + textBox9.Text + "'";

            }*/
            cmd.CommandText = " SELECT * FROM HOTEL_INFO WHERE SPOT_CODE = '" + textBox9.Text + "'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void UserInfoRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            test = 1;
            InitializeComponent();
            dataGridView1.DataSource = new Database().Userinfotable.Get();
            /* con.Open();
             SqlCommand cmd = con.CreateCommand();
             cmd.CommandType = CommandType.Text;
                 cmd.CommandText = " SELECT * FROM USER_INFO";
             cmd.ExecuteNonQuery();
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);
             dataGridView1.DataSource = dt;
             con.Close();*/
        }

        private void UserHistoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            test = 2;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
                cmd.CommandText = " SELECT * FROM HISTORY_INFO";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " SELECT * FROM USER_INFO ";
            if (test == 1)
            {
                cmd.CommandText = " SELECT * FROM USER_INFO";

            }
            if (test == 2)
            {
                cmd.CommandText = " SELECT * FROM HISTORY_INFO";

            }
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void ViewHotelButton_Click(object sender, EventArgs e)
        {
            Admin2 ad = new Admin2();
            ad.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
