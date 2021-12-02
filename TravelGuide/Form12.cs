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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
            panel1.Show();
            label4.Text = "Subarna Express : 600/- \n Destination: Dhaka to Sylhet";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            panel1.Show();
            label4.Text = "Jamuna Express : 700/- \n Destination: Dhaka to Sylhet";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            this.Hide();
            f11.Show();
        }
    }
}
