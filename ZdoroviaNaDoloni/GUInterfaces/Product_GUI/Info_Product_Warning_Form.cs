using System.Diagnostics;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Product_GUI
{
    public partial class Info_Product_Warning_Form : Form
    {
        private Point previousLocation;

        public Info_Product_Warning_Form()
        {
            InitializeComponent();
        }

        private Info_Product_Warning_Form GetLocation() => this;

        private void Sign_In_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Autorization_Form autorizationForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            autorizationForm.Show();
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
            Hide();
        }

        private void btn_open_home_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Guest_Home_1 homeForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            homeForm.Show();
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
            Hide();
        }

        private void Btn_tg_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Constants.Instance.TelegramLink,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
