namespace ZdoroviaNaDoloni.GUInterfaces.OrderBasket_GUI
{
    partial class Order_Basket_Register_SelfPickup_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Basket_Register_SelfPickup_Form));
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
            mapBox = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)mapBox).BeginInit();
            SuspendLayout();
            // 
            // Txt_Price
            // 
            Txt_Price.AutoSize = true;
            Txt_Price.BackColor = Color.Transparent;
            Txt_Price.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            Txt_Price.Location = new Point(246, 151);
            Txt_Price.Name = "Txt_Price";
            Txt_Price.Size = new Size(54, 23);
            Txt_Price.TabIndex = 72;
            Txt_Price.Text = "Ціна:";
            // 
            // Txt_Count
            // 
            Txt_Count.AutoSize = true;
            Txt_Count.BackColor = Color.Transparent;
            Txt_Count.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            Txt_Count.Location = new Point(26, 151);
            Txt_Count.Name = "Txt_Count";
            Txt_Count.Size = new Size(96, 23);
            Txt_Count.TabIndex = 71;
            Txt_Count.Text = "Кількість:";
            // 
            // Total_Price_Product
            // 
            Total_Price_Product.AutoSize = true;
            Total_Price_Product.BackColor = Color.Transparent;
            Total_Price_Product.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Total_Price_Product.Location = new Point(309, 151);
            Total_Price_Product.Name = "Total_Price_Product";
            Total_Price_Product.Size = new Size(0, 23);
            Total_Price_Product.TabIndex = 70;
            // 
            // Total_Count_Product
            // 
            Total_Count_Product.AutoSize = true;
            Total_Count_Product.BackColor = Color.Transparent;
            Total_Count_Product.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Total_Count_Product.Location = new Point(128, 151);
            Total_Count_Product.Name = "Total_Count_Product";
            Total_Count_Product.Size = new Size(0, 23);
            Total_Count_Product.TabIndex = 69;
            // 
            // Btn_Confirm
            // 
            Btn_Confirm.BackColor = Color.Transparent;
            Btn_Confirm.BackgroundImage = (Image)resources.GetObject("Btn_Confirm.BackgroundImage");
            Btn_Confirm.Cursor = Cursors.Hand;
            Btn_Confirm.FlatAppearance.BorderSize = 0;
            Btn_Confirm.FlatStyle = FlatStyle.Flat;
            Btn_Confirm.Font = new Font("Segoe UI", 8F);
            Btn_Confirm.Location = new Point(18, 635);
            Btn_Confirm.Name = "Btn_Confirm";
            Btn_Confirm.Size = new Size(357, 36);
            Btn_Confirm.TabIndex = 68;
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
            Btn_Check_Delivery.Location = new Point(154, 187);
            Btn_Check_Delivery.Name = "Btn_Check_Delivery";
            Btn_Check_Delivery.Size = new Size(32, 32);
            Btn_Check_Delivery.TabIndex = 67;
            Btn_Check_Delivery.UseVisualStyleBackColor = false;
            Btn_Check_Delivery.Click += Btn_Check_Delivery_Click;
            // 
            // Btn_Check_Self_Pickup
            // 
            Btn_Check_Self_Pickup.BackColor = Color.Transparent;
            Btn_Check_Self_Pickup.BackgroundImage = (Image)resources.GetObject("Btn_Check_Self_Pickup.BackgroundImage");
            Btn_Check_Self_Pickup.Cursor = Cursors.Hand;
            Btn_Check_Self_Pickup.FlatAppearance.BorderSize = 0;
            Btn_Check_Self_Pickup.FlatStyle = FlatStyle.Flat;
            Btn_Check_Self_Pickup.Font = new Font("Segoe UI", 8F);
            Btn_Check_Self_Pickup.Location = new Point(19, 187);
            Btn_Check_Self_Pickup.Name = "Btn_Check_Self_Pickup";
            Btn_Check_Self_Pickup.Size = new Size(32, 32);
            Btn_Check_Self_Pickup.TabIndex = 66;
            Btn_Check_Self_Pickup.UseVisualStyleBackColor = false;
            // 
            // Btn_OrderBask
            // 
            Btn_OrderBask.BackColor = Color.Transparent;
            Btn_OrderBask.BackgroundImage = (Image)resources.GetObject("Btn_OrderBask.BackgroundImage");
            Btn_OrderBask.Cursor = Cursors.No;
            Btn_OrderBask.FlatAppearance.BorderSize = 0;
            Btn_OrderBask.FlatStyle = FlatStyle.Flat;
            Btn_OrderBask.Font = new Font("Segoe UI", 8F);
            Btn_OrderBask.Location = new Point(206, 707);
            Btn_OrderBask.Name = "Btn_OrderBask";
            Btn_OrderBask.Size = new Size(75, 75);
            Btn_OrderBask.TabIndex = 65;
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
            register_home_btn.Location = new Point(18, 761);
            register_home_btn.Name = "register_home_btn";
            register_home_btn.Size = new Size(75, 75);
            register_home_btn.TabIndex = 64;
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
            register_user_info_btn.Location = new Point(300, 761);
            register_user_info_btn.Name = "register_user_info_btn";
            register_user_info_btn.Size = new Size(75, 75);
            register_user_info_btn.TabIndex = 63;
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
            register_categor_btn.Location = new Point(112, 761);
            register_categor_btn.Name = "register_categor_btn";
            register_categor_btn.Size = new Size(75, 75);
            register_categor_btn.TabIndex = 62;
            register_categor_btn.UseVisualStyleBackColor = false;
            register_categor_btn.Click += register_categor_btn_Click;
            // 
            // mapBox
            // 
            mapBox.BackColor = Color.Transparent;
            mapBox.BorderStyle = BorderStyle.Fixed3D;
            mapBox.Location = new Point(26, 280);
            mapBox.Name = "mapBox";
            mapBox.Size = new Size(341, 338);
            mapBox.TabIndex = 73;
            mapBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(21, 248);
            label1.Name = "label1";
            label1.Size = new Size(354, 20);
            label1.TabIndex = 74;
            label1.Text = "Оберіть аптеку для отримання замовлення:";
            // 
            // Order_Basket_Register_SelfPickup_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(392, 852);
            Controls.Add(label1);
            Controls.Add(mapBox);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order_Basket_Register_SelfPickup_Form";
            Text = "Order_Basket_Register_SelfPickup_Form";
            ((System.ComponentModel.ISupportInitialize)mapBox).EndInit();
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
        private PictureBox mapBox;
        private Label label1;
    }
}