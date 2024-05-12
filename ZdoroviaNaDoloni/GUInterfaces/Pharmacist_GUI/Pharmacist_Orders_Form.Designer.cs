namespace ZdoroviaNaDoloni.GUInterfaces.Pharmacist_GUI
{
    partial class Pharmacist_Orders_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist_Orders_Form));
            register_user_info_btn = new Button();
            register_cart_btn = new Button();
            register_home_btn = new Button();
            register_categor_btn = new Button();
            Orders_Box = new ListBox();
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
            register_user_info_btn.Location = new Point(300, 761);
            register_user_info_btn.Name = "register_user_info_btn";
            register_user_info_btn.Size = new Size(75, 75);
            register_user_info_btn.TabIndex = 43;
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
            register_cart_btn.Location = new Point(206, 761);
            register_cart_btn.Name = "register_cart_btn";
            register_cart_btn.Size = new Size(75, 75);
            register_cart_btn.TabIndex = 42;
            register_cart_btn.UseVisualStyleBackColor = false;
            // 
            // register_home_btn
            // 
            register_home_btn.BackColor = Color.Transparent;
            register_home_btn.BackgroundImage = (Image)resources.GetObject("register_home_btn.BackgroundImage");
            register_home_btn.Cursor = Cursors.Hand;
            register_home_btn.FlatAppearance.BorderSize = 0;
            register_home_btn.FlatStyle = FlatStyle.Flat;
            register_home_btn.Location = new Point(18, 761);
            register_home_btn.Name = "register_home_btn";
            register_home_btn.Size = new Size(75, 75);
            register_home_btn.TabIndex = 41;
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
            register_categor_btn.Location = new Point(112, 761);
            register_categor_btn.Name = "register_categor_btn";
            register_categor_btn.Size = new Size(75, 75);
            register_categor_btn.TabIndex = 40;
            register_categor_btn.UseVisualStyleBackColor = false;
            register_categor_btn.Click += pharm_categor_btn_Click;
            // 
            // Orders_Box
            // 
            Orders_Box.BackColor = Color.FromArgb(217, 217, 217);
            Orders_Box.BorderStyle = BorderStyle.None;
            Orders_Box.Font = new Font("Segoe UI", 12F);
            Orders_Box.FormattingEnabled = true;
            Orders_Box.ItemHeight = 28;
            Orders_Box.Location = new Point(44, 149);
            Orders_Box.Name = "Orders_Box";
            Orders_Box.Size = new Size(301, 560);
            Orders_Box.TabIndex = 44;
            Orders_Box.SelectedIndexChanged += Orders_Box_SelectedIndexChanged;
            // 
            // Pharmacist_Orders_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(392, 852);
            Controls.Add(Orders_Box);
            Controls.Add(register_user_info_btn);
            Controls.Add(register_cart_btn);
            Controls.Add(register_home_btn);
            Controls.Add(register_categor_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pharmacist_Orders_Form";
            Text = "Pharmacist_Orders_Form";
            Load += Pharmacist_Orders_Form_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button register_user_info_btn;
        private Button register_cart_btn;
        private Button register_home_btn;
        private Button register_categor_btn;
        private ListBox Orders_Box;
    }
}