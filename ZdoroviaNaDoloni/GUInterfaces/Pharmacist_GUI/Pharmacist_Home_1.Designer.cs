﻿namespace ZdoroviaNaDoloni.GUInterfaces.Pharmacist_GUI
{
    partial class Pharmacist_Home_1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist_Home_1));
            Name_Pharm = new Label();
            Logo_Pharm = new Button();
            pharm_user_info_btn = new Button();
            pharm_cart_btn = new Button();
            infoBox = new PictureBox();
            btn_search = new Button();
            pharm_home_btn = new Button();
            pharm_categor_btn = new Button();
            Txt_suggest = new Label();
            Txt_map = new Label();
            timer_img = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)infoBox).BeginInit();
            SuspendLayout();
            // 
            // Name_Pharm
            // 
            Name_Pharm.AutoSize = true;
            Name_Pharm.BackColor = Color.Transparent;
            Name_Pharm.Font = new Font("Segoe UI", 15F);
            Name_Pharm.ForeColor = Color.White;
            Name_Pharm.Location = new Point(125, 35);
            Name_Pharm.Name = "Name_Pharm";
            Name_Pharm.Size = new Size(177, 35);
            Name_Pharm.TabIndex = 35;
            Name_Pharm.Text = "Pharmacist 👋";
            // 
            // Logo_Pharm
            // 
            Logo_Pharm.BackColor = Color.FromArgb(192, 192, 255);
            Logo_Pharm.BackgroundImage = (Image)resources.GetObject("Logo_Pharm.BackgroundImage");
            Logo_Pharm.Cursor = Cursors.Hand;
            Logo_Pharm.FlatAppearance.BorderSize = 0;
            Logo_Pharm.FlatStyle = FlatStyle.Flat;
            Logo_Pharm.Location = new Point(31, 35);
            Logo_Pharm.Name = "Logo_Pharm";
            Logo_Pharm.Size = new Size(75, 75);
            Logo_Pharm.TabIndex = 34;
            Logo_Pharm.UseVisualStyleBackColor = false;
            // 
            // pharm_user_info_btn
            // 
            pharm_user_info_btn.BackColor = Color.Transparent;
            pharm_user_info_btn.BackgroundImage = (Image)resources.GetObject("pharm_user_info_btn.BackgroundImage");
            pharm_user_info_btn.Cursor = Cursors.Hand;
            pharm_user_info_btn.FlatAppearance.BorderSize = 0;
            pharm_user_info_btn.FlatStyle = FlatStyle.Flat;
            pharm_user_info_btn.Font = new Font("Segoe UI", 8F);
            pharm_user_info_btn.Location = new Point(300, 761);
            pharm_user_info_btn.Name = "pharm_user_info_btn";
            pharm_user_info_btn.Size = new Size(75, 75);
            pharm_user_info_btn.TabIndex = 33;
            pharm_user_info_btn.UseVisualStyleBackColor = false;
            pharm_user_info_btn.Click += pharm_user_info_btn_Click;
            // 
            // pharm_cart_btn
            // 
            pharm_cart_btn.BackColor = Color.Transparent;
            pharm_cart_btn.BackgroundImage = (Image)resources.GetObject("pharm_cart_btn.BackgroundImage");
            pharm_cart_btn.Cursor = Cursors.Hand;
            pharm_cart_btn.FlatAppearance.BorderSize = 0;
            pharm_cart_btn.FlatStyle = FlatStyle.Flat;
            pharm_cart_btn.Font = new Font("Segoe UI", 8F);
            pharm_cart_btn.Location = new Point(206, 761);
            pharm_cart_btn.Name = "pharm_cart_btn";
            pharm_cart_btn.Size = new Size(75, 75);
            pharm_cart_btn.TabIndex = 32;
            pharm_cart_btn.UseVisualStyleBackColor = false;
            // 
            // infoBox
            // 
            infoBox.BackColor = Color.Transparent;
            infoBox.BorderStyle = BorderStyle.Fixed3D;
            infoBox.Location = new Point(30, 363);
            infoBox.Name = "infoBox";
            infoBox.Size = new Size(341, 338);
            infoBox.TabIndex = 31;
            infoBox.TabStop = false;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(192, 192, 255);
            btn_search.BackgroundImage = (Image)resources.GetObject("btn_search.BackgroundImage");
            btn_search.Cursor = Cursors.Hand;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Location = new Point(30, 145);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(334, 55);
            btn_search.TabIndex = 30;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // pharm_home_btn
            // 
            pharm_home_btn.BackColor = Color.Transparent;
            pharm_home_btn.BackgroundImage = (Image)resources.GetObject("pharm_home_btn.BackgroundImage");
            pharm_home_btn.Cursor = Cursors.No;
            pharm_home_btn.FlatAppearance.BorderSize = 0;
            pharm_home_btn.FlatStyle = FlatStyle.Flat;
            pharm_home_btn.Location = new Point(18, 707);
            pharm_home_btn.Name = "pharm_home_btn";
            pharm_home_btn.Size = new Size(75, 75);
            pharm_home_btn.TabIndex = 29;
            pharm_home_btn.UseVisualStyleBackColor = false;
            // 
            // pharm_categor_btn
            // 
            pharm_categor_btn.BackColor = Color.Transparent;
            pharm_categor_btn.BackgroundImage = (Image)resources.GetObject("pharm_categor_btn.BackgroundImage");
            pharm_categor_btn.Cursor = Cursors.Hand;
            pharm_categor_btn.FlatAppearance.BorderSize = 0;
            pharm_categor_btn.FlatStyle = FlatStyle.Flat;
            pharm_categor_btn.Font = new Font("Segoe UI", 8F);
            pharm_categor_btn.Location = new Point(112, 761);
            pharm_categor_btn.Name = "pharm_categor_btn";
            pharm_categor_btn.Size = new Size(75, 75);
            pharm_categor_btn.TabIndex = 28;
            pharm_categor_btn.UseVisualStyleBackColor = false;
            pharm_categor_btn.Click += pharm_categor_btn_Click;
            // 
            // Txt_suggest
            // 
            Txt_suggest.AutoSize = true;
            Txt_suggest.BackColor = Color.Transparent;
            Txt_suggest.Cursor = Cursors.No;
            Txt_suggest.Font = new Font("Segoe UI", 14F);
            Txt_suggest.Location = new Point(34, 270);
            Txt_suggest.Name = "Txt_suggest";
            Txt_suggest.Size = new Size(138, 32);
            Txt_suggest.TabIndex = 27;
            Txt_suggest.Text = "Пропозиції";
            // 
            // Txt_map
            // 
            Txt_map.AutoSize = true;
            Txt_map.BackColor = Color.Transparent;
            Txt_map.Cursor = Cursors.Hand;
            Txt_map.Font = new Font("Segoe UI", 14F);
            Txt_map.ForeColor = Color.White;
            Txt_map.Location = new Point(220, 270);
            Txt_map.Name = "Txt_map";
            Txt_map.Size = new Size(144, 32);
            Txt_map.TabIndex = 26;
            Txt_map.Text = "Карта аптек";
            Txt_map.Click += Txt_map_Click;
            // 
            // timer_img
            // 
            timer_img.Tick += timer_img_Tick;
            // 
            // Pharmacist_Home_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(392, 852);
            Controls.Add(Name_Pharm);
            Controls.Add(Logo_Pharm);
            Controls.Add(pharm_user_info_btn);
            Controls.Add(pharm_cart_btn);
            Controls.Add(infoBox);
            Controls.Add(btn_search);
            Controls.Add(pharm_home_btn);
            Controls.Add(pharm_categor_btn);
            Controls.Add(Txt_suggest);
            Controls.Add(Txt_map);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pharmacist_Home_1";
            Text = "Pharmacist_Home_1";
            Load += Pharmacist_Home_1_Load;
            ((System.ComponentModel.ISupportInitialize)infoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name_Pharm;
        private Button Logo_Pharm;
        private Button pharm_user_info_btn;
        private Button pharm_cart_btn;
        private PictureBox infoBox;
        private Button btn_search;
        private Button pharm_home_btn;
        private Button pharm_categor_btn;
        private Label Txt_suggest;
        private Label Txt_map;
        private System.Windows.Forms.Timer timer_img;
    }
}