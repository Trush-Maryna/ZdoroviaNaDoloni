using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
using ZdoroviaNaDoloni.GUInterfaces.OrderBasket_GUI;
using static ZdoroviaNaDoloni.Classes.OrderBasket;

namespace ZdoroviaNaDoloni.GUInterfaces.Registered_GUI
{
    public partial class Order_Basket_Register_Form : Form
    {
        private Point previousLocation;
        private List<Panel> productPanels = new List<Panel>();
        private OrderBasket orderBasket = new OrderBasket();
        private List<OrderBasket.Feedback> productsToSave = new List<OrderBasket.Feedback>();
        private string jsonPath = Constants.Instance.panelspath;
        private Order_Basket_Register_Form GetLocation() => this;

        public Order_Basket_Register_Form()
        {
            InitializeComponent();
            InitializeProductPanels();
            DisplayProducts();
            orderBasket.RestorePanelStateAndProductsFromJson(jsonPath, productPanels);
            UpdateTotalCountLabel(productPanels);
            UpdateTotalPriceLabel(productPanels);
            Application.ApplicationExit += Application_ApplicationExit;
        }

        private void InitializeProductPanels()
        {
            Product_Block_1.Tag = 1;
            Product_Block_2.Tag = 2;
            Product_Block_3.Tag = 3;
            productPanels.Add(Product_Block_1);
            productPanels.Add(Product_Block_2);
            productPanels.Add(Product_Block_3);
            orderBasket.HideAllProductPanels(productPanels);
        }

        private void DisplayProducts()
        {
            int count = productPanels.Count;
            for (int i = 0; i < count; i++)
            {
                Button xButton = (Button)Controls.Find($"Btn_X_{i + 1}", true)[0];
                xButton.Tag = i;
                xButton.Click += Btn_X_Click;
                Button minusButton = (Button)Controls.Find($"Btn_minus_{i + 1}", true)[0];
                minusButton.Tag = i;
                minusButton.Click += Btn_Minus_Click;
                Button plusButton = (Button)Controls.Find($"Btn_plus_{i + 1}", true)[0];
                plusButton.Tag = i;
                plusButton.Click += Btn_Plus_Click;
            }
        }

        private void UpdateTotalCountLabel(List<Panel> productPanels)
        {
            int totalCount = 0;
            int visiblePanelsCount = 0;

            foreach (Panel panel in productPanels)
            {
                if (panel.Visible)
                {
                    visiblePanelsCount++;
                    int panelIndex = int.Parse(panel.Tag.ToString());
                    Label countLabel = (Label)Controls.Find($"Lbl_Count_{panelIndex}", true).FirstOrDefault();

                    if (countLabel != null)
                    {
                        totalCount += int.Parse(countLabel.Text);
                    }
                }
            }
            Total_Count_Product.Text = totalCount.ToString();
        }

        private void UpdateTotalPriceLabel(List<Panel> productPanels)
        {
            decimal totalPrice = 0;

            for (int i = 0; i < productPanels.Count; i++)
            {
                if (productPanels[i].Visible)
                {
                    Label priceLabel = (Label)productPanels[i].Controls.Find($"Product_Price_{i + 1}", true).FirstOrDefault();

                    if (priceLabel != null)
                    {
                        totalPrice += decimal.Parse(priceLabel.Text);
                    }
                }
            }
            Total_Price_Product.Text = totalPrice.ToString();
        }

        private void Btn_X_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int index = int.Parse(button.Tag.ToString());

            try
            {
                int productId = orderBasket.GetProductIdFromJson(jsonPath, index);
                orderBasket.DeleteProductWithFile(jsonPath, productId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            orderBasket.HideOneProductPanels(index, productPanels);
            orderBasket.RestorePanelStateAndProductsFromJson(jsonPath, productPanels);
            UpdateTotalCountLabel(productPanels);
            UpdateTotalPriceLabel(productPanels);
        }

        private void Btn_Minus_Click(object sender, EventArgs e)
        {
            Button minusButton = sender as Button;
            int index = int.Parse(minusButton.Tag.ToString());
            Label countLabel = (Label)Controls.Find($"Lbl_Count_{index + 1}", true)[0];

            int count = int.Parse(countLabel.Text);
            count = Math.Max(1, count - 1);
            countLabel.Text = count.ToString();
            UpdateTotalCountLabel(productPanels);

            decimal productPrice = orderBasket.GetProductPriceByIndex(jsonPath, index);
            Label priceLabel = (Label)Controls.Find($"Product_Price_{index + 1}", true).FirstOrDefault();

            if (priceLabel != null)
            {
                priceLabel.Text = (productPrice * count).ToString();
            }
            UpdateTotalPriceLabel(productPanels);
        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            Button plusButton = sender as Button;
            int index = int.Parse(plusButton.Tag.ToString());
            Label countLabel = (Label)Controls.Find($"Lbl_Count_{index + 1}", true)[0];

            int count = int.Parse(countLabel.Text);
            count++;
            countLabel.Text = count.ToString();
            UpdateTotalCountLabel(productPanels);

            decimal productPrice = orderBasket.GetProductPriceByIndex(jsonPath, index);
            Label priceLabel = (Label)Controls.Find($"Product_Price_{index + 1}", true).FirstOrDefault();

            if (priceLabel != null)
            {
                priceLabel.Text = (productPrice * count).ToString();
            }
            UpdateTotalPriceLabel(productPanels);
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            try
            {
                orderBasket.ClearJsonFile(jsonPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            orderBasket.HideAllProductPanels(productPanels);
        }

        private void Order_Basket_Register_Form_Load(object sender, EventArgs e)
        {
            if (СurrentProductBlock > 0)
            {
                for (int i = 0; i < СurrentProductBlock; i++)
                {
                    orderBasket.ShowPanel(i, productPanels);
                }
            }
            else
            {
                orderBasket.HideAllProductPanels(productPanels);
            }
            UpdateTotalCountLabel(productPanels);
            UpdateTotalPriceLabel(productPanels);
        }

        public void AddProductToPanel(Product product)
        {
            productsToSave.Clear();

            if (orderBasket.IsProductAdd(jsonPath, product))
            {
                MessageBox.Show($"Продукт {product.Name} вже доданий до кошика.");
                orderBasket.RestorePanelStateAndProductsFromJson(jsonPath, productPanels);
                return;
            }

            if (СurrentProductBlock >= 3)
            {
                MessageBox.Show("Кошик вже містить максимальну кількість товарів (3).");
                orderBasket.RestorePanelStateAndProductsFromJson(jsonPath, productPanels);
                return;
            }

            СurrentProductBlock++;
            int index = СurrentProductBlock;
            Panel nextPanel = orderBasket.GetNextAvailablePanel(index, productPanels);

            if (nextPanel != null)
            {
                if (index <= productPanels.Count)
                {
                    var panelData = new OrderBasket.Feedback
                    {
                        PanelVisible = true,
                        Product = product
                    };
                    productsToSave.Add(panelData);

                    try
                    {
                        orderBasket.SaveProducts(jsonPath, productsToSave);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    orderBasket.RestorePanelStateAndProductsFromJson(jsonPath, productPanels);
                }
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            try
            {
                orderBasket.ClearJsonFile(jsonPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            orderBasket.HideAllProductPanels(productPanels);
            UpdateTotalCountLabel(productPanels);
            UpdateTotalPriceLabel(productPanels);
        }

        private void register_home_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Registered_Home_1 registerForm1 = new Registered_Home_1()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registerForm1.Show();
            Hide();
        }

        private void register_categor_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Categories_Form categorForm = new Categories_Form()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            categorForm.Show();
            Hide();
        }

        private void register_user_info_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Registered_Info_Form registerInfoForm = new Registered_Info_Form()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registerInfoForm.Show();
            Hide();
        }

        private void Btn_Check_Self_Pickup_Click(object sender, EventArgs e)
        {
            decimal totalPrice = decimal.Parse(Total_Price_Product.Text);
            int totalCount = int.Parse(Total_Count_Product.Text);

            previousLocation = GetLocation().Location;
            Order_Basket_Register_SelfPickup_Form orderBasketSelfPickupForm = new Order_Basket_Register_SelfPickup_Form(totalPrice, totalCount, jsonPath, productPanels)
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            orderBasketSelfPickupForm.Show();
            Hide();
        }

        private void Btn_Check_Delivery_Click(object sender, EventArgs e)
        {
            decimal totalPrice = decimal.Parse(Total_Price_Product.Text);
            int totalCount = int.Parse(Total_Count_Product.Text);

            previousLocation = GetLocation().Location;
            Order_Basket_Register_Delivery_Form orderBasketDeliveryForm = new Order_Basket_Register_Delivery_Form(totalPrice, totalCount, jsonPath, productPanels)
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            orderBasketDeliveryForm.Show();
            Hide();
        }
    }
}