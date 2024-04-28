using System.Windows.Forms;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni
{
    public partial class Guest_Home_1 : Form
    {
        private Point previousLocation;
        private int currentImageIndex = 0;
        private readonly string[] imagePaths =
        {
            Constants.InfoShowUrl1,
            Constants.InfoShowUrl2,
            Constants.InfoShowUrl3,
            Constants.InfoShowUrl4
        };

        public Guest_Home_1()
        {
            InitializeComponent();
        }

        private void Txt_map_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Guest_Home_2 guestForm2 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guestForm2.Show();
        }

        private Guest_Home_1 GetLocation() => this;

        private void btn_search_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Search_Form searchForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            searchForm.Show();
        }

        private void guest_categor_btn_Click(object sender, EventArgs e)
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

        private void Txt_Log_in_Click(object sender, EventArgs e)
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

        private void Txt_Sign_in_Click(object sender, EventArgs e)
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

        private void Guest_Home_1_Load(object sender, EventArgs e)
        {
            timer_img.Interval = Constants.SlideTimerInterval;
            timer_img.Start();
        }

        private void timer_img_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            infoBox.Image = Image.FromFile(imagePaths[currentImageIndex]);
        }
    }
}
