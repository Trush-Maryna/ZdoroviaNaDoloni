namespace ZdoroviaNaDoloni.GUInterfaces.Product_GUI
{
    partial class Info_Guest_Product_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Guest_Product_Form));
            btn_open_home = new Button();
            btn_search = new Button();
            guest_categor_btn = new Button();
            guest_home_btn = new Button();
            Img_Product_Box = new PictureBox();
            Name_Product = new Label();
            Developer_Product = new Label();
            Product_Price = new Label();
            Sign_In = new Label();
            Log_In = new Label();
            Btn_Buy = new Button();
            Btn_Map = new Button();
            Detailed_Descr_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)Img_Product_Box).BeginInit();
            SuspendLayout();
            // 
            // btn_open_home
            // 
            btn_open_home.BackColor = Color.FromArgb(120, 120, 184);
            btn_open_home.BackgroundImage = (Image)resources.GetObject("btn_open_home.BackgroundImage");
            btn_open_home.Cursor = Cursors.Hand;
            btn_open_home.FlatAppearance.BorderSize = 0;
            btn_open_home.FlatStyle = FlatStyle.Flat;
            btn_open_home.ForeColor = Color.Transparent;
            btn_open_home.Location = new Point(15, 16);
            btn_open_home.Name = "btn_open_home";
            btn_open_home.Size = new Size(30, 30);
            btn_open_home.TabIndex = 1;
            btn_open_home.UseVisualStyleBackColor = false;
            btn_open_home.Click += btn_open_home_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(192, 192, 255);
            btn_search.BackgroundImage = (Image)resources.GetObject("btn_search.BackgroundImage");
            btn_search.Cursor = Cursors.Hand;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Location = new Point(30, 81);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(334, 55);
            btn_search.TabIndex = 9;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
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
            guest_categor_btn.TabIndex = 10;
            guest_categor_btn.UseVisualStyleBackColor = false;
            guest_categor_btn.Click += guest_categor_btn_Click;
            // 
            // guest_home_btn
            // 
            guest_home_btn.BackColor = Color.Transparent;
            guest_home_btn.BackgroundImage = (Image)resources.GetObject("guest_home_btn.BackgroundImage");
            guest_home_btn.Cursor = Cursors.Hand;
            guest_home_btn.FlatAppearance.BorderSize = 0;
            guest_home_btn.FlatStyle = FlatStyle.Flat;
            guest_home_btn.Location = new Point(112, 761);
            guest_home_btn.Name = "guest_home_btn";
            guest_home_btn.Size = new Size(75, 75);
            guest_home_btn.TabIndex = 16;
            guest_home_btn.UseVisualStyleBackColor = false;
            guest_home_btn.Click += guest_home_btn_Click;
            // 
            // Img_Product_Box
            // 
            Img_Product_Box.BackColor = Color.Transparent;
            Img_Product_Box.BackgroundImageLayout = ImageLayout.Center;
            Img_Product_Box.Location = new Point(0, 155);
            Img_Product_Box.Name = "Img_Product_Box";
            Img_Product_Box.Size = new Size(393, 180);
            Img_Product_Box.SizeMode = PictureBoxSizeMode.CenterImage;
            Img_Product_Box.TabIndex = 17;
            Img_Product_Box.TabStop = false;
            // 
            // Name_Product
            // 
            Name_Product.AutoSize = true;
            Name_Product.BackColor = Color.Transparent;
            Name_Product.Font = new Font("Segoe UI", 14F);
            Name_Product.Location = new Point(30, 345);
            Name_Product.Name = "Name_Product";
            Name_Product.Size = new Size(0, 32);
            Name_Product.TabIndex = 18;
            // 
            // Developer_Product
            // 
            Developer_Product.AutoSize = true;
            Developer_Product.BackColor = Color.Transparent;
            Developer_Product.Font = new Font("Segoe UI", 10F);
            Developer_Product.ForeColor = Color.FromArgb(64, 64, 64);
            Developer_Product.Location = new Point(30, 392);
            Developer_Product.Name = "Developer_Product";
            Developer_Product.Size = new Size(0, 23);
            Developer_Product.TabIndex = 19;
            // 
            // Product_Price
            // 
            Product_Price.AutoSize = true;
            Product_Price.BackColor = Color.Transparent;
            Product_Price.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            Product_Price.ForeColor = Color.FromArgb(66, 66, 176);
            Product_Price.Location = new Point(270, 418);
            Product_Price.Name = "Product_Price";
            Product_Price.Size = new Size(0, 30);
            Product_Price.TabIndex = 20;
            Product_Price.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Sign_In
            // 
            Sign_In.AutoSize = true;
            Sign_In.BackColor = Color.Transparent;
            Sign_In.Cursor = Cursors.Hand;
            Sign_In.Font = new Font("Segoe UI", 7F, FontStyle.Bold | FontStyle.Italic);
            Sign_In.ForeColor = Color.FromArgb(128, 128, 255);
            Sign_In.Location = new Point(111, 666);
            Sign_In.Name = "Sign_In";
            Sign_In.Size = new Size(60, 15);
            Sign_In.TabIndex = 22;
            Sign_In.Text = "увійдіть";
            Sign_In.Click += Sign_In_Click;
            // 
            // Log_In
            // 
            Log_In.AutoSize = true;
            Log_In.BackColor = Color.Transparent;
            Log_In.Cursor = Cursors.Hand;
            Log_In.Font = new Font("Segoe UI", 7F, FontStyle.Bold | FontStyle.Italic);
            Log_In.ForeColor = Color.FromArgb(128, 128, 255);
            Log_In.Location = new Point(200, 666);
            Log_In.Name = "Log_In";
            Log_In.Size = new Size(113, 15);
            Log_In.TabIndex = 23;
            Log_In.Text = "зареєструйтеся !";
            Log_In.Click += Log_In_Click;
            // 
            // Btn_Buy
            // 
            Btn_Buy.BackColor = Color.FromArgb(192, 192, 255);
            Btn_Buy.BackgroundImage = (Image)resources.GetObject("Btn_Buy.BackgroundImage");
            Btn_Buy.Cursor = Cursors.Hand;
            Btn_Buy.FlatAppearance.BorderSize = 0;
            Btn_Buy.FlatStyle = FlatStyle.Flat;
            Btn_Buy.Location = new Point(30, 465);
            Btn_Buy.Name = "Btn_Buy";
            Btn_Buy.Size = new Size(167, 46);
            Btn_Buy.TabIndex = 24;
            Btn_Buy.UseVisualStyleBackColor = false;
            Btn_Buy.Click += Btn_Buy_Click;
            // 
            // Btn_Map
            // 
            Btn_Map.BackColor = Color.FromArgb(192, 192, 255);
            Btn_Map.BackgroundImage = (Image)resources.GetObject("Btn_Map.BackgroundImage");
            Btn_Map.Cursor = Cursors.Hand;
            Btn_Map.FlatAppearance.BorderSize = 0;
            Btn_Map.FlatStyle = FlatStyle.Flat;
            Btn_Map.Location = new Point(199, 465);
            Btn_Map.Name = "Btn_Map";
            Btn_Map.Size = new Size(167, 46);
            Btn_Map.TabIndex = 25;
            Btn_Map.UseVisualStyleBackColor = false;
            Btn_Map.Click += Btn_Map_Click;
            // 
            // Detailed_Descr_Btn
            // 
            Detailed_Descr_Btn.BackColor = Color.FromArgb(192, 192, 255);
            Detailed_Descr_Btn.BackgroundImage = (Image)resources.GetObject("Detailed_Descr_Btn.BackgroundImage");
            Detailed_Descr_Btn.Cursor = Cursors.Hand;
            Detailed_Descr_Btn.FlatAppearance.BorderSize = 0;
            Detailed_Descr_Btn.FlatStyle = FlatStyle.Flat;
            Detailed_Descr_Btn.Location = new Point(0, 517);
            Detailed_Descr_Btn.Name = "Detailed_Descr_Btn";
            Detailed_Descr_Btn.Size = new Size(393, 58);
            Detailed_Descr_Btn.TabIndex = 26;
            Detailed_Descr_Btn.UseVisualStyleBackColor = false;
            // 
            // Info_Product_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(392, 852);
            Controls.Add(Detailed_Descr_Btn);
            Controls.Add(Btn_Map);
            Controls.Add(Btn_Buy);
            Controls.Add(Log_In);
            Controls.Add(Sign_In);
            Controls.Add(Product_Price);
            Controls.Add(Developer_Product);
            Controls.Add(Name_Product);
            Controls.Add(Img_Product_Box);
            Controls.Add(guest_home_btn);
            Controls.Add(guest_categor_btn);
            Controls.Add(btn_search);
            Controls.Add(btn_open_home);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Info_Product_Form";
            Text = "Info_Product_Form";
            Load += Info_Product_Form_Load;
            ((System.ComponentModel.ISupportInitialize)Img_Product_Box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_open_home;
        private Button btn_search;
        private Button guest_categor_btn;
        private Button guest_home_btn;
        private PictureBox Img_Product_Box;
        private Label Name_Product;
        private Label Developer_Product;
        private Label Product_Price;
        private Label Sign_In;
        private Label Log_In;
        private Button Btn_Buy;
        private Button Btn_Map;
        private Button Detailed_Descr_Btn;
    }
}