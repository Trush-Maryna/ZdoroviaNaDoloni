namespace ZdoroviaNaDoloni.GUInterfaces.Pharmacist_GUI
{
    partial class Pharmacist_Products_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist_Products_Form));
            Txt_Search = new TextBox();
            Btn_Search = new Button();
            SearchResults = new ListBox();
            pharm_user_info_btn = new Button();
            pharm_cart_btn = new Button();
            pharm_home_btn = new Button();
            pharm_categor_btn = new Button();
            Btn_Add_product = new Button();
            SuspendLayout();
            // 
            // Txt_Search
            // 
            Txt_Search.BackColor = Color.FromArgb(66, 66, 176);
            Txt_Search.BorderStyle = BorderStyle.None;
            Txt_Search.Font = new Font("Segoe UI", 12F);
            Txt_Search.ForeColor = Color.White;
            Txt_Search.Location = new Point(76, 185);
            Txt_Search.Multiline = true;
            Txt_Search.Name = "Txt_Search";
            Txt_Search.Size = new Size(284, 41);
            Txt_Search.TabIndex = 12;
            Txt_Search.Text = "Введіть запит ...";
            Txt_Search.Click += Txt_Search_Click;
            Txt_Search.TextChanged += Txt_Search_TextChanged;
            // 
            // Btn_Search
            // 
            Btn_Search.BackColor = Color.Transparent;
            Btn_Search.BackgroundImage = (Image)resources.GetObject("Btn_Search.BackgroundImage");
            Btn_Search.Cursor = Cursors.Hand;
            Btn_Search.FlatAppearance.BorderSize = 0;
            Btn_Search.FlatStyle = FlatStyle.Flat;
            Btn_Search.Location = new Point(31, 176);
            Btn_Search.Name = "Btn_Search";
            Btn_Search.Size = new Size(334, 55);
            Btn_Search.TabIndex = 11;
            Btn_Search.UseVisualStyleBackColor = false;
            // 
            // SearchResults
            // 
            SearchResults.BackColor = Color.FromArgb(217, 217, 217);
            SearchResults.BorderStyle = BorderStyle.None;
            SearchResults.Cursor = Cursors.Hand;
            SearchResults.Font = new Font("Segoe UI", 10F);
            SearchResults.FormattingEnabled = true;
            SearchResults.ItemHeight = 23;
            SearchResults.Location = new Point(40, 254);
            SearchResults.Name = "SearchResults";
            SearchResults.Size = new Size(310, 460);
            SearchResults.TabIndex = 13;
            SearchResults.Visible = false;
            SearchResults.SelectedIndexChanged += SearchResults_SelectedIndexChanged;
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
            pharm_user_info_btn.TabIndex = 47;
            pharm_user_info_btn.UseVisualStyleBackColor = false;
            pharm_user_info_btn.Click += pharm_user_info_btn_Click;
            // 
            // pharm_cart_btn
            // 
            pharm_cart_btn.BackColor = Color.Transparent;
            pharm_cart_btn.BackgroundImage = (Image)resources.GetObject("pharm_cart_btn.BackgroundImage");
            pharm_cart_btn.Cursor = Cursors.No;
            pharm_cart_btn.FlatAppearance.BorderSize = 0;
            pharm_cart_btn.FlatStyle = FlatStyle.Flat;
            pharm_cart_btn.Font = new Font("Segoe UI", 8F);
            pharm_cart_btn.Location = new Point(206, 761);
            pharm_cart_btn.Name = "pharm_cart_btn";
            pharm_cart_btn.Size = new Size(75, 75);
            pharm_cart_btn.TabIndex = 46;
            pharm_cart_btn.UseVisualStyleBackColor = false;
            // 
            // pharm_home_btn
            // 
            pharm_home_btn.BackColor = Color.Transparent;
            pharm_home_btn.BackgroundImage = (Image)resources.GetObject("pharm_home_btn.BackgroundImage");
            pharm_home_btn.Cursor = Cursors.Hand;
            pharm_home_btn.FlatAppearance.BorderSize = 0;
            pharm_home_btn.FlatStyle = FlatStyle.Flat;
            pharm_home_btn.Location = new Point(18, 761);
            pharm_home_btn.Name = "pharm_home_btn";
            pharm_home_btn.Size = new Size(75, 75);
            pharm_home_btn.TabIndex = 45;
            pharm_home_btn.UseVisualStyleBackColor = false;
            pharm_home_btn.Click += pharm_home_btn_Click;
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
            pharm_categor_btn.TabIndex = 44;
            pharm_categor_btn.UseVisualStyleBackColor = false;
            pharm_categor_btn.Click += pharm_categor_btn_Click;
            // 
            // Btn_Add_product
            // 
            Btn_Add_product.BackColor = Color.Transparent;
            Btn_Add_product.BackgroundImage = (Image)resources.GetObject("Btn_Add_product.BackgroundImage");
            Btn_Add_product.Cursor = Cursors.Hand;
            Btn_Add_product.FlatAppearance.BorderSize = 0;
            Btn_Add_product.FlatStyle = FlatStyle.Flat;
            Btn_Add_product.Location = new Point(63, 128);
            Btn_Add_product.Name = "Btn_Add_product";
            Btn_Add_product.Size = new Size(271, 38);
            Btn_Add_product.TabIndex = 48;
            Btn_Add_product.UseVisualStyleBackColor = false;
            Btn_Add_product.Click += Btn_Add_product_Click;
            // 
            // Pharmacist_Products_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(392, 852);
            Controls.Add(Btn_Add_product);
            Controls.Add(pharm_user_info_btn);
            Controls.Add(pharm_cart_btn);
            Controls.Add(pharm_home_btn);
            Controls.Add(pharm_categor_btn);
            Controls.Add(Txt_Search);
            Controls.Add(Btn_Search);
            Controls.Add(SearchResults);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pharmacist_Products_Form";
            Text = "Pharmacist_Products_Form";
            Load += Pharmacist_Products_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Search;
        private Button Btn_Search;
        private ListBox SearchResults;
        private Button pharm_user_info_btn;
        private Button pharm_cart_btn;
        private Button pharm_home_btn;
        private Button pharm_categor_btn;
        private Button Btn_Add_product;
    }
}