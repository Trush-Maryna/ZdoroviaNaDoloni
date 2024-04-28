namespace ZdoroviaNaDoloni
{
    partial class Guest_Home_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest_Home_1));
            Txt_Sign_in = new Label();
            Txt_Log_in = new Label();
            Txt_map = new Label();
            Txt_suggest = new Label();
            guest_categor_btn = new Button();
            guest_home_btn = new Button();
            btn_search = new Button();
            infoBox = new PictureBox();
            timer_img = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)infoBox).BeginInit();
            SuspendLayout();
            // 
            // Txt_Sign_in
            // 
            Txt_Sign_in.AutoSize = true;
            Txt_Sign_in.BackColor = Color.Transparent;
            Txt_Sign_in.Cursor = Cursors.Hand;
            Txt_Sign_in.Font = new Font("Segoe UI", 15F);
            Txt_Sign_in.Location = new Point(128, 37);
            Txt_Sign_in.Name = "Txt_Sign_in";
            Txt_Sign_in.Size = new Size(88, 35);
            Txt_Sign_in.TabIndex = 1;
            Txt_Sign_in.Text = "Увійти";
            Txt_Sign_in.Click += Txt_Sign_in_Click;
            // 
            // Txt_Log_in
            // 
            Txt_Log_in.AutoSize = true;
            Txt_Log_in.BackColor = Color.Transparent;
            Txt_Log_in.Cursor = Cursors.Hand;
            Txt_Log_in.Font = new Font("Segoe UI", 13F);
            Txt_Log_in.Location = new Point(128, 72);
            Txt_Log_in.Name = "Txt_Log_in";
            Txt_Log_in.Size = new Size(221, 30);
            Txt_Log_in.TabIndex = 2;
            Txt_Log_in.Text = "або зареєструватися";
            Txt_Log_in.Click += Txt_Log_in_Click;
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
            Txt_map.TabIndex = 3;
            Txt_map.Text = "Карта аптек";
            Txt_map.Click += Txt_map_Click;
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
            Txt_suggest.TabIndex = 4;
            Txt_suggest.Text = "Пропозиції";
            // 
            // guest_categor_btn
            // 
            guest_categor_btn.BackColor = Color.Transparent;
            guest_categor_btn.BackgroundImage = (Image)resources.GetObject("guest_categor_btn.BackgroundImage");
            guest_categor_btn.Cursor = Cursors.Hand;
            guest_categor_btn.FlatAppearance.BorderSize = 0;
            guest_categor_btn.FlatStyle = FlatStyle.Flat;
            guest_categor_btn.Font = new Font("Segoe UI", 8F);
            guest_categor_btn.Location = new Point(206, 761);
            guest_categor_btn.Name = "guest_categor_btn";
            guest_categor_btn.Size = new Size(75, 75);
            guest_categor_btn.TabIndex = 5;
            guest_categor_btn.UseVisualStyleBackColor = false;
            guest_categor_btn.Click += guest_categor_btn_Click;
            // 
            // guest_home_btn
            // 
            guest_home_btn.BackColor = Color.Transparent;
            guest_home_btn.BackgroundImage = (Image)resources.GetObject("guest_home_btn.BackgroundImage");
            guest_home_btn.Cursor = Cursors.No;
            guest_home_btn.FlatAppearance.BorderSize = 0;
            guest_home_btn.FlatStyle = FlatStyle.Flat;
            guest_home_btn.Location = new Point(112, 707);
            guest_home_btn.Name = "guest_home_btn";
            guest_home_btn.Size = new Size(75, 75);
            guest_home_btn.TabIndex = 6;
            guest_home_btn.UseVisualStyleBackColor = false;
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
            btn_search.TabIndex = 8;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // infoBox
            // 
            infoBox.BackColor = Color.Transparent;
            infoBox.BorderStyle = BorderStyle.Fixed3D;
            infoBox.Location = new Point(30, 363);
            infoBox.Name = "infoBox";
            infoBox.Size = new Size(341, 338);
            infoBox.TabIndex = 13;
            infoBox.TabStop = false;
            // 
            // timer_img
            // 
            timer_img.Tick += timer_img_Tick;
            // 
            // Guest_Home_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(392, 852);
            Controls.Add(infoBox);
            Controls.Add(btn_search);
            Controls.Add(guest_home_btn);
            Controls.Add(guest_categor_btn);
            Controls.Add(Txt_suggest);
            Controls.Add(Txt_map);
            Controls.Add(Txt_Log_in);
            Controls.Add(Txt_Sign_in);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Guest_Home_1";
            Text = "Guest_Form";
            Load += Guest_Home_1_Load;
            ((System.ComponentModel.ISupportInitialize)infoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Txt_Sign_in;
        private Label Txt_Log_in;
        private Label Txt_map;
        private Label Txt_suggest;
        private Button guest_categor_btn;
        private Button guest_home_btn;
        private Button btn_search;
        private PictureBox infoBox;
        private System.Windows.Forms.Timer timer_img;
    }
}