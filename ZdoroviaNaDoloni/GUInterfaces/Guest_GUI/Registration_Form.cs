using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Registered_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Guest_GUI
{
    public partial class Registration_Form : Form
    {
        private Point previousLocation;
        private bool isEyeButtonClicked = false;
        private bool isCheckButtonClicked = false;
        private Registered loggedInSignedInUser;

        public Registration_Form()
        {
            InitializeComponent();
            loggedInSignedInUser = new Registered();
        }

        private Registration_Form GetLocation() => this;

        private void Btn_Sign_In_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Autorization_Form autorizationForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            autorizationForm.Show();
        }

        private void Phone_Numder_txt_Enter(object sender, EventArgs e)
        {
            if (Phone_Numder_txt.Text == "_ _ _ _  _ _  _ _ _")
            {
                Phone_Numder_txt.Text = "";
            }
        }

        private void Phone_Numder_txt_Leave(object sender, EventArgs e)
        {
            if (Phone_Numder_txt.Text == "")
            {
                Phone_Numder_txt.Text = "_ _ _ _  _ _  _ _ _";
            }
        }

        private void Pass_txt_Enter(object sender, EventArgs e)
        {
            if (Pass_txt.Text == "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _")
            {
                Pass_txt.Text = "";
            }
        }

        private void Pass_txt_Leave(object sender, EventArgs e)
        {
            if (Pass_txt.Text == "")
            {
                Pass_txt.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            }
        }

        private void Pass_txt_TextChanged(object sender, EventArgs e)
        {
            Pass_txt.PasswordChar = '*';
        }

        private void Btn_Eye_Click(object sender, EventArgs e)
        {
            if (!isEyeButtonClicked)
            {
                Pass_txt.PasswordChar = '\0';
                Btn_Eye.BackgroundImage = Image.FromFile(Constants.EyeOpenUrl);
                isEyeButtonClicked = true;
            }
            else
            {
                Pass_txt.PasswordChar = '*';
                Btn_Eye.BackgroundImage = Image.FromFile(Constants.EyeHideUrl);
                isEyeButtonClicked = false;
            }
        }

        private void Btn_Check_Click(object sender, EventArgs e)
        {
            if (!isCheckButtonClicked)
            {
                Btn_Check.BackgroundImage = Image.FromFile(Constants.CheckHideUrl);
                isCheckButtonClicked = true;
            }
            else
            {
                Btn_Check.BackgroundImage = Image.FromFile(Constants.CheckOpenUrl);
                isCheckButtonClicked = false;
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Guest_Home_1 guest_home_1_Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guest_home_1_Form.Show();
        }

        private void Btn_Log_In_Click(object sender, EventArgs e)
        {
            string phoneNumberTxt = Phone_Numder_txt.Text;
            string password = Pass_txt.Text;

            if (phoneNumberTxt == "_ _ _ _  _ _  _ _ _")
            {
                MessageBox.Show("Введіть номер телефону!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Phone_Numder_txt.ForeColor = Color.Red;
                return;
            }

            if (password == "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _")
            {
                MessageBox.Show("Введіть пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Pass_txt.ForeColor = Color.Red;
                return;
            }

            int phoneNumber = int.Parse(phoneNumberTxt);
            if (!int.TryParse(phoneNumberTxt, out phoneNumber))
            {
                MessageBox.Show("Номер телефону повинен містити тільки цифри!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isCheckButtonClicked)
            {
                Registered registeredUser = new Registered();
                if (registeredUser.isUserExists(phoneNumber))
                {
                    MessageBox.Show("Акаунт з таким номером телефону вже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (registeredUser.Register(phoneNumber, password, !isCheckButtonClicked))
                    {
                        MessageBox.Show("Акаунт створено.");
                        loggedInSignedInUser = registeredUser;
                        registeredUser.CheckRegistrationStatus();
                        previousLocation = GetLocation().Location;
                        Hide();
                        Registered_Home_1 registered_home_1_Form = new()
                        {
                            StartPosition = FormStartPosition.Manual,
                            Location = previousLocation
                        };
                        registered_home_1_Form.Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Акаунт не створено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Підтвердіть Умови та Правила!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
