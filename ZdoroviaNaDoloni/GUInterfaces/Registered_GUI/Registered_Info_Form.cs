using System.Diagnostics;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Registered_GUI
{
    public partial class Registered_Info_Form : Form
    {
        private Point previousLocation;
        private Registered_Info_Form GetLocation() => this;
        private string nameUser;
        private string regionUser;
        private string cityUser;
        private string numTelUser;
        private int numNPUser;
        private OrderBasket userInfo;

        public Registered_Info_Form()
        {
            InitializeComponent();
        }

        public Registered_Info_Form(string name, string region, string city, string numTel, int numNP, OrderBasket userinfo)
        {
            InitializeComponent();
            this.nameUser = name;
            this.regionUser = region;
            this.cityUser = city;
            this.numTelUser = numTel;
            this.numNPUser = numNP;
            this.userInfo = userinfo;
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

        private void Btn_Delete_Profile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете видалити свій профіль?", "Підтвердження видалення", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string? deleteResult = User.CurrentUser.DeleteUserFromDatabase(User.CurrentUser);
                if (deleteResult == null)
                {
                    MessageBox.Show("Профіль успішно видалено.");
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
                else
                {
                    MessageBox.Show("Помилка: " + deleteResult);
                }
            }
        }

        private void Btn_User_Info_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Registered_Info_User_Form registeredInfoUserForm = new(nameUser, regionUser, cityUser, numTelUser, numNPUser, userInfo)
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registeredInfoUserForm.Show();
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

        private void register_home_btn_Click(object sender, EventArgs e)
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

        private void register_OrderBask_btn_Click(object sender, EventArgs e)
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
    }
}
