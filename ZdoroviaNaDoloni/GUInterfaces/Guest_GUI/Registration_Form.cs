using System.Diagnostics;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Registered_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Guest_GUI
{
    public partial class Registration_Form : Form
    {
        private Point previousLocation;
        private bool isEyeButtonClicked = false;
        private bool isCheckButtonClicked = false;

        public Registration_Form()
        {
            InitializeComponent();
        }

        private Registration_Form GetLocation() => this;

        private void Btn_Sign_In_Click(object sender, EventArgs e)
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
                Btn_Eye.BackgroundImage = Image.FromFile(Constants.Instance.EyeOpenUrl);
                isEyeButtonClicked = true;
            }
            else
            {
                Pass_txt.PasswordChar = '*';
                Btn_Eye.BackgroundImage = Image.FromFile(Constants.Instance.EyeHideUrl);
                isEyeButtonClicked = false;
            }
        }

        private void Btn_Check_Click(object sender, EventArgs e)
        {
            if (!isCheckButtonClicked)
            {
                Btn_Check.BackgroundImage = Image.FromFile(Constants.Instance.CheckHideUrl);
                isCheckButtonClicked = true;
            }
            else
            {
                Btn_Check.BackgroundImage = Image.FromFile(Constants.Instance.CheckOpenUrl);
                isCheckButtonClicked = false;
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Guest_Home_1 guest_home_1_Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guest_home_1_Form.Show();
            Hide();
        }

        private void Btn_Log_In_Click(object sender, EventArgs e)
        {
            string phoneNumberTxt = Phone_Numder_txt.Text;
            string password = Pass_txt.Text;

            try
            {
                Registered regist = new Registered();
                regist.PhoneNumber = phoneNumberTxt;
                regist.Password = password;
                int phoneNumber = int.Parse(phoneNumberTxt);
                if (!isCheckButtonClicked)
                {
                    if (regist.isUserExists(phoneNumber))
                    {
                        MessageBox.Show("Акаунт з таким номером телефону вже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (regist.Register(phoneNumber, password, !isCheckButtonClicked))
                        {
                            MessageBox.Show("Акаунт створено.");
                            previousLocation = GetLocation().Location;
                            Registered_Home_1 registered_home_1_Form = new()
                            {
                                StartPosition = FormStartPosition.Manual,
                                Location = previousLocation
                            };
                            registered_home_1_Form.Show();
                            Hide();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void conditions_rules_txt_Click(object sender, EventArgs e)
        {
            conditions_rules_txt.BackColor = Color.Blue;
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Constants.Instance.ConditionsRulesLink,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
