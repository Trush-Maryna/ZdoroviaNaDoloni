﻿namespace ZdoroviaNaDoloni.GUInterfaces.Guest_GUI
{
    partial class Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            btn_number = new Button();
            Btn_pass = new Button();
            Btn_Check = new Button();
            Btn_Eye = new Button();
            Btn_Log_In = new Button();
            Btn_Sign_In = new Button();
            Phone_Numder_txt = new TextBox();
            Pass_txt = new TextBox();
            X = new Label();
            conditions_rules_txt = new Label();
            SuspendLayout();
            // 
            // btn_number
            // 
            btn_number.BackColor = Color.FromArgb(192, 192, 255);
            btn_number.BackgroundImage = (Image)resources.GetObject("btn_number.BackgroundImage");
            btn_number.Cursor = Cursors.Hand;
            btn_number.FlatAppearance.BorderSize = 0;
            btn_number.FlatStyle = FlatStyle.Flat;
            btn_number.Location = new Point(163, 153);
            btn_number.Name = "btn_number";
            btn_number.Size = new Size(188, 44);
            btn_number.TabIndex = 14;
            btn_number.UseVisualStyleBackColor = false;
            // 
            // Btn_pass
            // 
            Btn_pass.BackColor = Color.FromArgb(192, 192, 255);
            Btn_pass.BackgroundImage = (Image)resources.GetObject("Btn_pass.BackgroundImage");
            Btn_pass.Cursor = Cursors.Hand;
            Btn_pass.FlatAppearance.BorderSize = 0;
            Btn_pass.FlatStyle = FlatStyle.Flat;
            Btn_pass.Location = new Point(41, 266);
            Btn_pass.Name = "Btn_pass";
            Btn_pass.Size = new Size(310, 44);
            Btn_pass.TabIndex = 15;
            Btn_pass.UseVisualStyleBackColor = false;
            // 
            // Btn_Check
            // 
            Btn_Check.BackColor = Color.FromArgb(192, 192, 255);
            Btn_Check.BackgroundImage = (Image)resources.GetObject("Btn_Check.BackgroundImage");
            Btn_Check.Cursor = Cursors.Hand;
            Btn_Check.FlatAppearance.BorderSize = 0;
            Btn_Check.FlatStyle = FlatStyle.Flat;
            Btn_Check.Location = new Point(41, 334);
            Btn_Check.Name = "Btn_Check";
            Btn_Check.Size = new Size(35, 36);
            Btn_Check.TabIndex = 16;
            Btn_Check.UseVisualStyleBackColor = false;
            Btn_Check.Click += Btn_Check_Click;
            // 
            // Btn_Eye
            // 
            Btn_Eye.BackColor = Color.FromArgb(192, 192, 255);
            Btn_Eye.BackgroundImage = (Image)resources.GetObject("Btn_Eye.BackgroundImage");
            Btn_Eye.Cursor = Cursors.Hand;
            Btn_Eye.FlatAppearance.BorderSize = 0;
            Btn_Eye.FlatStyle = FlatStyle.Flat;
            Btn_Eye.Location = new Point(309, 273);
            Btn_Eye.Name = "Btn_Eye";
            Btn_Eye.Size = new Size(32, 31);
            Btn_Eye.TabIndex = 17;
            Btn_Eye.UseVisualStyleBackColor = false;
            Btn_Eye.Click += Btn_Eye_Click;
            // 
            // Btn_Log_In
            // 
            Btn_Log_In.BackColor = Color.FromArgb(192, 192, 255);
            Btn_Log_In.BackgroundImage = (Image)resources.GetObject("Btn_Log_In.BackgroundImage");
            Btn_Log_In.Cursor = Cursors.Hand;
            Btn_Log_In.FlatAppearance.BorderSize = 0;
            Btn_Log_In.FlatStyle = FlatStyle.Flat;
            Btn_Log_In.Location = new Point(42, 557);
            Btn_Log_In.Name = "Btn_Log_In";
            Btn_Log_In.Size = new Size(309, 63);
            Btn_Log_In.TabIndex = 18;
            Btn_Log_In.UseVisualStyleBackColor = false;
            Btn_Log_In.Click += Btn_Log_In_Click;
            // 
            // Btn_Sign_In
            // 
            Btn_Sign_In.BackColor = Color.FromArgb(192, 192, 255);
            Btn_Sign_In.BackgroundImage = (Image)resources.GetObject("Btn_Sign_In.BackgroundImage");
            Btn_Sign_In.Cursor = Cursors.Hand;
            Btn_Sign_In.FlatAppearance.BorderSize = 0;
            Btn_Sign_In.FlatStyle = FlatStyle.Flat;
            Btn_Sign_In.Location = new Point(70, 636);
            Btn_Sign_In.Name = "Btn_Sign_In";
            Btn_Sign_In.Size = new Size(252, 29);
            Btn_Sign_In.TabIndex = 19;
            Btn_Sign_In.UseVisualStyleBackColor = false;
            Btn_Sign_In.Click += Btn_Sign_In_Click;
            // 
            // Phone_Numder_txt
            // 
            Phone_Numder_txt.BackColor = Color.FromArgb(248, 247, 252);
            Phone_Numder_txt.BorderStyle = BorderStyle.None;
            Phone_Numder_txt.Cursor = Cursors.Hand;
            Phone_Numder_txt.Font = new Font("Segoe UI", 13F);
            Phone_Numder_txt.ForeColor = Color.Black;
            Phone_Numder_txt.Location = new Point(181, 155);
            Phone_Numder_txt.Multiline = true;
            Phone_Numder_txt.Name = "Phone_Numder_txt";
            Phone_Numder_txt.Size = new Size(164, 40);
            Phone_Numder_txt.TabIndex = 20;
            Phone_Numder_txt.Text = "_ _ _ _  _ _  _ _ _";
            Phone_Numder_txt.Enter += Phone_Numder_txt_Enter;
            Phone_Numder_txt.Leave += Phone_Numder_txt_Leave;
            // 
            // Pass_txt
            // 
            Pass_txt.BackColor = Color.FromArgb(248, 247, 252);
            Pass_txt.BorderStyle = BorderStyle.None;
            Pass_txt.Cursor = Cursors.Hand;
            Pass_txt.Font = new Font("Segoe UI", 13F);
            Pass_txt.ForeColor = Color.Black;
            Pass_txt.Location = new Point(54, 270);
            Pass_txt.Multiline = true;
            Pass_txt.Name = "Pass_txt";
            Pass_txt.Size = new Size(252, 35);
            Pass_txt.TabIndex = 21;
            Pass_txt.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            Pass_txt.TextChanged += Pass_txt_TextChanged;
            Pass_txt.Enter += Pass_txt_Enter;
            Pass_txt.Leave += Pass_txt_Leave;
            // 
            // X
            // 
            X.AutoSize = true;
            X.BackColor = Color.Transparent;
            X.Cursor = Cursors.Hand;
            X.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            X.Location = new Point(349, 9);
            X.Name = "X";
            X.Size = new Size(31, 35);
            X.TabIndex = 22;
            X.Text = "X";
            X.Click += X_Click;
            // 
            // conditions_rules_txt
            // 
            conditions_rules_txt.AutoSize = true;
            conditions_rules_txt.BackColor = Color.FromArgb(120, 120, 184);
            conditions_rules_txt.Cursor = Cursors.Hand;
            conditions_rules_txt.Font = new Font("Segoe UI", 7F, FontStyle.Underline);
            conditions_rules_txt.ForeColor = Color.White;
            conditions_rules_txt.Location = new Point(85, 357);
            conditions_rules_txt.Name = "conditions_rules_txt";
            conditions_rules_txt.Size = new Size(139, 15);
            conditions_rules_txt.TabIndex = 23;
            conditions_rules_txt.Text = "Умовами та Правилами";
            conditions_rules_txt.Click += conditions_rules_txt_Click;
            // 
            // Registration_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(392, 852);
            Controls.Add(conditions_rules_txt);
            Controls.Add(X);
            Controls.Add(Pass_txt);
            Controls.Add(Phone_Numder_txt);
            Controls.Add(Btn_Sign_In);
            Controls.Add(Btn_Log_In);
            Controls.Add(Btn_Eye);
            Controls.Add(Btn_Check);
            Controls.Add(Btn_pass);
            Controls.Add(btn_number);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registration_Form";
            Text = "Registration_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_number;
        private Button Btn_pass;
        private Button Btn_Check;
        private Button Btn_Eye;
        private Button Btn_Log_In;
        private Button Btn_Sign_In;
        private TextBox Phone_Numder_txt;
        private TextBox Pass_txt;
        private Label X;
        private Label conditions_rules_txt;
    }
}