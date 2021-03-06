using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace TravelGuide
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//asif
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romona Sarker\OneDrive - American International University-Bangladesh\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//Angela DB
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//Rayied DB

        int cl = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
            label4.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            checkBox1.BackColor = Color.Transparent;

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            //nothing
        }



        ///all the mouse events

        private void button4_MouseHover(object sender, EventArgs e)
        {
            btnshowpass.BackColor = Color.Crimson;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnshowpass.BackColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.SteelBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor=Color.DeepSkyBlue;
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor=Color.SteelBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor=Color.DeepSkyBlue;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
            label4.BackColor = Color.Crimson;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
            label4.BackColor = Color.Transparent;
        }

        //label 2,3 click text cleanup

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        ///SignUp page call

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }


        ///form closed
        
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cl == 2)
            {

                if (textBox1.Text != "" && textBox2.Text != "")
                {
                   // SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");
                    string query = "select * from USER_INFO where User_name = '" + textBox1.Text.Trim() + "' and User_pass = '" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable sdtbl = new DataTable();
                    sda.Fill(sdtbl);
                    if (sdtbl.Rows.Count == 1)
                    {
                        homePage home = new homePage();
                        this.Hide();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or password.!\n Try again please.");
                        textBox1.Clear();
                        textBox2.Clear();
                    }

                }

            }
            if (cl == 1)
            {
               if (textBox1.Text != "" && textBox2.Text != "")
                {
                ///SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");

                    string query = "select * from ADMIN_INFO where Admin_name = '" + textBox1.Text.Trim() + "' and Admin_pass = '" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable sdtbl = new DataTable();
                    sda.Fill(sdtbl);

                    
                   if (sdtbl.Rows.Count == 1)
                    {
                        this.Hide();
                        Admin1 a = new Admin1();
                        a.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or password.!\n Try again please.");
                        textBox1.Clear();
                        textBox2.Clear();

                       
                    }
                
                }

                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

          /* if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Text = "Type your ID";
                textBox1.ForeColor = Color.Silver;
            }
           */ if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Text = "type your name";
                textBox1.ForeColor = Color.Silver;
                //textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "This section is empty !");
            }
            
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                errorProvider3.SetError(this.textBox2, "This section cannot be empty !");
                textBox1.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            WelcomeForm w = new WelcomeForm();
            w.Show();
            this.Hide();
        }
        private void btnshowpass_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "type your name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
                
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void UsercheckBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void AdminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cl = 1;
        }

        private void UserRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cl = 2;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (cl == 1)
            {
                label5.Text = "Hello Admin.";
            }
            if (cl == 2)
            {
                label5.Text = "Hello User.";
            }
        }
    }
}
