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
    public partial class Hotel_Room : Form
    {
        public Hotel_Room()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotel ht = new Hotel();
            this.Hide();
            ht.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            homePage hp = new homePage();
            this.Hide();
            hp.Show();
        }
    }
}
