namespace ZdoroviaNaDoloni.GUInterfaces.OrderBasket_GUI
{
    partial class Order_Basket_Register_Delivery_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Basket_Register_Delivery_Form));
            Txt_Price = new Label();
            Txt_Count = new Label();
            Total_Price_Product = new Label();
            Total_Count_Product = new Label();
            Btn_Confirm = new Button();
            Btn_Check_Delivery = new Button();
            Btn_Check_Self_Pickup = new Button();
            Btn_OrderBask = new Button();
            register_home_btn = new Button();
            register_user_info_btn = new Button();
            register_categor_btn = new Button();
            Name_txt_box = new TextBox();
            Region_txt_box = new TextBox();
            City_txt_box = new TextBox();
            NumTel_txt_box = new TextBox();
            Num_NP_txt_box = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Txt_Price
            // 
            Txt_Price.AutoSize = true;
            Txt_Price.BackColor = Color.Transparent;
            Txt_Price.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            Txt_Price.Location = new Point(246, 149);
            Txt_Price.Name = "Txt_Price";
            Txt_Price.Size = new Size(54, 23);
            Txt_Price.TabIndex = 83;
            Txt_Price.Text = "Ціна:";
            // 
            // Txt_Count
            // 
            Txt_Count.AutoSize = true;
            Txt_Count.BackColor = Color.Transparent;
            Txt_Count.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            Txt_Count.Location = new Point(26, 149);
            Txt_Count.Name = "Txt_Count";
            Txt_Count.Size = new Size(96, 23);
            Txt_Count.TabIndex = 82;
            Txt_Count.Text = "Кількість:";
            // 
            // Total_Price_Product
            // 
            Total_Price_Product.AutoSize = true;
            Total_Price_Product.BackColor = Color.Transparent;
            Total_Price_Product.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Total_Price_Product.Location = new Point(309, 149);
            Total_Price_Product.Name = "Total_Price_Product";
            Total_Price_Product.Size = new Size(0, 23);
            Total_Price_Product.TabIndex = 81;
            // 
            // Total_Count_Product
            // 
            Total_Count_Product.AutoSize = true;
            Total_Count_Product.BackColor = Color.Transparent;
            Total_Count_Product.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Total_Count_Product.Location = new Point(128, 149);
            Total_Count_Product.Name = "Total_Count_Product";
            Total_Count_Product.Size = new Size(0, 23);
            Total_Count_Product.TabIndex = 80;
            // 
            // Btn_Confirm
            // 
            Btn_Confirm.BackColor = Color.Transparent;
            Btn_Confirm.BackgroundImage = (Image)resources.GetObject("Btn_Confirm.BackgroundImage");
            Btn_Confirm.Cursor = Cursors.Hand;
            Btn_Confirm.FlatAppearance.BorderSize = 0;
            Btn_Confirm.FlatStyle = FlatStyle.Flat;
            Btn_Confirm.Font = new Font("Segoe UI", 8F);
            Btn_Confirm.Location = new Point(18, 633);
            Btn_Confirm.Name = "Btn_Confirm";
            Btn_Confirm.Size = new Size(357, 36);
            Btn_Confirm.TabIndex = 79;
            Btn_Confirm.UseVisualStyleBackColor = false;
            Btn_Confirm.Click += Btn_Confirm_Click;
            // 
            // Btn_Check_Delivery
            // 
            Btn_Check_Delivery.BackColor = Color.Transparent;
            Btn_Check_Delivery.BackgroundImage = (Image)resources.GetObject("Btn_Check_Delivery.BackgroundImage");
            Btn_Check_Delivery.Cursor = Cursors.Hand;
            Btn_Check_Delivery.FlatAppearance.BorderSize = 0;
            Btn_Check_Delivery.FlatStyle = FlatStyle.Flat;
            Btn_Check_Delivery.Font = new Font("Segoe UI", 8F);
            Btn_Check_Delivery.Location = new Point(154, 185);
            Btn_Check_Delivery.Name = "Btn_Check_Delivery";
            Btn_Check_Delivery.Size = new Size(32, 32);
            Btn_Check_Delivery.TabIndex = 78;
            Btn_Check_Delivery.UseVisualStyleBackColor = false;
            // 
            // Btn_Check_Self_Pickup
            // 
            Btn_Check_Self_Pickup.BackColor = Color.Transparent;
            Btn_Check_Self_Pickup.BackgroundImage = (Image)resources.GetObject("Btn_Check_Self_Pickup.BackgroundImage");
            Btn_Check_Self_Pickup.Cursor = Cursors.Hand;
            Btn_Check_Self_Pickup.FlatAppearance.BorderSize = 0;
            Btn_Check_Self_Pickup.FlatStyle = FlatStyle.Flat;
            Btn_Check_Self_Pickup.Font = new Font("Segoe UI", 8F);
            Btn_Check_Self_Pickup.Location = new Point(19, 185);
            Btn_Check_Self_Pickup.Name = "Btn_Check_Self_Pickup";
            Btn_Check_Self_Pickup.Size = new Size(32, 32);
            Btn_Check_Self_Pickup.TabIndex = 77;
            Btn_Check_Self_Pickup.UseVisualStyleBackColor = false;
            Btn_Check_Self_Pickup.Click += Btn_Check_Self_Pickup_Click;
            // 
            // Btn_OrderBask
            // 
            Btn_OrderBask.BackColor = Color.Transparent;
            Btn_OrderBask.BackgroundImage = (Image)resources.GetObject("Btn_OrderBask.BackgroundImage");
            Btn_OrderBask.Cursor = Cursors.No;
            Btn_OrderBask.FlatAppearance.BorderSize = 0;
            Btn_OrderBask.FlatStyle = FlatStyle.Flat;
            Btn_OrderBask.Font = new Font("Segoe UI", 8F);
            Btn_OrderBask.Location = new Point(206, 705);
            Btn_OrderBask.Name = "Btn_OrderBask";
            Btn_OrderBask.Size = new Size(75, 75);
            Btn_OrderBask.TabIndex = 76;
            Btn_OrderBask.UseVisualStyleBackColor = false;
            // 
            // register_home_btn
            // 
            register_home_btn.BackColor = Color.Transparent;
            register_home_btn.BackgroundImage = (Image)resources.GetObject("register_home_btn.BackgroundImage");
            register_home_btn.Cursor = Cursors.Hand;
            register_home_btn.FlatAppearance.BorderSize = 0;
            register_home_btn.FlatStyle = FlatStyle.Flat;
            register_home_btn.Font = new Font("Segoe UI", 8F);
            register_home_btn.Location = new Point(18, 759);
            register_home_btn.Name = "register_home_btn";
            register_home_btn.Size = new Size(75, 75);
            register_home_btn.TabIndex = 75;
            register_home_btn.UseVisualStyleBackColor = false;
            register_home_btn.Click += register_home_btn_Click;
            // 
            // register_user_info_btn
            // 
            register_user_info_btn.BackColor = Color.Transparent;
            register_user_info_btn.BackgroundImage = (Image)resources.GetObject("register_user_info_btn.BackgroundImage");
            register_user_info_btn.Cursor = Cursors.Hand;
            register_user_info_btn.FlatAppearance.BorderSize = 0;
            register_user_info_btn.FlatStyle = FlatStyle.Flat;
            register_user_info_btn.Font = new Font("Segoe UI", 8F);
            register_user_info_btn.Location = new Point(300, 759);
            register_user_info_btn.Name = "register_user_info_btn";
            register_user_info_btn.Size = new Size(75, 75);
            register_user_info_btn.TabIndex = 74;
            register_user_info_btn.UseVisualStyleBackColor = false;
            register_user_info_btn.Click += register_user_info_btn_Click;
            // 
            // register_categor_btn
            // 
            register_categor_btn.BackColor = Color.Transparent;
            register_categor_btn.BackgroundImage = (Image)resources.GetObject("register_categor_btn.BackgroundImage");
            register_categor_btn.Cursor = Cursors.Hand;
            register_categor_btn.FlatAppearance.BorderSize = 0;
            register_categor_btn.FlatStyle = FlatStyle.Flat;
            register_categor_btn.Font = new Font("Segoe UI", 8F);
            register_categor_btn.Location = new Point(112, 759);
            register_categor_btn.Name = "register_categor_btn";
            register_categor_btn.Size = new Size(75, 75);
            register_categor_btn.TabIndex = 73;
            register_categor_btn.UseVisualStyleBackColor = false;
            register_categor_btn.Click += register_categor_btn_Click;
            // 
            // Name_txt_box
            // 
            Name_txt_box.BackColor = Color.FromArgb(75, 73, 180);
            Name_txt_box.BorderStyle = BorderStyle.None;
            Name_txt_box.Font = new Font("Segoe UI", 12F);
            Name_txt_box.ForeColor = Color.White;
            Name_txt_box.Location = new Point(35, 285);
            Name_txt_box.Multiline = true;
            Name_txt_box.Name = "Name_txt_box";
            Name_txt_box.Size = new Size(322, 34);
            Name_txt_box.TabIndex = 84;
            Name_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            Name_txt_box.Enter += Name_txt_box_Enter;
            Name_txt_box.Leave += Name_txt_box_Leave;
            // 
            // Region_txt_box
            // 
            Region_txt_box.BackColor = Color.FromArgb(75, 73, 180);
            Region_txt_box.BorderStyle = BorderStyle.None;
            Region_txt_box.Font = new Font("Segoe UI", 12F);
            Region_txt_box.ForeColor = Color.White;
            Region_txt_box.Location = new Point(35, 356);
            Region_txt_box.Multiline = true;
            Region_txt_box.Name = "Region_txt_box";
            Region_txt_box.Size = new Size(322, 34);
            Region_txt_box.TabIndex = 85;
            Region_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            Region_txt_box.Enter += Region_txt_box_Enter;
            Region_txt_box.Leave += Region_txt_box_Leave;
            // 
            // City_txt_box
            // 
            City_txt_box.BackColor = Color.FromArgb(75, 73, 180);
            City_txt_box.BorderStyle = BorderStyle.None;
            City_txt_box.Font = new Font("Segoe UI", 12F);
            City_txt_box.ForeColor = Color.White;
            City_txt_box.Location = new Point(35, 425);
            City_txt_box.Multiline = true;
            City_txt_box.Name = "City_txt_box";
            City_txt_box.Size = new Size(322, 34);
            City_txt_box.TabIndex = 86;
            City_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            City_txt_box.Enter += City_txt_box_Enter;
            City_txt_box.Leave += City_txt_box_Leave;
            // 
            // NumTel_txt_box
            // 
            NumTel_txt_box.BackColor = Color.FromArgb(75, 73, 180);
            NumTel_txt_box.BorderStyle = BorderStyle.None;
            NumTel_txt_box.Font = new Font("Segoe UI", 12F);
            NumTel_txt_box.ForeColor = Color.White;
            NumTel_txt_box.Location = new Point(89, 496);
            NumTel_txt_box.Multiline = true;
            NumTel_txt_box.Name = "NumTel_txt_box";
            NumTel_txt_box.Size = new Size(268, 34);
            NumTel_txt_box.TabIndex = 87;
            NumTel_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            NumTel_txt_box.Enter += NumTel_txt_box_Enter;
            NumTel_txt_box.Leave += NumTel_txt_box_Leave;
            // 
            // Num_NP_txt_box
            // 
            Num_NP_txt_box.BackColor = Color.FromArgb(75, 73, 180);
            Num_NP_txt_box.BorderStyle = BorderStyle.None;
            Num_NP_txt_box.Font = new Font("Segoe UI", 12F);
            Num_NP_txt_box.ForeColor = Color.White;
            Num_NP_txt_box.Location = new Point(35, 568);
            Num_NP_txt_box.Multiline = true;
            Num_NP_txt_box.Name = "Num_NP_txt_box";
            Num_NP_txt_box.Size = new Size(322, 34);
            Num_NP_txt_box.TabIndex = 88;
            Num_NP_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            Num_NP_txt_box.Enter += Num_NP_txt_box_Enter;
            Num_NP_txt_box.Leave += Num_NP_txt_box_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 496);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 89;
            label1.Text = "+380";
            // 
            // Order_Basket_Register_Delivery_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(392, 852);
            Controls.Add(label1);
            Controls.Add(Num_NP_txt_box);
            Controls.Add(NumTel_txt_box);
            Controls.Add(City_txt_box);
            Controls.Add(Region_txt_box);
            Controls.Add(Name_txt_box);
            Controls.Add(Txt_Price);
            Controls.Add(Txt_Count);
            Controls.Add(Total_Price_Product);
            Controls.Add(Total_Count_Product);
            Controls.Add(Btn_Confirm);
            Controls.Add(Btn_Check_Delivery);
            Controls.Add(Btn_Check_Self_Pickup);
            Controls.Add(Btn_OrderBask);
            Controls.Add(register_home_btn);
            Controls.Add(register_user_info_btn);
            Controls.Add(register_categor_btn);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order_Basket_Register_Delivery_Form";
            Text = "Order_Basket_Register_Delivery_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Txt_Price;
        private Label Txt_Count;
        private Label Total_Price_Product;
        private Label Total_Count_Product;
        private Button Btn_Confirm;
        private Button Btn_Check_Delivery;
        private Button Btn_Check_Self_Pickup;
        private Button Btn_OrderBask;
        private Button register_home_btn;
        private Button register_user_info_btn;
        private Button register_categor_btn;
        private TextBox Name_txt_box;
        private TextBox Region_txt_box;
        private TextBox City_txt_box;
        private TextBox NumTel_txt_box;
        private TextBox Num_NP_txt_box;
        private Label label1;
    }
}