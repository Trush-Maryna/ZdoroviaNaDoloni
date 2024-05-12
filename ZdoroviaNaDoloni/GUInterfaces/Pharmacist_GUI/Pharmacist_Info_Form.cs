using System.Diagnostics;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
using ZdoroviaNaDoloni.GUInterfaces.Registered_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Pharmacist_GUI
{
    public partial class Pharmacist_Info_Form : Form
    {
        private Point previousLocation;
        private Pharmacist_Info_Form GetLocation() => this;

        public Pharmacist_Info_Form()
        {
            InitializeComponent();
        }

        private void register_home_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Registered_Home_1 registerForm1 = new()
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
            Categories_Form categorForm = new()
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

        private void Btn_Close_Profile_Click(object sender, EventArgs e)
        {
            User.Logout();
            previousLocation = GetLocation().Location;
            Hide();
            Guest_Home_1 guestHome1Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guestHome1Form.Show();
        }

        private void Btn_FAQ_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Constants.ConditionsRulesLink,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void Btn_Orders_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Pharmacist_Orders_Form pharmOrdersForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharmOrdersForm.Show();
        }

        private void Btn_Close_Profile_Click_1(object sender, EventArgs e)
        {
            User.Logout();
            previousLocation = GetLocation().Location;
            Hide();
            Guest_Home_1 guestHome1Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guestHome1Form.Show();
        }
    }
}
