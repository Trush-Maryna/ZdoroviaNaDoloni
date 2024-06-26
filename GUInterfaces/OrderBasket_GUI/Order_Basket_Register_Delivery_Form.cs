﻿using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
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
        private Registered user = new();
        private List<Panel> productsPanels = new(); 
        private OrderBasket orderBasket = new(); 
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
            if (!string.IsNullOrEmpty(user.NumTel) && user.isInfoExists(int.Parse(user.NumTel)))
            {
                if (user.LoadUserDataFromDatabase(user.NumTel))
                {
                    Name_txt_box.Text = user.Name;
                    Region_txt_box.Text = user.Region;
                    City_txt_box.Text = user.City;
                    NumTel_txt_box.Text = user.NumTel;
                    Num_NP_txt_box.Text = user.NumNP.ToString();
                }
            }
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Name_txt_box.Text;
                string region = Region_txt_box.Text;
                string city = City_txt_box.Text;
                string numTel = NumTel_txt_box.Text;
                int numNP = int.Parse(Num_NP_txt_box.Text);
                OrderBasket userinfo = new OrderBasket(name, region, city, numTel, numNP);
                List<OrderBasket.Feedback> panelDataList = orderBasket.RestoreFileJson(jsonfilePath);
                object fileWord = ReceiptWord.CreateReceiptDelivery(panelDataList, priceTotal, countTotal, userinfo);
                object fileExcel = ReceiptExcel.CreateReceiptDelivery(panelDataList, priceTotal, countTotal, userinfo);
                MessageBox.Show("Дякуємо за замовлення! \nОсь ваш чек:");
                user = new(name, region, city, numTel, numNP);
                if (user.isInfoExists(int.Parse(numTel)) == false)
                {
                    user.SaveUserDataToDatabase(name, region, city, numTel, numNP);
                }
                orderBasket.ClearJsonFile(jsonfilePath);
                orderBasket.HideAllProductPanels(productsPanels);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Сталася помилка при оформленні замовлення. Перевірте поля на вірне заповнення.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Check_Self_Pickup_Click(object sender, EventArgs e) 
        { 
            previousLocation = GetLocation().Location; 
            Order_Basket_Register_SelfPickup_Form OrderBaskerSelfPickupForm = new Order_Basket_Register_SelfPickup_Form(priceTotal, countTotal, jsonfilePath, productsPanels) 
            { 
                StartPosition = FormStartPosition.Manual, Location = previousLocation 
            }; 
            OrderBaskerSelfPickupForm.Show(); 
            Hide(); 
        } 

        private void register_home_btn_Click(object sender, EventArgs e) 
        { 
            previousLocation = GetLocation().Location; 
            Registered_Home_1 registerForm1 = new Registered_Home_1() 
            { 
                StartPosition = FormStartPosition.Manual, Location = previousLocation 
            }; 
            registerForm1.Show(); 
            Hide(); 
        } 
        
        private void register_categor_btn_Click(object sender, EventArgs e) 
        { 
            previousLocation = GetLocation().Location; 
            Categories_Form categorForm = new Categories_Form() 
            { 
                StartPosition = FormStartPosition.Manual, Location = previousLocation 
            }; 
            categorForm.Show(); 
            Hide(); 
        } 
        
        private void register_user_info_btn_Click(object sender, EventArgs e) 
        { 
            previousLocation = GetLocation().Location;
            if (user != null)
            {
                Registered_Info_Form registerInfoForm = new Registered_Info_Form(user)
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = previousLocation
                };
                registerInfoForm.Show();
                Hide();
            }
            else 
            {
                Registered_Info_Form registerInfoForm = new Registered_Info_Form()
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = previousLocation
                };
                registerInfoForm.Show();
                Hide();
            } 
        } 
        
        private void Btn_Check_Delivery_Click(object sender, EventArgs e) 
        { 
            previousLocation = GetLocation().Location; 
            Order_Basket_Register_Delivery_Form OrderBaskerRegisterForm = new Order_Basket_Register_Delivery_Form(priceTotal, countTotal, jsonfilePath, productsPanels) 
            { 
                StartPosition = FormStartPosition.Manual, Location = previousLocation 
            }; 
            OrderBaskerRegisterForm.Show(); 
            Hide(); 
        }

        private void Name_txt_box_Enter(object sender, EventArgs e)
        {
            if (Name_txt_box.Text == "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _")
            {
                Name_txt_box.Text = "";
            }
        }

        private void Name_txt_box_Leave(object sender, EventArgs e)
        {
            if (Name_txt_box.Text == "")
            {
                Name_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            }
        }

        private void Region_txt_box_Enter(object sender, EventArgs e)
        {
            if (Region_txt_box.Text == "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _")
            {
                Region_txt_box.Text = "";
            }
        }

        private void Region_txt_box_Leave(object sender, EventArgs e)
        {
            if (Region_txt_box.Text == "")
            {
                Region_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            }
        }

        private void City_txt_box_Enter(object sender, EventArgs e)
        {
            if (City_txt_box.Text == "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _")
            {
                City_txt_box.Text = "";
            }
        }

        private void City_txt_box_Leave(object sender, EventArgs e)
        {
            if (City_txt_box.Text == "")
            {
                City_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            }
        }

        private void NumTel_txt_box_Enter(object sender, EventArgs e)
        {
            if (NumTel_txt_box.Text == "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _")
            {
                NumTel_txt_box.Text = "";
            }
        }

        private void NumTel_txt_box_Leave(object sender, EventArgs e)
        {
            if (NumTel_txt_box.Text == "")
            {
                NumTel_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            }
        }

        private void Num_NP_txt_box_Enter(object sender, EventArgs e)
        {
            if (Num_NP_txt_box.Text == "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _")
            {
                Num_NP_txt_box.Text = "";
            }
        }

        private void Num_NP_txt_box_Leave(object sender, EventArgs e)
        {
            if (Num_NP_txt_box.Text == "")
            {
                Num_NP_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            }
        }
    }
}
