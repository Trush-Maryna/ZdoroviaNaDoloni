﻿using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Pharmacist_GUI;
using ZdoroviaNaDoloni.GUInterfaces.Registered_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Guest_GUI
{
    public partial class Autorization_Form : Form
    {
        private Point previousLocation;
        private bool isEyeButtonClicked = false;

        public Autorization_Form()
        {
            InitializeComponent();
        }

        private Autorization_Form GetLocation() => this;

        private void Btn_Log_In_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Registration_Form registrationForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registrationForm.Show();
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

        private void Btn_Sign_In_Click(object sender, EventArgs e)
        {
            string phoneNumberTxt = Phone_Numder_txt.Text;
            string password = Pass_txt.Text;

            try
            {
                Pharmacist pharm = new Pharmacist();
                pharm.PhoneNumber = phoneNumberTxt;
                pharm.Password = password;

                int phoneNumber = int.Parse(phoneNumberTxt);
                if (phoneNumber == Constants.pharm1phone ||
                    phoneNumber == Constants.pharm2phone ||
                    phoneNumber == Constants.pharm3phone)
                {
                    if (pharm.Authorized(phoneNumber, password))
                    {
                        MessageBox.Show("Ви успішно авторизувалися як провізор.");
                        previousLocation = GetLocation().Location;
                        Hide();
                        Pharmacist_Home_1 pharm_home_1_Form = new()
                        {
                            StartPosition = FormStartPosition.Manual,
                            Location = previousLocation
                        };
                        pharm_home_1_Form.Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Помилка авторизації!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    Registered regist = new Registered();
                    regist.PhoneNumber = phoneNumberTxt;
                    regist.Password = password;

                    if (regist.Authorized(phoneNumber, password))
                    {
                        MessageBox.Show("Ви успішно авторизувалися як зареєстрований користувач.");
                        previousLocation = GetLocation().Location;
                        Hide();
                        Registered_Home_1 registered_home_1_Form = new()
                        {
                            StartPosition = FormStartPosition.Manual,
                            Location = previousLocation
                        };
                        registered_home_1_Form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Помилка авторизації!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
