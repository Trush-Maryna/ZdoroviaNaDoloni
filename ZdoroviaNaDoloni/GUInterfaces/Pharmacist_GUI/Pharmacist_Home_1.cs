using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Pharmacist_GUI
{
    public partial class Pharmacist_Home_1 : Form
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
        private Pharmacist_Home_1 GetLocation() => this;

        public Pharmacist_Home_1()
        {
            InitializeComponent();
        }

        private void Pharmacist_Home_1_Load(object sender, EventArgs e)
        {
            timer_img.Interval = Constants.Instance.SlideTimerInterval;
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
            Pharmacist_Info_Form pharm_info_Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharm_info_Form.Show();
            Hide();
        }

        private void pharm_categor_btn_Click(object sender, EventArgs e)
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
            Pharmacist_Home_2 pharm_home_2_Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharm_home_2_Form.Show();
            Hide();
        }
    }
}
