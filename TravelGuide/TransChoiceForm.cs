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
    public partial class TransChoiceForm : Form
    {
        public TransChoiceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusViewForm f10 = new BusViewForm();
            this.Hide();
            f10.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RailViewForm f12 = new RailViewForm();
            this.Hide();
            f12.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            homePage hp = new homePage();
            this.Hide();
            hp.Show();
        }
    }
}
