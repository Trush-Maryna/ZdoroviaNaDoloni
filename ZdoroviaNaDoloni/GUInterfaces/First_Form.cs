
namespace ZdoroviaNaDoloni
{
    public partial class First_Form : Form
    {
        private Point previousLocation;
        private int currentImageIndex = 0;
        private readonly string[] imagePaths =
        {
            Constants.SlideImgUrl1,
            Constants.SlideImgUrl2,
            Constants.SlideImgUrl3,
            Constants.SlideImgUrl4
        };

        public First_Form()
        {
            InitializeComponent();
        }

        private void First_Form_Load(object sender, EventArgs e)
        {
            Location = new Point(Constants.xCoord, Constants.yCoord);
            timer_img.Interval = Constants.SlideTimerInterval;
            timer_img.Start();
        }

        private void timer_img_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            infoBox.Image = Image.FromFile(imagePaths[currentImageIndex]);
        }

        private void first_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            timer_img.Stop();
            Hide();
            Guest_Home_1 guestForm1 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guestForm1.Show();
        }

        private First_Form GetLocation() => this;
    }
}
