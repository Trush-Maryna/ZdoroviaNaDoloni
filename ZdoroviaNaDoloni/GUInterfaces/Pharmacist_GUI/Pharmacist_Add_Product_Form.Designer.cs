namespace ZdoroviaNaDoloni.GUInterfaces.Pharmacist_GUI
{
    partial class Pharmacist_Add_Product_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist_Add_Product_Form));
            register_user_info_btn = new Button();
            register_cart_btn = new Button();
            register_home_btn = new Button();
            register_categor_btn = new Button();
            Develop_product_txt = new TextBox();
            Name_product_txt = new TextBox();
            Descr_product_txt = new TextBox();
            Price_product_txt = new TextBox();
            Pictr_product = new PictureBox();
            Btn_Add_product = new Button();
            Choice_picture = new Button();
            Quant_product_txt = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)Pictr_product).BeginInit();
            SuspendLayout();
            // 
            // register_user_info_btn
            // 
            register_user_info_btn.BackColor = Color.Transparent;
            register_user_info_btn.BackgroundImage = (Image)resources.GetObject("register_user_info_btn.BackgroundImage");
            register_user_info_btn.Cursor = Cursors.Hand;
            register_user_info_btn.FlatAppearance.BorderSize = 0;
            register_user_info_btn.FlatStyle = FlatStyle.Flat;
            register_user_info_btn.Font = new Font("Segoe UI", 8F);
            register_user_info_btn.Location = new Point(298, 754);
            register_user_info_btn.Name = "register_user_info_btn";
            register_user_info_btn.Size = new Size(75, 75);
            register_user_info_btn.TabIndex = 51;
            register_user_info_btn.UseVisualStyleBackColor = false;
            register_user_info_btn.Click += pharm_user_info_btn_Click;
            // 
            // register_cart_btn
            // 
            register_cart_btn.BackColor = Color.Transparent;
            register_cart_btn.BackgroundImage = (Image)resources.GetObject("register_cart_btn.BackgroundImage");
            register_cart_btn.Cursor = Cursors.No;
            register_cart_btn.FlatAppearance.BorderSize = 0;
            register_cart_btn.FlatStyle = FlatStyle.Flat;
            register_cart_btn.Font = new Font("Segoe UI", 8F);
            register_cart_btn.Location = new Point(204, 754);
            register_cart_btn.Name = "register_cart_btn";
            register_cart_btn.Size = new Size(75, 75);
            register_cart_btn.TabIndex = 50;
            register_cart_btn.UseVisualStyleBackColor = false;
            // 
            // register_home_btn
            // 
            register_home_btn.BackColor = Color.Transparent;
            register_home_btn.BackgroundImage = (Image)resources.GetObject("register_home_btn.BackgroundImage");
            register_home_btn.Cursor = Cursors.Hand;
            register_home_btn.FlatAppearance.BorderSize = 0;
            register_home_btn.FlatStyle = FlatStyle.Flat;
            register_home_btn.Location = new Point(16, 754);
            register_home_btn.Name = "register_home_btn";
            register_home_btn.Size = new Size(75, 75);
            register_home_btn.TabIndex = 49;
            register_home_btn.UseVisualStyleBackColor = false;
            register_home_btn.Click += pharm_home_btn_Click;
            // 
            // register_categor_btn
            // 
            register_categor_btn.BackColor = Color.Transparent;
            register_categor_btn.BackgroundImage = (Image)resources.GetObject("register_categor_btn.BackgroundImage");
            register_categor_btn.Cursor = Cursors.Hand;
            register_categor_btn.FlatAppearance.BorderSize = 0;
            register_categor_btn.FlatStyle = FlatStyle.Flat;
            register_categor_btn.Font = new Font("Segoe UI", 8F);
            register_categor_btn.Location = new Point(110, 754);
            register_categor_btn.Name = "register_categor_btn";
            register_categor_btn.Size = new Size(75, 75);
            register_categor_btn.TabIndex = 48;
            register_categor_btn.UseVisualStyleBackColor = false;
            register_categor_btn.Click += pharm_categor_btn_Click;
            // 
            // Develop_product_txt
            // 
            Develop_product_txt.BackColor = Color.FromArgb(75, 73, 180);
            Develop_product_txt.BorderStyle = BorderStyle.None;
            Develop_product_txt.Font = new Font("Segoe UI", 12F);
            Develop_product_txt.Location = new Point(36, 262);
            Develop_product_txt.Multiline = true;
            Develop_product_txt.Name = "Develop_product_txt";
            Develop_product_txt.Size = new Size(322, 34);
            Develop_product_txt.TabIndex = 87;
            // 
            // Name_product_txt
            // 
            Name_product_txt.BackColor = Color.FromArgb(75, 73, 180);
            Name_product_txt.BorderStyle = BorderStyle.None;
            Name_product_txt.Font = new Font("Segoe UI", 12F);
            Name_product_txt.Location = new Point(36, 191);
            Name_product_txt.Multiline = true;
            Name_product_txt.Name = "Name_product_txt";
            Name_product_txt.Size = new Size(322, 34);
            Name_product_txt.TabIndex = 86;
            // 
            // Descr_product_txt
            // 
            Descr_product_txt.BackColor = Color.FromArgb(75, 73, 180);
            Descr_product_txt.BorderStyle = BorderStyle.None;
            Descr_product_txt.Font = new Font("Segoe UI", 12F);
            Descr_product_txt.Location = new Point(35, 336);
            Descr_product_txt.Multiline = true;
            Descr_product_txt.Name = "Descr_product_txt";
            Descr_product_txt.Size = new Size(322, 122);
            Descr_product_txt.TabIndex = 88;
            // 
            // Price_product_txt
            // 
            Price_product_txt.BackColor = Color.FromArgb(75, 73, 180);
            Price_product_txt.BorderStyle = BorderStyle.None;
            Price_product_txt.Font = new Font("Segoe UI", 12F);
            Price_product_txt.Location = new Point(35, 498);
            Price_product_txt.Multiline = true;
            Price_product_txt.Name = "Price_product_txt";
            Price_product_txt.Size = new Size(141, 34);
            Price_product_txt.TabIndex = 89;
            // 
            // Pictr_product
            // 
            Pictr_product.BackColor = Color.Transparent;
            Pictr_product.Location = new Point(35, 565);
            Pictr_product.Name = "Pictr_product";
            Pictr_product.Size = new Size(190, 85);
            Pictr_product.SizeMode = PictureBoxSizeMode.Zoom;
            Pictr_product.TabIndex = 90;
            Pictr_product.TabStop = false;
            // 
            // Btn_Add_product
            // 
            Btn_Add_product.BackColor = Color.Transparent;
            Btn_Add_product.BackgroundImage = (Image)resources.GetObject("Btn_Add_product.BackgroundImage");
            Btn_Add_product.Cursor = Cursors.Hand;
            Btn_Add_product.FlatAppearance.BorderSize = 0;
            Btn_Add_product.FlatStyle = FlatStyle.Flat;
            Btn_Add_product.Location = new Point(62, 679);
            Btn_Add_product.Name = "Btn_Add_product";
            Btn_Add_product.Size = new Size(270, 38);
            Btn_Add_product.TabIndex = 91;
            Btn_Add_product.UseVisualStyleBackColor = false;
            Btn_Add_product.Click += Btn_Add_product_Click;
            // 
            // Choice_picture
            // 
            Choice_picture.BackColor = Color.Transparent;
            Choice_picture.BackgroundImage = (Image)resources.GetObject("Choice_picture.BackgroundImage");
            Choice_picture.Cursor = Cursors.Hand;
            Choice_picture.FlatAppearance.BorderSize = 0;
            Choice_picture.FlatStyle = FlatStyle.Flat;
            Choice_picture.Location = new Point(246, 582);
            Choice_picture.Name = "Choice_picture";
            Choice_picture.Size = new Size(114, 38);
            Choice_picture.TabIndex = 92;
            Choice_picture.UseVisualStyleBackColor = false;
            Choice_picture.Click += Choice_picture_Click;
            // 
            // Quant_product_txt
            // 
            Quant_product_txt.BackColor = Color.FromArgb(75, 73, 180);
            Quant_product_txt.BorderStyle = BorderStyle.None;
            Quant_product_txt.Font = new Font("Segoe UI", 12F);
            Quant_product_txt.Location = new Point(216, 498);
            Quant_product_txt.Multiline = true;
            Quant_product_txt.Name = "Quant_product_txt";
            Quant_product_txt.Size = new Size(141, 34);
            Quant_product_txt.TabIndex = 93;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Pharmacist_Add_Product_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(392, 852);
            Controls.Add(Quant_product_txt);
            Controls.Add(Choice_picture);
            Controls.Add(Btn_Add_product);
            Controls.Add(Pictr_product);
            Controls.Add(Price_product_txt);
            Controls.Add(Descr_product_txt);
            Controls.Add(Develop_product_txt);
            Controls.Add(Name_product_txt);
            Controls.Add(register_user_info_btn);
            Controls.Add(register_cart_btn);
            Controls.Add(register_home_btn);
            Controls.Add(register_categor_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pharmacist_Add_Product_Form";
            Text = "Pharmacist_Add_Product_Form";
            ((System.ComponentModel.ISupportInitialize)Pictr_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button register_user_info_btn;
        private Button register_cart_btn;
        private Button register_home_btn;
        private Button register_categor_btn;
        private TextBox Develop_product_txt;
        private TextBox Name_product_txt;
        private TextBox Descr_product_txt;
        private TextBox Price_product_txt;
        private PictureBox Pictr_product;
        private Button Btn_Add_product;
        private Button Choice_picture;
        private TextBox Quant_product_txt;
        private OpenFileDialog openFileDialog1;
    }
}