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
    public partial class Sajek_Hotel_Choice : Form
    {
        int cl = 0;
        Hotel ht = new Hotel();
        public Sajek_Hotel_Choice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Hotel ht = new Hotel();
            this.Hide();
            ht.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            homePage hp = new homePage();
            this.Hide();
            hp.Show();
        }

        private void radioRungRang_CheckedChanged(object sender, EventArgs e)
        {

            //cl = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cl == 1)
            {
                ht.Show();
                this.Hide();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void radioResort_CheckedChanged(object sender, EventArgs e)
        {
            cl = 1;
        }
    }
}
