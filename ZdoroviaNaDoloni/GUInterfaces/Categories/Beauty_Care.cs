using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Categories
{
    public partial class Beauty_Care : Form
    {
        private Point previousLocation;
        private Beauty_Care GetLocation() => this;

        public Beauty_Care()
        {
            InitializeComponent();
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

        private void guest_home_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Guest_Home_1 homeForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            homeForm.Show();
            Hide();
        }

        private void guest_categor_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Categories_Form categoriesForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            categoriesForm.Show();
            Hide();
        }
    }
}
