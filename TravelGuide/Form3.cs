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
            //labels background color

            panel3.BackColor= Color.FromArgb(100,0,0,0);

            //labels Hiding
            panel3.Hide();

            //labels tranparency
            label3.BackColor = Color.Transparent;

            //label 3 picturebox transparent
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox20.BackColor = Color.Transparent;

            panel4.BackColor = Color.FromArgb(100,0,0,0);
            label13.BackColor = Color.Transparent;
            pictureBox24.BackColor=Color.Transparent;
            label14.BackColor= Color.Transparent;


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


        /// Resturant Hover
        /// 
        private void sajekFood_MouseHover(object sender, EventArgs e)
        {
            sajekFood.BackColor = Color.Green;
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
            pictureBox1.BackColor = Color.PaleVioletRed;
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
            pictureBox21.BackColor = Color.PaleVioletRed;
        }


        //hote click

        private void sajekHotel_Click(object sender, EventArgs e)
        {
             Hotel_Room hotel = new Hotel_Room();
            this.Hide();
            hotel.Show();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hotel_Room hotel = new Hotel_Room();
            this.Hide();
            hotel.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Hotel_Room hotel = new Hotel_Room();
            this.Hide();
            hotel.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Hotel_Room hotel = new Hotel_Room();
            this.Hide();
            hotel.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hotel_Room hotel = new Hotel_Room();
            this.Hide();
            hotel.Show();
        }


        //resturant click

        private void sajekFood_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(740, 60);
            label3.Text = "Helipad Hotel";
            label6.Text = "Winter Restaurant";
            label7.Text = "Cloud Restaurant";
            label9.Text = "Bhai Food hall";
            label12.Text = "Mayer Doa Hotel";
            panel3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(1143, 60);
            label3.Text = "Sea View Hotel";
            label6.Text = "Eastern Restaurant";
            label7.Text = "Hill View Restaurant";
            label9.Text = "Bondhu Food hall";
            label12.Text = "Northern  Restaurant";
            panel3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(300, 300);
            label3.Text = "Aronno Hotel";
            label6.Text = "Nirjon Restaurant";
            label7.Text = "Modhu Restaurant";
            label9.Text = "Forest Food hall";
            label12.Text = "Ratri Restaurant";
            panel3.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(747, 300);
            label3.Text = "Sea point View Hotel";
            label6.Text = "Crab Restaurant";
            label7.Text = "Purnima Restaurant";
            label9.Text = "Bhai Bhai Restora";
            label12.Text = "Western Food";
            panel3.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(1143, 300);
            label3.Text = "Sylhet Hotel";
            label6.Text = "Cha Bagan Hotel";
            label7.Text = "Hill Top Hotel";
            label9.Text = "Chienese";
            label12.Text = "Exo Food hall";
            panel3.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form5 form5=new Form5();
            this.Hide();
            form5.Show();
        }

        private void nothing_Click(object sender, EventArgs e) ///Cox's bazaar pictureBox 
        {
            Form6 form6=new Form6();
            this.Hide();
            form6.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form7 form7=new Form7();
            this.Hide();
            form7.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Hide();
            form8.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form9 form9=new Form9();
            this.Hide();
            form9.Show();
        }

        private void sajekBus_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            this.Hide();
            f10.Show();
        }

        private void labelBus_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            this.Hide();
            f10.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            this.Hide();
            f10.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            this.Hide();
            f10.Show();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            //Form10 f10 = new Form10();
            //this.Hide();
            //f10.Show();
            Form11 f11 = new Form11();
            this.Hide();
            f11.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. After login select a package "+ 
                "\n2. Then select the transport bus package " +
                "\n3. Then select hotel package as your wish list" +
                "\n4. You can see restaurants around the area you selected" +
                "\n5. Then confirm all the stuffs and get your ticket");
        }

       

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }
    }
}
