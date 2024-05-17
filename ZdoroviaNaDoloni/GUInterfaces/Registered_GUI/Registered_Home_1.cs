using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Registered_GUI
{
    public partial class Registered_Home_1 : Form
    {
        private Point previousLocation;
        private int currentImageIndex = 0;
        private readonly string[] imagePaths =
        {
            Constants.Instance.InfoShowUrl1,
            Constants.Instance.InfoShowUrl2,
            Constants.Instance.InfoShowUrl3,
            Constants.Instance.InfoShowUrl4
        };

        private Registered_Home_1 GetLocation() => this;

        public Registered_Home_1()
        {
            InitializeComponent();
        }

        private void Registered_Home_1_Load(object sender, EventArgs e)
        {
            timer_img.Interval = Constants.Instance.SlideTimerInterval;
            timer_img.Start();
        }

        private void timer_img_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            infoBox.Image = Image.FromFile(imagePaths[currentImageIndex]);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Search_Form searchForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            searchForm.Show();
            Hide();
        }

        private void Txt_map_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Registered_Home_2 registerForm2 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registerForm2.Show();
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

        private void register_cart_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Order_Basket_Register_Form orderBascetForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            orderBascetForm.Show();
            Hide();
        }

        private void register_user_info_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Registered_Info_Form registerInfoForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registerInfoForm.Show();
            Hide();
        }
    }
}
