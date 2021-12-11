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
using System.Text.RegularExpressions;

namespace TravelGuide
{
    public partial class SignUp : Form
    {
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string name = "^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+)*$";
        // Ryied SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");//Rayied db
        //Anik db//SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");
        // Asif Vai SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* con.Open();
             SqlCommand cmd = con.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "INSERT INTO USER_INFO (User_id,User_name,User_mail,User_pass,User_phone,User_gender) VALUES ('" + username.Text + "','" + email.Text + "','" + confirm.Text + "','" + textBox4.Text + "')"; //,'" + textBox4.Text + "')";
             cmd.ExecuteNonQuery();
             con.Close();
             MessageBox.Show("Registration Successful !");
             username.Clear();
             password.Clear();
             confirm.Clear();
             email.Clear();
             textBox4.Clear();
             /*if(password.Text==confirm.Text)
             {
                 Login login = new Login();
                 this.Hide();
                 login.Show();
             }
             else
             {
                 MessageBox.Show("Password mismatch");
             } */
           

        }
       



        private void cut1_Click(object sender, EventArgs e)
        {
            username.Clear();
        }

        private void cut2_Click(object sender, EventArgs e)
        {
            email.Clear();
        }

        private void cut3_Click(object sender, EventArgs e)
        {
            password.Clear();
        }

        private void cut4_Click(object sender, EventArgs e)
        {
            confirm.Clear();
        }

        private void cut1_MouseHover(object sender, EventArgs e)
        {
            cut1.BackColor = Color.Crimson;
        }

        private void cut1_MouseLeave(object sender, EventArgs e)
        {
            cut1.BackColor = Color.IndianRed;
        }

        private void cut2_MouseHover(object sender, EventArgs e)
        {
            cut2.BackColor = Color.Crimson;
        }

        private void cut2_MouseLeave(object sender, EventArgs e)
        {
            cut2.BackColor=Color.IndianRed;
        }

        private void cut3_MouseHover(object sender, EventArgs e)
        {
            cut3.BackColor = Color.Crimson;
        }

        private void cut3_MouseLeave(object sender, EventArgs e)
        {
            cut3.BackColor = Color.IndianRed;
        }

        private void cut4_MouseHover(object sender, EventArgs e)
        {
            cut4.BackColor = Color.Crimson;
        }

        private void cut4_MouseLeave(object sender, EventArgs e)
        {
            cut4.BackColor = Color.IndianRed;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(username.Text,name)==false)
            {
                username.Focus();
                username.Text = "type your Name";
                username.ForeColor = Color.Silver;
                errorProvider1.SetError(this.username, "Name cannot be empty");
            }
            else
            {
               
                username.ForeColor = Color.Black;
                errorProvider1.Clear();

            }
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "type your name")
            {
                username.Text = null;
                username.ForeColor = Color.Black;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(email.Text, pattern) == false)
            {
                email.Focus();
                email.Text = "type your email";
                email.ForeColor = Color.Silver;
                errorProvider2.SetError(this.email, "Invalid Email");

            }
            else
            {
                password.ForeColor = Color.Black;
                errorProvider2.Clear();
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "type your email")
                email.Text = null;
            email.ForeColor = Color.Black;
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password.Text) == true)
            {
                password.Focus();
                password.Text = "type password";
                password.ForeColor = Color.Silver;
                errorProvider3.SetError(this.password, "Password cannot be empty");
            }
            else
            {
                password.ForeColor = Color.Black;
                errorProvider3.Clear();
            }

        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "type password")
                password.Text = null;
            password.ForeColor = Color.Black;
        }

        private void confirm_Enter(object sender, EventArgs e)
        {
            if (confirm.Text == "retype password")
                confirm.Text = null;
            confirm.ForeColor = Color.Black;
        }

        private void confirm_Leave(object sender, EventArgs e)
        {
            if (String.Equals(password.Text, confirm.Text))
            {
                errorProvider4.Clear();
                    password.ForeColor = Color.Black;

            }
            else
            {
                confirm.Focus();
                errorProvider4.SetError(this.confirm, "Password Mismatch !");
           
            }
                if (confirm.Text == "")
                confirm.Text = "retype password";
            confirm.ForeColor = Color.Silver;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) == true)
            {
                textBox4.Focus();
                textBox4.Text = "type your phone number";
                textBox4.ForeColor = Color.Silver;
                //errorProvider5.SetError(this.textBox4, "Phone Number cannot be empty");
            }
            else
            {
                password.ForeColor = Color.Black;
                errorProvider5.Clear();
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "type your phone number")
                textBox4.Text = null;
            textBox4.ForeColor = Color.Black;
        }
    }
}
