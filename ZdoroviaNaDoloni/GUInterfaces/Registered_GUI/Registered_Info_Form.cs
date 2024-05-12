using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Registered_GUI
{
    public partial class Registered_Info_Form : Form
    {
        private Point previousLocation;

        private Registered_Info_Form GetLocation() => this;

        public Registered_Info_Form()
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
                    Hide();
                    Guest_Home_1 guestHome1Form = new()
                    {
                        StartPosition = FormStartPosition.Manual,
                        Location = previousLocation
                    };
                    guestHome1Form.Show();
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
            Hide();
            Registered_Info_User_Form registeredInfoUserForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registeredInfoUserForm.Show();
        }
    }
}
