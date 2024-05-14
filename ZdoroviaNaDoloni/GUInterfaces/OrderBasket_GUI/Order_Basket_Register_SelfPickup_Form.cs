using GMap.NET.WindowsForms;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
using ZdoroviaNaDoloni.GUInterfaces.Registered_GUI;
using static ZdoroviaNaDoloni.Classes.OrderBasket;

namespace ZdoroviaNaDoloni.GUInterfaces.OrderBasket_GUI
{
    public partial class Order_Basket_Register_SelfPickup_Form : Form
    {
        private Point previousLocation;
        private string jsonPath;
        string jsonfilePath;
        decimal priceTotal;
        int countTotal;
        private List<MapManager.Pharmacy> pharmacyMarks = new List<MapManager.Pharmacy>();
        private List<Panel> productsPanels = new List<Panel>();
        private OrderBasket orderBasket = new OrderBasket();
        private Order_Basket_Register_SelfPickup_Form GetLocation() => this;

        public Order_Basket_Register_SelfPickup_Form(decimal totalPrice, int totalCount, string jsonFilePath, List<Panel> productPanels)
        {
            InitializeComponent();
            InitializeMap();
            priceTotal = totalPrice;
            Total_Price_Product.Text = priceTotal.ToString();
            countTotal = totalCount;
            Total_Count_Product.Text = countTotal.ToString();
            jsonPath = jsonFilePath;
            jsonfilePath = GetJsonFilePath(jsonPath);
            productsPanels = productPanels;
        }

        private void InitializeMap()
        {
            GMapControl gMapControl = new();
            var mapManager = new MapManager(gMapControl);

            mapManager.InfoMarkClicked += (name, latitude, longitude, info) =>
            {
                MapManager.Pharmacy pharmacyMark = new MapManager.Pharmacy(name, latitude, longitude, info);
                pharmacyMarks.Add(pharmacyMark);
            };
            mapBox.Controls.Add(gMapControl);
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                List<OrderBasket.Feedback> panelDataList = orderBasket.RestoreFileJson(jsonfilePath);
                object fileName = ReceiptWord.CreateReceiptSelfPickup(panelDataList, priceTotal, countTotal, pharmacyMarks);
                MessageBox.Show("Дякуємо за замовлення! \nОсь ваш чек:");
                orderBasket.ClearJsonFile(jsonfilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            orderBasket.HideAllProductPanels(productsPanels);

            previousLocation = GetLocation().Location;
            Hide();
            Registered_Home_1 registerForm1 = new Registered_Home_1()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registerForm1.Show();
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
