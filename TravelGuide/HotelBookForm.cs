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
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }

        private void Hotel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor=Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;

            checkBox1.BackColor = Color.Transparent;
            checkBox2.BackColor = Color.Transparent;
            checkBox3.BackColor = Color.Transparent;

            SunamgonjHotelChoice smob = new SunamgonjHotelChoice();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            homePage homepage = new homePage();
            this.Hide();
            homepage.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Crimson;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DeepPink;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
