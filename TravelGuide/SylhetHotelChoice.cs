﻿using System;
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
    public partial class SylhetHotelChoice : Form
    {
        public SylhetHotelChoice()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homePage h = new homePage();
            h.Show();
            this.Hide();
        }
    }
}
