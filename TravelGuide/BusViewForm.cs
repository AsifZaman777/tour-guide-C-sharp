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
    public partial class BusViewForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");
        int test = 0;
        public BusViewForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            panel1.Show();
            label5.Text = "Non-AC  : 800/-";
            label6.Text = "AC  : 1200/-";
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            panel1.Show();
            label5.Text = "Non-AC : 1000/-";
            label6.Text = "AC  : 1400/-";



        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            panel1.Show();
            label5.Text = "Non-AC  : 900/-";
            label6.Text = "AC : 1400/-";

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Crimson;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DeepPink;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            homePage homepage = new homePage();
            this.Hide();
            homepage.Show();
        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            homePage hp = new homePage();
            this.Hide();
            hp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (test == 1)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT E_ac,E_nac FROM TRANSPORT_INFO WHERE SPOT_CODE = 'SP1'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();



            }
            else if (test == 2)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT H_ac,H_nac FROM TRANSPORT_INFO WHERE SPOT_CODE = 'SP2'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();


            }
            else if (test == 3)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT S_ac,S_nac FROM TRANSPORT_INFO WHERE SPOT_CODE = 'SP3'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();


            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            test = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            test = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            test = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homePage hp = new homePage();
            this.Hide();
            hp.Show();
        }
    }
}
