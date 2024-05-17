using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni
{
    public partial class Guest_Home_1 : Form
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

        private Guest_Home_1 GetLocation() => this;

        public Guest_Home_1()
        {
            InitializeComponent();
        }

        private void Txt_Log_in_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            timer_img.Stop();
            Registration_Form registrationForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registrationForm.Show();
            Hide();
        }

        private void Txt_Sign_in_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            timer_img.Stop();
            Autorization_Form autorizationForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            autorizationForm.Show();
            Hide();
        }

        private void Guest_Home_1_Load(object sender, EventArgs e)
        {
            timer_img.Interval = Constants.Instance.SlideTimerInterval;
            timer_img.Start();
        }

        private void timer_img_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            infoBox.Image = Image.FromFile(imagePaths[currentImageIndex]);
        }

        private void Txt_map_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            timer_img.Stop();
            Guest_Home_2 guestForm2 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guestForm2.Show();
            Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            timer_img.Stop();
            Search_Form searchForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            searchForm.Show();
            Hide();
        }

        private void guest_categor_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            timer_img.Stop();
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
