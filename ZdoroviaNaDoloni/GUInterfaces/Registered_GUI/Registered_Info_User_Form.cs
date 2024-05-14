using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Registered_GUI
{
    public partial class Registered_Info_User_Form : Form
    {
        private Point previousLocation;
        private OrderBasket userinfo;
        private bool isMaleChecked = false;
        private bool isFemaleChecked = false;
        private string name;
        private string region;
        private string city;
        private string numTel;
        private int numNP;

        private Registered_Info_User_Form GetLocation() => this;

        public Registered_Info_User_Form()
        {
            InitializeComponent();
        }

        public Registered_Info_User_Form(string nameUser, string regionUser, string cityUser, string numTelUser, int numNPUser, OrderBasket userInfo)
        {
            InitializeComponent();
            this.name = nameUser;
            this.region = regionUser;
            this.city = cityUser;
            this.numTel = numTelUser;
            this.numNP = numNPUser;
            this.userinfo = userInfo;
        }

        private void Registered_Info_User_Form_Load(object sender, EventArgs e)
        {
            if (userinfo != null)
            {
                Name_txt_box.Text = userinfo.Name;
                Region_txt_box.Text = userinfo.Region;
                City_txt_box.Text = userinfo.City;
                NumTel_txt_box.Text = userinfo.NumTel;
                Num_NP_txt_box.Text = userinfo.NumNP.ToString();

                if (userinfo.Gender == Genders.Male)
                    isMaleChecked = true;
                else if (userinfo.Gender == Genders.Female)
                    isFemaleChecked = true;
                UpdateButtonState();
            }
            else
            {
                Name_txt_box.Text = name;
                Region_txt_box.Text = region;
                City_txt_box.Text = city;
                NumTel_txt_box.Text = numTel;
                Num_NP_txt_box.Text = numNP.ToString();
                UpdateButtonState();
            }
        }

        private void Btn_Check_Female_Click(object sender, EventArgs e)
        {
            isFemaleChecked = !isFemaleChecked;
            UpdateButtonState();
        }

        private void Btn_Check_Male_Click(object sender, EventArgs e)
        {
            isMaleChecked = !isMaleChecked;
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            if (isFemaleChecked)
                Btn_Check_Female.BackgroundImage = Image.FromFile(Constants.CheckInfoCloseUrl);
            if (!isFemaleChecked)
                Btn_Check_Female.BackgroundImage = Image.FromFile(Constants.CheckInfoOpenUrl);

            if (isMaleChecked)
                Btn_Check_Male.BackgroundImage = Image.FromFile(Constants.CheckInfoCloseUrl);
            if (!isMaleChecked)
                Btn_Check_Male.BackgroundImage = Image.FromFile(Constants.CheckInfoOpenUrl);
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_txt_box.Text) ||
                string.IsNullOrWhiteSpace(Region_txt_box.Text) ||
                string.IsNullOrWhiteSpace(City_txt_box.Text) ||
                string.IsNullOrWhiteSpace(NumTel_txt_box.Text) ||
                string.IsNullOrWhiteSpace(Num_NP_txt_box.Text))
            {
                MessageBox.Show("Заповніть усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (userinfo != null)
                {
                    userinfo.Name = Name_txt_box.Text;
                    userinfo.Region = Region_txt_box.Text;
                    userinfo.City = City_txt_box.Text;
                    userinfo.NumTel = NumTel_txt_box.Text;
                    userinfo.NumNP = int.Parse(Num_NP_txt_box.Text);

                    if (isMaleChecked)
                        userinfo.Gender = Genders.Male;
                    else if (isFemaleChecked)
                        userinfo.Gender = Genders.Female;
                    MessageBox.Show("Інформацію збережено");
                }
                else
                {
                    userinfo = new OrderBasket();
                    userinfo.Name = Name_txt_box.Text;
                    userinfo.Region = Region_txt_box.Text;
                    userinfo.City = City_txt_box.Text;
                    userinfo.NumTel = NumTel_txt_box.Text;
                    userinfo.NumNP = int.Parse(Num_NP_txt_box.Text);

                    if (isMaleChecked)
                        userinfo.Gender = Genders.Male;
                    else if (isFemaleChecked)
                        userinfo.Gender = Genders.Female;
                    MessageBox.Show("Інформацію збережено");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
