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
    public partial class Admin2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//Rayied DB

        public Admin2()
        {
            InitializeComponent();
        }

        private void ViewTransButton_Click(object sender, EventArgs e)
        {
            Admin1 ad = new Admin1();
            ad.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void Admin2_Load(object sender, EventArgs e)
        {
            displayData();
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
        }

        private void LiveSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " SELECT * FROM TRANSPORT_INFO WHERE SPOT_CODE = '" + LiveSearch.Text + "'";
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
            /*con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " UPDATE TRANSPORT_INFO SET H_ac ='" + textBox101.Text + "', H_nac= '" + textBox102.Text + "', E_ac= '" + textBox103.Text + "', E_nac= '" + textBox104.Text + "', S_ac= '" + textBox105.Text + "', S_nac= '" + textBox106.Text + "' WHERE SPOT_CODE = '" + label3.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            displayData();
            MessageBox.Show("Successfully Updated !");
            textBox2.Clear();*/

            //Rayied code
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE TRANSPORT_INFO SET H_ac='" + textBox101.Text + "',H_nac='" + textBox102.Text + "',E_ac='" + textBox103.Text + "',E_nac='" + textBox104.Text + "',S_ac='" + textBox105.Text + "',S_nac='" + textBox106.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
            MessageBox.Show("Successfully Updated !");
        }
    }
}
