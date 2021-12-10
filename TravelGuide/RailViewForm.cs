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
    public partial class RailViewForm : Form
    {
        public RailViewForm()
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
            label4.Text = "    Kalni Express. \n Cost : 450/- \n Destination: Dhaka to Sylhet. \n    Distance : 243.3 km ( 6 hour 9 min)";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            panel1.Show();
            label4.Text = "    Parabot Express. \n Cost : 500/- \n Destination: Dhaka to Sylhet. \n    Distance : 243.3 km ( 6 hour 9 min)";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            TransChoiceForm f11 = new TransChoiceForm();
            this.Hide();
            f11.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
