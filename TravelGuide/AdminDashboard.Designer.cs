﻿
namespace TravelGuide
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Admin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.TransLbl = new System.Windows.Forms.Label();
            this.TransVariantLbl = new System.Windows.Forms.Label();
            this.HotelNameLbl = new System.Windows.Forms.Label();
            this.HotelRoomLbl = new System.Windows.Forms.Label();
            this.CheckinLbl = new System.Windows.Forms.Label();
            this.CheckoutLbl = new System.Windows.Forms.Label();
            this.PlaceLbl = new System.Windows.Forms.Label();
            this.NumPeopleLbl = new System.Windows.Forms.Label();
            this.TotalCostLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.UserInfoRadioButton = new System.Windows.Forms.RadioButton();
            this.UserHistoryRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1201, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.BackColor = System.Drawing.Color.IndianRed;
            this.Admin.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(517, 9);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(130, 44);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Admin";
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 219);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.BackColor = System.Drawing.Color.Thistle;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.Location = new System.Drawing.Point(24, 325);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(67, 25);
            this.UsernameLbl.TabIndex = 4;
            this.UsernameLbl.Text = "Name";
            // 
            // TransLbl
            // 
            this.TransLbl.AutoSize = true;
            this.TransLbl.BackColor = System.Drawing.Color.Thistle;
            this.TransLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransLbl.Location = new System.Drawing.Point(24, 423);
            this.TransLbl.Name = "TransLbl";
            this.TransLbl.Size = new System.Drawing.Size(161, 25);
            this.TransLbl.TabIndex = 5;
            this.TransLbl.Text = "Transport Name";
            // 
            // TransVariantLbl
            // 
            this.TransVariantLbl.AutoSize = true;
            this.TransVariantLbl.BackColor = System.Drawing.Color.Thistle;
            this.TransVariantLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransVariantLbl.Location = new System.Drawing.Point(24, 472);
            this.TransVariantLbl.Name = "TransVariantLbl";
            this.TransVariantLbl.Size = new System.Drawing.Size(172, 25);
            this.TransVariantLbl.TabIndex = 6;
            this.TransVariantLbl.Text = "Transport Variant";
            // 
            // HotelNameLbl
            // 
            this.HotelNameLbl.AutoSize = true;
            this.HotelNameLbl.BackColor = System.Drawing.Color.Thistle;
            this.HotelNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelNameLbl.Location = new System.Drawing.Point(24, 524);
            this.HotelNameLbl.Name = "HotelNameLbl";
            this.HotelNameLbl.Size = new System.Drawing.Size(123, 25);
            this.HotelNameLbl.TabIndex = 7;
            this.HotelNameLbl.Text = "Hotel Name";
            // 
            // HotelRoomLbl
            // 
            this.HotelRoomLbl.AutoSize = true;
            this.HotelRoomLbl.BackColor = System.Drawing.Color.Thistle;
            this.HotelRoomLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelRoomLbl.Location = new System.Drawing.Point(24, 572);
            this.HotelRoomLbl.Name = "HotelRoomLbl";
            this.HotelRoomLbl.Size = new System.Drawing.Size(122, 25);
            this.HotelRoomLbl.TabIndex = 8;
            this.HotelRoomLbl.Text = "Hotel Room";
            // 
            // CheckinLbl
            // 
            this.CheckinLbl.AutoSize = true;
            this.CheckinLbl.BackColor = System.Drawing.Color.Thistle;
            this.CheckinLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckinLbl.Location = new System.Drawing.Point(594, 325);
            this.CheckinLbl.Name = "CheckinLbl";
            this.CheckinLbl.Size = new System.Drawing.Size(92, 25);
            this.CheckinLbl.TabIndex = 9;
            this.CheckinLbl.Text = "Check In";
            // 
            // CheckoutLbl
            // 
            this.CheckoutLbl.AutoSize = true;
            this.CheckoutLbl.BackColor = System.Drawing.Color.Thistle;
            this.CheckoutLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutLbl.Location = new System.Drawing.Point(594, 391);
            this.CheckoutLbl.Name = "CheckoutLbl";
            this.CheckoutLbl.Size = new System.Drawing.Size(108, 25);
            this.CheckoutLbl.TabIndex = 10;
            this.CheckoutLbl.Text = "Check Out";
            // 
            // PlaceLbl
            // 
            this.PlaceLbl.AutoSize = true;
            this.PlaceLbl.BackColor = System.Drawing.Color.Thistle;
            this.PlaceLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceLbl.Location = new System.Drawing.Point(24, 372);
            this.PlaceLbl.Name = "PlaceLbl";
            this.PlaceLbl.Size = new System.Drawing.Size(61, 25);
            this.PlaceLbl.TabIndex = 11;
            this.PlaceLbl.Text = "Place";
            // 
            // NumPeopleLbl
            // 
            this.NumPeopleLbl.AutoSize = true;
            this.NumPeopleLbl.BackColor = System.Drawing.Color.Thistle;
            this.NumPeopleLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPeopleLbl.Location = new System.Drawing.Point(594, 457);
            this.NumPeopleLbl.Name = "NumPeopleLbl";
            this.NumPeopleLbl.Size = new System.Drawing.Size(181, 25);
            this.NumPeopleLbl.TabIndex = 12;
            this.NumPeopleLbl.Text = "Number of People";
            // 
            // TotalCostLbl
            // 
            this.TotalCostLbl.AutoSize = true;
            this.TotalCostLbl.BackColor = System.Drawing.Color.Thistle;
            this.TotalCostLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLbl.Location = new System.Drawing.Point(180, 631);
            this.TotalCostLbl.Name = "TotalCostLbl";
            this.TotalCostLbl.Size = new System.Drawing.Size(105, 25);
            this.TotalCostLbl.TabIndex = 13;
            this.TotalCostLbl.Text = "Total Cost";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 325);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 22);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 375);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 22);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(239, 426);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(296, 22);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(239, 475);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(296, 22);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(239, 527);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(296, 22);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(239, 584);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(296, 22);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(796, 460);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(296, 22);
            this.textBox7.TabIndex = 20;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(314, 634);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(221, 22);
            this.textBox8.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(750, 326);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(342, 29);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(750, 391);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(342, 29);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Yellow;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(599, 524);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(141, 52);
            this.UpdateButton.TabIndex = 24;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.Yellow;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(774, 615);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(141, 52);
            this.LogoutButton.TabIndex = 25;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Yellow;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(774, 527);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(141, 52);
            this.DeleteButton.TabIndex = 26;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.Yellow;
            this.InsertButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InsertButton.Location = new System.Drawing.Point(962, 527);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(141, 52);
            this.InsertButton.TabIndex = 27;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SearchButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchButton.Location = new System.Drawing.Point(12, 51);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(141, 31);
            this.SearchButton.TabIndex = 28;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(159, 53);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(336, 29);
            this.textBox9.TabIndex = 29;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // UserInfoRadioButton
            // 
            this.UserInfoRadioButton.AutoSize = true;
            this.UserInfoRadioButton.Location = new System.Drawing.Point(700, 61);
            this.UserInfoRadioButton.Name = "UserInfoRadioButton";
            this.UserInfoRadioButton.Size = new System.Drawing.Size(133, 21);
            this.UserInfoRadioButton.TabIndex = 30;
            this.UserInfoRadioButton.TabStop = true;
            this.UserInfoRadioButton.Text = "User Information";
            this.UserInfoRadioButton.UseVisualStyleBackColor = true;
            this.UserInfoRadioButton.CheckedChanged += new System.EventHandler(this.UserInfoRadioButton_CheckedChanged);
            // 
            // UserHistoryRadioButton
            // 
            this.UserHistoryRadioButton.AutoSize = true;
            this.UserHistoryRadioButton.Location = new System.Drawing.Point(554, 61);
            this.UserHistoryRadioButton.Name = "UserHistoryRadioButton";
            this.UserHistoryRadioButton.Size = new System.Drawing.Size(107, 21);
            this.UserHistoryRadioButton.TabIndex = 31;
            this.UserHistoryRadioButton.TabStop = true;
            this.UserHistoryRadioButton.Text = "User History";
            this.UserHistoryRadioButton.UseVisualStyleBackColor = true;
            this.UserHistoryRadioButton.CheckedChanged += new System.EventHandler(this.UserHistoryRadioButton_CheckedChanged);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 679);
            this.Controls.Add(this.UserHistoryRadioButton);
            this.Controls.Add(this.UserInfoRadioButton);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TotalCostLbl);
            this.Controls.Add(this.NumPeopleLbl);
            this.Controls.Add(this.PlaceLbl);
            this.Controls.Add(this.CheckoutLbl);
            this.Controls.Add(this.CheckinLbl);
            this.Controls.Add(this.HotelRoomLbl);
            this.Controls.Add(this.HotelNameLbl);
            this.Controls.Add(this.TransVariantLbl);
            this.Controls.Add(this.TransLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label TransLbl;
        private System.Windows.Forms.Label TransVariantLbl;
        private System.Windows.Forms.Label HotelNameLbl;
        private System.Windows.Forms.Label HotelRoomLbl;
        private System.Windows.Forms.Label CheckinLbl;
        private System.Windows.Forms.Label CheckoutLbl;
        private System.Windows.Forms.Label PlaceLbl;
        private System.Windows.Forms.Label NumPeopleLbl;
        private System.Windows.Forms.Label TotalCostLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.RadioButton UserInfoRadioButton;
        private System.Windows.Forms.RadioButton UserHistoryRadioButton;
    }
}