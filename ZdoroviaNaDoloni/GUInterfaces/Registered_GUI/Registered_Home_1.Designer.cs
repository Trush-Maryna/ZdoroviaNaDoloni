namespace ZdoroviaNaDoloni.GUInterfaces.Registered_GUI
{
    partial class Registered_Home_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registered_Home_1));
            infoBox = new PictureBox();
            btn_search = new Button();
            register_home_btn = new Button();
            register_categor_btn = new Button();
            Txt_suggest = new Label();
            Txt_map = new Label();
            register_cart_btn = new Button();
            register_user_info_btn = new Button();
            Logo_User = new Button();
            Btn_Yes = new Button();
            Btn_No = new Button();
            Name_User = new Label();
            timer_img = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)infoBox).BeginInit();
            SuspendLayout();
            // 
            // infoBox
            // 
            infoBox.BackColor = Color.Transparent;
            infoBox.BorderStyle = BorderStyle.Fixed3D;
            infoBox.Location = new Point(30, 363);
            infoBox.Name = "infoBox";
            infoBox.Size = new Size(341, 338);
            infoBox.TabIndex = 19;
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
            btn_search.TabIndex = 18;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // register_home_btn
            // 
            register_home_btn.BackColor = Color.Transparent;
            register_home_btn.BackgroundImage = (Image)resources.GetObject("register_home_btn.BackgroundImage");
            register_home_btn.Cursor = Cursors.No;
            register_home_btn.FlatAppearance.BorderSize = 0;
            register_home_btn.FlatStyle = FlatStyle.Flat;
            register_home_btn.Location = new Point(18, 707);
            register_home_btn.Name = "register_home_btn";
            register_home_btn.Size = new Size(75, 75);
            register_home_btn.TabIndex = 17;
            register_home_btn.UseVisualStyleBackColor = false;
            // 
            // register_categor_btn
            // 
            register_categor_btn.BackColor = Color.Transparent;
            register_categor_btn.BackgroundImage = (Image)resources.GetObject("register_categor_btn.BackgroundImage");
            register_categor_btn.Cursor = Cursors.Hand;
            register_categor_btn.FlatAppearance.BorderSize = 0;
            register_categor_btn.FlatStyle = FlatStyle.Flat;
            register_categor_btn.Font = new Font("Segoe UI", 8F);
            register_categor_btn.Location = new Point(112, 761);
            register_categor_btn.Name = "register_categor_btn";
            register_categor_btn.Size = new Size(75, 75);
            register_categor_btn.TabIndex = 16;
            register_categor_btn.UseVisualStyleBackColor = false;
            register_categor_btn.Click += register_categor_btn_Click;
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
            Txt_suggest.TabIndex = 15;
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
            Txt_map.TabIndex = 14;
            Txt_map.Text = "Карта аптек";
            Txt_map.Click += Txt_map_Click;
            // 
            // register_cart_btn
            // 
            register_cart_btn.BackColor = Color.Transparent;
            register_cart_btn.BackgroundImage = (Image)resources.GetObject("register_cart_btn.BackgroundImage");
            register_cart_btn.Cursor = Cursors.Hand;
            register_cart_btn.FlatAppearance.BorderSize = 0;
            register_cart_btn.FlatStyle = FlatStyle.Flat;
            register_cart_btn.Font = new Font("Segoe UI", 8F);
            register_cart_btn.Location = new Point(206, 761);
            register_cart_btn.Name = "register_cart_btn";
            register_cart_btn.Size = new Size(75, 75);
            register_cart_btn.TabIndex = 20;
            register_cart_btn.UseVisualStyleBackColor = false;
            register_cart_btn.Click += register_cart_btn_Click;
            // 
            // register_user_info_btn
            // 
            register_user_info_btn.BackColor = Color.Transparent;
            register_user_info_btn.BackgroundImage = (Image)resources.GetObject("register_user_info_btn.BackgroundImage");
            register_user_info_btn.Cursor = Cursors.Hand;
            register_user_info_btn.FlatAppearance.BorderSize = 0;
            register_user_info_btn.FlatStyle = FlatStyle.Flat;
            register_user_info_btn.Font = new Font("Segoe UI", 8F);
            register_user_info_btn.Location = new Point(300, 761);
            register_user_info_btn.Name = "register_user_info_btn";
            register_user_info_btn.Size = new Size(75, 75);
            register_user_info_btn.TabIndex = 21;
            register_user_info_btn.UseVisualStyleBackColor = false;
            register_user_info_btn.Click += register_user_info_btn_Click;
            // 
            // Logo_User
            // 
            Logo_User.BackColor = Color.FromArgb(192, 192, 255);
            Logo_User.BackgroundImage = (Image)resources.GetObject("Logo_User.BackgroundImage");
            Logo_User.Cursor = Cursors.Hand;
            Logo_User.FlatAppearance.BorderSize = 0;
            Logo_User.FlatStyle = FlatStyle.Flat;
            Logo_User.Location = new Point(31, 35);
            Logo_User.Name = "Logo_User";
            Logo_User.Size = new Size(75, 75);
            Logo_User.TabIndex = 22;
            Logo_User.UseVisualStyleBackColor = false;
            // 
            // Btn_Yes
            // 
            Btn_Yes.BackColor = Color.FromArgb(192, 192, 255);
            Btn_Yes.BackgroundImage = (Image)resources.GetObject("Btn_Yes.BackgroundImage");
            Btn_Yes.Cursor = Cursors.Hand;
            Btn_Yes.FlatAppearance.BorderSize = 0;
            Btn_Yes.FlatStyle = FlatStyle.Flat;
            Btn_Yes.Location = new Point(142, 102);
            Btn_Yes.Name = "Btn_Yes";
            Btn_Yes.Size = new Size(42, 23);
            Btn_Yes.TabIndex = 23;
            Btn_Yes.UseVisualStyleBackColor = false;
            // 
            // Btn_No
            // 
            Btn_No.BackColor = Color.FromArgb(192, 192, 255);
            Btn_No.BackgroundImage = (Image)resources.GetObject("Btn_No.BackgroundImage");
            Btn_No.Cursor = Cursors.Hand;
            Btn_No.FlatAppearance.BorderSize = 0;
            Btn_No.FlatStyle = FlatStyle.Flat;
            Btn_No.Location = new Point(195, 102);
            Btn_No.Name = "Btn_No";
            Btn_No.Size = new Size(63, 23);
            Btn_No.TabIndex = 24;
            Btn_No.UseVisualStyleBackColor = false;
            // 
            // Name_User
            // 
            Name_User.AutoSize = true;
            Name_User.BackColor = Color.Transparent;
            Name_User.Font = new Font("Segoe UI", 15F);
            Name_User.ForeColor = Color.White;
            Name_User.Location = new Point(125, 35);
            Name_User.Name = "Name_User";
            Name_User.Size = new Size(105, 35);
            Name_User.TabIndex = 25;
            Name_User.Text = "User 👋";
            // 
            // timer_img
            // 
            timer_img.Tick += timer_img_Tick;
            // 
            // Registered_Home_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(392, 852);
            Controls.Add(Name_User);
            Controls.Add(Btn_No);
            Controls.Add(Btn_Yes);
            Controls.Add(Logo_User);
            Controls.Add(register_user_info_btn);
            Controls.Add(register_cart_btn);
            Controls.Add(infoBox);
            Controls.Add(btn_search);
            Controls.Add(register_home_btn);
            Controls.Add(register_categor_btn);
            Controls.Add(Txt_suggest);
            Controls.Add(Txt_map);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registered_Home_1";
            Text = "Registered_Home_1";
            Load += Registered_Home_1_Load;
            ((System.ComponentModel.ISupportInitialize)infoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox infoBox;
        private Button btn_search;
        private Button register_home_btn;
        private Button register_categor_btn;
        private Label Txt_suggest;
        private Label Txt_map;
        private Button register_cart_btn;
        private Button register_user_info_btn;
        private Button Logo_User;
        private Button Btn_Yes;
        private Button Btn_No;
        private Label Name_User;
        private System.Windows.Forms.Timer timer_img;
    }
}