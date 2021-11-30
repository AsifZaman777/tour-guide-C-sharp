using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelGuide
{
    public partial class SignUp : Form
    {
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

            if(password.Text==confirm.Text)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }
            else
            {
                MessageBox.Show("Password mismatch");
            }   
        }

        /*textboxes
         * username
         * email
         * password
         * confirm
         */ 


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
    }
}
