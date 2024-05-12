﻿using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
using ZdoroviaNaDoloni.GUInterfaces.Registered_GUI;
using static ZdoroviaNaDoloni.Classes.OrderBasket;

namespace ZdoroviaNaDoloni.GUInterfaces.OrderBasket_GUI
{
    public partial class Order_Basket_Register_Delivery_Form : Form
    {
        private Point previousLocation;
        private string jsonPath;
        string jsonfilePath;
        decimal priceTotal;
        int countTotal;
        private List<Panel> productsPanels = new List<Panel>();
        private Order_Basket_Register_Delivery_Form GetLocation() => this;

        public Order_Basket_Register_Delivery_Form(decimal totalPrice, int totalCount, string jsonFilePath, List<Panel> productPanels)
        {
            InitializeComponent();
            priceTotal = totalPrice;
            Total_Price_Product.Text = priceTotal.ToString();
            countTotal = totalCount;
            Total_Count_Product.Text = countTotal.ToString();
            jsonPath = jsonFilePath;
            jsonfilePath = GetJsonFilePath(jsonPath);
            productsPanels = productPanels;
        }

        private void Btn_Check_Self_Pickup_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Order_Basket_Register_SelfPickup_Form OrderBaskerSelfPickupForm = new Order_Basket_Register_SelfPickup_Form(priceTotal, countTotal, jsonfilePath, productsPanels)
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            OrderBaskerSelfPickupForm.Show();
        }

        private void register_home_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Registered_Home_1 registerForm1 = new Registered_Home_1()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registerForm1.Show();
        }

        private void register_categor_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Categories_Form categorForm = new Categories_Form()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            categorForm.Show();
        }

        private void register_user_info_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Registered_Info_Form registerInfoForm = new Registered_Info_Form()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registerInfoForm.Show();
        }

        private void Btn_Check_Delivery_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Order_Basket_Register_Delivery_Form OrderBaskerRegisterForm = new Order_Basket_Register_Delivery_Form(priceTotal, countTotal, jsonfilePath, productsPanels)
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            OrderBaskerRegisterForm.Show();
        }
    }
}
