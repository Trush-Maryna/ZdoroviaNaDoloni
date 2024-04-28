namespace ZdoroviaNaDoloni.GUInterfaces.Product_GUI
{
    partial class Info_Product_Warning_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Product_Warning_Form));
            btn_open_home = new Button();
            guest_home_btn = new Button();
            guest_categor_btn = new Button();
            Sign_In = new Label();
            Log_In = new Label();
            Btn_tg = new Button();
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
            btn_open_home.TabIndex = 2;
            btn_open_home.UseVisualStyleBackColor = false;
            btn_open_home.Click += btn_open_home_Click;
            // 
            // guest_home_btn
            // 
            guest_home_btn.BackColor = Color.Transparent;
            guest_home_btn.BackgroundImage = (Image)resources.GetObject("guest_home_btn.BackgroundImage");
            guest_home_btn.Cursor = Cursors.Hand;
            guest_home_btn.FlatAppearance.BorderSize = 0;
            guest_home_btn.FlatStyle = FlatStyle.Flat;
            guest_home_btn.Location = new Point(112, 760);
            guest_home_btn.Name = "guest_home_btn";
            guest_home_btn.Size = new Size(75, 75);
            guest_home_btn.TabIndex = 18;
            guest_home_btn.UseVisualStyleBackColor = false;
            guest_home_btn.Click += guest_home_btn_Click;
            // 
            // guest_categor_btn
            // 
            guest_categor_btn.BackColor = Color.Transparent;
            guest_categor_btn.BackgroundImage = (Image)resources.GetObject("guest_categor_btn.BackgroundImage");
            guest_categor_btn.Cursor = Cursors.Hand;
            guest_categor_btn.FlatAppearance.BorderSize = 0;
            guest_categor_btn.FlatStyle = FlatStyle.Flat;
            guest_categor_btn.Font = new Font("Segoe UI", 8F);
            guest_categor_btn.Location = new Point(205, 760);
            guest_categor_btn.Name = "guest_categor_btn";
            guest_categor_btn.Size = new Size(75, 75);
            guest_categor_btn.TabIndex = 17;
            guest_categor_btn.UseVisualStyleBackColor = false;
            guest_categor_btn.Click += guest_categor_btn_Click;
            // 
            // Sign_In
            // 
            Sign_In.AutoSize = true;
            Sign_In.BackColor = Color.Transparent;
            Sign_In.Cursor = Cursors.Hand;
            Sign_In.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            Sign_In.ForeColor = Color.White;
            Sign_In.Location = new Point(102, 410);
            Sign_In.Name = "Sign_In";
            Sign_In.Size = new Size(79, 20);
            Sign_In.TabIndex = 23;
            Sign_In.Text = "увійдіть,";
            Sign_In.Click += Sign_In_Click;
            // 
            // Log_In
            // 
            Log_In.AutoSize = true;
            Log_In.BackColor = Color.Transparent;
            Log_In.Cursor = Cursors.Hand;
            Log_In.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            Log_In.ForeColor = Color.White;
            Log_In.Location = new Point(180, 410);
            Log_In.Name = "Log_In";
            Log_In.Size = new Size(134, 20);
            Log_In.TabIndex = 24;
            Log_In.Text = "зареєструйтеся";
            Log_In.Click += Log_In_Click;
            // 
            // Btn_tg
            // 
            Btn_tg.BackColor = Color.Transparent;
            Btn_tg.BackgroundImage = (Image)resources.GetObject("Btn_tg.BackgroundImage");
            Btn_tg.Cursor = Cursors.Hand;
            Btn_tg.FlatAppearance.BorderSize = 0;
            Btn_tg.FlatStyle = FlatStyle.Flat;
            Btn_tg.Location = new Point(76, 458);
            Btn_tg.Name = "Btn_tg";
            Btn_tg.Size = new Size(242, 55);
            Btn_tg.TabIndex = 25;
            Btn_tg.UseVisualStyleBackColor = false;
            Btn_tg.Click += Btn_tg_Click;
            // 
            // Info_Product_Warning_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(392, 852);
            Controls.Add(Btn_tg);
            Controls.Add(Log_In);
            Controls.Add(Sign_In);
            Controls.Add(guest_home_btn);
            Controls.Add(guest_categor_btn);
            Controls.Add(btn_open_home);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Info_Product_Warning_Form";
            Text = "Info_Product_Warning_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_open_home;
        private Button guest_home_btn;
        private Button guest_categor_btn;
        private Label Sign_In;
        private Label Log_In;
        private Button Btn_tg;
    }
}