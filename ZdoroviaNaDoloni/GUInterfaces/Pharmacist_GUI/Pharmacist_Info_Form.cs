using System.Diagnostics;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

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

        private void Btn_Close_Profile_Click(object sender, EventArgs e)
        {
            User.Logout();
            previousLocation = GetLocation().Location;
            Guest_Home_1 guestHome1Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guestHome1Form.Show();
            Hide();
        }

        private void Btn_FAQ_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Constants.Instance.ConditionsRulesLink,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void Btn_Orders_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Pharmacist_Orders_Form pharmOrdersForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharmOrdersForm.Show();
            Hide();
        }

        private void Btn_Close_Profile_Click_1(object sender, EventArgs e)
        {
            User.Logout();
            previousLocation = GetLocation().Location;
            Guest_Home_1 guestHome1Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guestHome1Form.Show();
            Hide();
        }

        private void Btn_List_Orders_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Pharmacist_Products_Form pharmProductsForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharmProductsForm.Show();
            Hide();
        }

        private void pharmacist_home_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Pharmacist_Home_1 pharmacistForm1 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharmacistForm1.Show();
            Hide();
        }

        private void pharmacist_categor_btn_Click(object sender, EventArgs e)
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
    }
}
