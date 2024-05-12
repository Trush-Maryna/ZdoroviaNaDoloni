using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Pharmacist_GUI
{
    public partial class Pharmacist_Home_1 : Form
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

        public Pharmacist_Home_1()
        {
            InitializeComponent();
        }

        private Pharmacist_Home_1 GetLocation() => this;

        private void pharm_categor_btn_Click(object sender, EventArgs e)
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

        private void Txt_map_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Pharmacist_Home_2 pharm_home_2_Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharm_home_2_Form.Show();
        }

        private void Pharmacist_Home_1_Load(object sender, EventArgs e)
        {
            timer_img.Interval = Constants.SlideTimerInterval;
            timer_img.Start();
        }

        private void timer_img_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            infoBox.Image = Image.FromFile(imagePaths[currentImageIndex]);
        }

        private void pharm_user_info_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Pharmacist_Info_Form pharm_info_Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharm_info_Form.Show();
        }
    }
}
