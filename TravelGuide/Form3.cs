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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            addLabel.BackColor = Color.Transparent;
        }

        private void homePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addButton_MouseHover(object sender, EventArgs e)
        {
            addButton.BackColor = Color.Crimson;
        }

        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.BackColor=Color.White;
        }

        private void sajekBus_MouseHover(object sender, EventArgs e)
        {
            sajekBus.BackColor = Color.Coral;
        }

        private void sajekBus_MouseLeave(object sender, EventArgs e)
        {
            sajekBus.BackColor = Color.DeepSkyBlue;
        }

        private void labelBus_MouseHover(object sender, EventArgs e)
        {
            labelBus.BackColor = Color.Coral;
        }

        private void labelBus_MouseLeave(object sender, EventArgs e)
        {
            labelBus.BackColor = Color.DeepSkyBlue;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Coral;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.DeepSkyBlue;
        }

        private void pictureBox19_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.BackColor = Color.Coral;
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.BackColor = Color.DeepSkyBlue;
        }

        private void pictureBox23_MouseHover(object sender, EventArgs e)
        {
            pictureBox23.BackColor = Color.Coral;
        }

        private void pictureBox23_MouseLeave(object sender, EventArgs e)
        {
            pictureBox23.BackColor = Color.DeepSkyBlue;
        }


        ///hotel hover//

        private void sajekHotel_MouseHover(object sender, EventArgs e)
        {
            sajekHotel.BackColor = Color.DeepSkyBlue;
        }

        private void sajekHotel_MouseLeave(object sender, EventArgs e)
        {
            sajekHotel.BackColor = Color.Coral;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor=Color.DeepSkyBlue;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor=Color.Coral;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.DeepSkyBlue;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Coral;
        }

        private void pictureBox18_MouseHover(object sender, EventArgs e)
        {
            pictureBox18.BackColor = Color.DeepSkyBlue;
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.BackColor = Color.Coral;
        }

        private void pictureBox22_MouseHover(object sender, EventArgs e)
        {
            pictureBox22.BackColor = Color.DeepSkyBlue;
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.BackColor = Color.Coral;
        }

        /// Resturant


        private void sajekFood_MouseHover(object sender, EventArgs e)
        {
            sajekFood.BackColor=Color.Green;
        }

        private void sajekFood_MouseLeave(object sender, EventArgs e)
        {
            sajekFood.BackColor = Color.PaleVioletRed;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor=Color.PaleVioletRed;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Green;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.PaleVioletRed;
        }

        private void pictureBox17_MouseHover(object sender, EventArgs e)
        {
            pictureBox17.BackColor = Color.Green;
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.BackColor = Color.PaleVioletRed;
        }

        private void pictureBox21_MouseHover(object sender, EventArgs e)
        {
            pictureBox21.BackColor = Color.Green;
        }

        private void pictureBox21_MouseLeave(object sender, EventArgs e)
        {
            pictureBox21.BackColor=Color.PaleVioletRed; 
        }

        private void sajekHotel_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            this.Hide();
            hotel.Show();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            this.Hide();
            hotel.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            this.Hide();
            hotel.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            this.Hide();
            hotel.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            this.Hide();
            hotel.Show();
        }

        private void sajekFood_Click(object sender, EventArgs e)
        {
            Food f1 = new Food();
            this.Hide();
            f1.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Food f1 = new Food();
            this.Hide();
            f1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Food f1 = new Food();
            this.Hide();
            f1.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Food f1 = new Food();
            this.Hide();
            f1.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Food f1 = new Food();
            this.Hide();
            f1.Show();
        }
    }
}
