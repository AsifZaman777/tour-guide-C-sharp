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
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//Rayied DB
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romona Sarker\OneDrive - American International University-Bangladesh\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//Angela DB
          SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");
          //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");

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
            cmd.CommandText = " SELECT * FROM HOTEL_INFO";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {

            displayData();
            /*con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " SELECT * FROM TRANSPORT_INFO";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close(); */

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

          /*  test = 1;
            InitializeComponent();
            dataGridView1.DataSource = new Database().Userinfotable.Get(); */
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
            dataGridView2.DataSource = dt;
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[index];
            label3.Text = row.Cells[0].Value.ToString();
            textBox101.Text = row.Cells[1].Value.ToString();
            textBox102.Text = row.Cells[2].Value.ToString();
            textBox103.Text = row.Cells[3].Value.ToString();
            textBox104.Text = row.Cells[4].Value.ToString();
            textBox105.Text = row.Cells[5].Value.ToString();
            textBox106.Text = row.Cells[6].Value.ToString();
            textBox107.Text = row.Cells[7].Value.ToString();
            textBox108.Text = row.Cells[8].Value.ToString();
            textBox109.Text = row.Cells[9].Value.ToString();
        }

        private void LiveSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " SELECT * FROM HOTEL_INFO WHERE SPOT_CODE = '" + LiveSearch.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            
           
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //Anik code
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " UPDATE HOTEL_INFO SET H1_T1 ='" + textBox101.Text + "', H1_T2 = '" + textBox102.Text + "', H1_T3 = '" + textBox103.Text + "', H2_T1 = '" + textBox104.Text + "', H2_T2 = '" + textBox105.Text + "', H2_T3 = '" + textBox106.Text + "', H3_T1 = '" + textBox104.Text + "', H3_T2 = '" + textBox105.Text + "', H3_T3 = '" + textBox106.Text + "' WHERE SPOT_CODE = '" + label3.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            displayData();
            MessageBox.Show("Successfully Updated !");/*

            //Rayied code
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE HOTEL_INFO SET H1_T1='" + textBox101.Text + "',H1_T2='" + textBox102.Text + "',H1_T3='" + textBox103.Text + "',H2_T1='" + textBox104.Text + "',H2_T2='" + textBox105.Text + "',H2_T3='" + textBox106.Text + "',H3_T1='" + textBox107.Text + "',H3_T2='" + textBox108.Text + "',H3_T3='" + textBox109.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
            MessageBox.Show("Successfully Updated !");
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
