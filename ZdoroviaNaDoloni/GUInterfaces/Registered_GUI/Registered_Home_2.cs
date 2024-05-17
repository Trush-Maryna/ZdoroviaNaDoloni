using GMap.NET.WindowsForms;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Registered_GUI
{
    public partial class Registered_Home_2 : Form
    {
        private Point previousLocation;

        private Registered_Home_2 GetLocation() => this;

        public Registered_Home_2()
        {
            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap()
        {
            GMapControl gMapControl = new();
            _ = new MapManager(gMapControl);
            mapBox.Controls.Add(gMapControl);
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
            Hide();
        }

        private void Txt_suggest_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Registered_Home_1 registerForm1 = new()
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
            Categories_Form categorForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            categorForm.Show();
            Hide();
        }

        private void register_cart_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Order_Basket_Register_Form orderBasketForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            orderBasketForm.Show();
            Hide();
        }

        private void register_user_info_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Registered_Info_Form registerInfoForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registerInfoForm.Show();
            Hide();
        }
    }
}
