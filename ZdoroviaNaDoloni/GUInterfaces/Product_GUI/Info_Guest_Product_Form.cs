﻿using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Product_GUI
{
    public partial class Info_Guest_Product_Form : Form
    {
        private Point previousLocation;
        private readonly Product product;

        public Info_Guest_Product_Form()
        {
            InitializeComponent();
        }

        public Info_Guest_Product_Form(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private Info_Guest_Product_Form GetLocation() => this;

        private void Info_Guest_Product_Form_Load(object sender, EventArgs e)
        {
            if (product != null)
            {
                Name_Product.Text = product.Name;
                Developer_Product.Text = product.Developer;
                Product_Price.Text = product.Price.ToString();
                Img_Product_Box.Image = Image.FromFile(product.Image);
            }
        }

        private void ClearForm()
        {
            Name_Product.Text = "";
            Developer_Product.Text = "";
            Product_Price.Text = "";
            Img_Product_Box.Image = null;
        }

        private void Btn_Map_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Guest_Home_2 guestForm2 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guestForm2.Show();
            ClearForm();
            Hide();
        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Autorization_Form autorizationForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            autorizationForm.Show();
            ClearForm();
            Hide();
        }

        private void Log_In_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Registration_Form registrationForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registrationForm.Show();
            ClearForm();
            Hide();
        }

        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Info_Product_Warning_Form info_product_warning_Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            info_product_warning_Form.Show();
            ClearForm();
            Hide();
        }

        private void Detailed_Descr_Btn_Click(object sender, EventArgs e)
        {
            string productInfo = product.GetProductInfo();
            MessageBox.Show(productInfo, "Детальна інформація про товар");
        }

        private void btn_open_home_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Guest_Home_1 guest_Home_1 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guest_Home_1.Show();
            ClearForm();
            Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Search_Form searchForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            searchForm.Show();
            ClearForm();
            Hide();
        }

        private void guest_home_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Guest_Home_1 homeForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            homeForm.Show();
            ClearForm();
            Hide();
        }

        private void guest_categor_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Categories_Form categorForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            categorForm.Show();
            ClearForm();
            Hide();
        }
    }
}
