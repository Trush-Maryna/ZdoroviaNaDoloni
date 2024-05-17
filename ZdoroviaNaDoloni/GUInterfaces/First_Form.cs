namespace ZdoroviaNaDoloni
{
    public partial class First_Form : Form
    {
        private Point previousLocation;
        private int currentImageIndex = 0;
        private readonly string[] imagePaths =
        {
            Constants.Instance.SlideImgUrl1,
            Constants.Instance.SlideImgUrl2,
            Constants.Instance.SlideImgUrl3,
            Constants.Instance.SlideImgUrl4
        };

        public First_Form()
        {
            InitializeComponent();
        }

        private void First_Form_Load(object sender, EventArgs e)
        {
            Location = new Point(Constants.Instance.xCoord, Constants.Instance.yCoord);
            timer_img.Interval = Constants.Instance.SlideTimerInterval;
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
            Guest_Home_1 guestForm1 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guestForm1.Show();
            Hide();
        }

        private First_Form GetLocation() => this;
    }
}
