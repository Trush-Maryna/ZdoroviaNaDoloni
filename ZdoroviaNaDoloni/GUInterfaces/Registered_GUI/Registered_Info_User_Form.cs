using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
namespace ZdoroviaNaDoloni.GUInterfaces.Registered_GUI 
{ 
    public partial class Registered_Info_User_Form : Form 
    { 
        private Point previousLocation; 
        private bool isMaleChecked = false; 
        private bool isFemaleChecked = false; 
        private Registered userDB; 
        private Registered_Info_User_Form GetLocation() => this; 

        public Registered_Info_User_Form()
        { 
            InitializeComponent();
        }

        public Registered_Info_User_Form(Registered user)
        {
            InitializeComponent();
            if (user.isInfoExists(int.Parse(user.PhoneNumber)))
            {
                if (user.LoadUserDataFromDatabase(user.PhoneNumber))
                {
                    Name_txt_box.Text = user.Name;
                    Region_txt_box.Text = user.Region;
                    City_txt_box.Text = user.City;
                    NumTel_txt_box.Text = user.PhoneNumber;
                    Num_NP_txt_box.Text = user.NumNP.ToString();
                    if (user.Gender == Genders.Male)
                    {
                        Btn_Check_Male.BackgroundImage = Image.FromFile(Constants.Instance.CheckInfoOpenUrl);
                    }
                    else
                    {
                        Btn_Check_Female.BackgroundImage = Image.FromFile(Constants.Instance.CheckInfoOpenUrl);
                    }
                    UpdateButtonState();
                    userDB = user;
                }
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
                Btn_Check_Female.BackgroundImage = Image.FromFile(Constants.Instance.CheckInfoOpenUrl); 
            if (!isFemaleChecked) 
                Btn_Check_Female.BackgroundImage = Image.FromFile(Constants.Instance.CheckInfoCloseUrl); 
            if (isMaleChecked) 
                Btn_Check_Male.BackgroundImage = Image.FromFile(Constants.Instance.CheckInfoOpenUrl); 
            if (!isMaleChecked) 
                Btn_Check_Male.BackgroundImage = Image.FromFile(Constants.Instance.CheckInfoCloseUrl); 
        } 
        
        private void Btn_Confirm_Click(object sender, EventArgs e) 
        {
            if (userDB != null)
            {
                var gender = isMaleChecked ? Genders.Male : Genders.Female;
                var isSaved = userDB.UpdateUserGenderInDatabase(userDB.PhoneNumber, gender);
                if (isSaved)
                {
                    MessageBox.Show("Інформацію збережено");
                }
            }
            else 
            {
                var name = Name_txt_box.Text;
                var region = Region_txt_box.Text;
                var city = City_txt_box.Text;
                var phoneNumber = NumTel_txt_box.Text;
                var numNP = int.Parse(Num_NP_txt_box.Text);
                var gender = isMaleChecked ? Genders.Male : Genders.Female;
                var isSaved = userDB.SaveUserDataToDatabase(name, region, city, phoneNumber, numNP, gender);
                if (isSaved)
                {
                    MessageBox.Show("Інформацію збережено");
                }
            }
        } 
        
        private void register_home_btn_Click(object sender, EventArgs e) 
        { 
            previousLocation = GetLocation().Location; 
            Registered_Home_1 registerForm1 = new Registered_Home_1() 
            { 
                StartPosition = FormStartPosition.Manual, Location = previousLocation 
            }; 
            registerForm1.Show(); 
            Hide(); 
        } 
        
        private void register_categor_btn_Click(object sender, EventArgs e) 
        { 
            previousLocation = GetLocation().Location; 
            Categories_Form categorForm = new Categories_Form() 
            { 
                StartPosition = FormStartPosition.Manual, Location = previousLocation 
            }; 
            categorForm.Show(); 
            Hide(); 
        } 
        
        private void register_OrderBask_btn_Click(object sender, EventArgs e) 
        { 
            previousLocation = GetLocation().Location; 
            Order_Basket_Register_Form orderBasketForm = new() 
            { 
                StartPosition = FormStartPosition.Manual, Location = previousLocation 
            }; 
            orderBasketForm.Show(); 
            Hide(); 
        } 
        
        private void register_user_info_btn_Click(object sender, EventArgs e) 
        { 
            previousLocation = GetLocation().Location; 
            Registered_Info_Form registerInfoForm = new Registered_Info_Form() 
            { 
                StartPosition = FormStartPosition.Manual, Location = previousLocation 
            }; 
            registerInfoForm.Show(); 
            Hide(); 
        }

        private void Name_txt_box_Enter(object sender, EventArgs e)
        {
            if (Name_txt_box.Text == "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _")
            {
                Name_txt_box.Text = "";
            }
        }

        private void Name_txt_box_Leave(object sender, EventArgs e)
        {
            if (Name_txt_box.Text == "")
            {
                Name_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            }
        }

        private void Region_txt_box_Enter(object sender, EventArgs e)
        {
            if (Region_txt_box.Text == "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _")
            {
                Region_txt_box.Text = "";
            }
        }

        private void Region_txt_box_Leave(object sender, EventArgs e)
        {
            if (Region_txt_box.Text == "")
            {
                Region_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            }
        }

        private void City_txt_box_Enter(object sender, EventArgs e)
        {
            if (City_txt_box.Text == "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _")
            {
                City_txt_box.Text = "";
            }
        }

        private void City_txt_box_Leave(object sender, EventArgs e)
        {
            if (City_txt_box.Text == "")
            {
                City_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            }
        }

        private void NumTel_txt_box_Enter(object sender, EventArgs e)
        {
            if (NumTel_txt_box.Text == "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _")
            {
                NumTel_txt_box.Text = "";
            }
        }

        private void NumTel_txt_box_Leave(object sender, EventArgs e)
        {
            if (NumTel_txt_box.Text == "")
            {
                NumTel_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            }
        }

        private void Num_NP_txt_box_Enter(object sender, EventArgs e)
        {
            if (Num_NP_txt_box.Text == "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _")
            {
                Num_NP_txt_box.Text = "";
            }
        }

        private void Num_NP_txt_box_Leave(object sender, EventArgs e)
        {
            if (Num_NP_txt_box.Text == "")
            {
                Num_NP_txt_box.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            }
        }
    }
}
