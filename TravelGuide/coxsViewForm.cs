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
    public partial class coxsViewForm : Form
    {
        public coxsViewForm()
        {
            InitializeComponent();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Crimson;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DeepPink;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            homePage homepage = new homePage();
            this.Hide();
            homepage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusViewForm bb = new BusViewForm();
            this.Hide();
            bb.Show();
        }
    }
}
