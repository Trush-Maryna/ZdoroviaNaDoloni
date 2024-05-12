using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Registered_GUI
{
    public partial class Registered_Info_User_Form : Form
    {
        private Point previousLocation;
        private Registered_Info_User_Form GetLocation() => this;

        public Registered_Info_User_Form()
        {
            InitializeComponent();
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

        private void register_OrderBask_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Order_Basket_Register_Form orderBasketForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            orderBasketForm.Show();
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
    }
}
