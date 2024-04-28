using ZdoroviaNaDoloni.GUInterfaces.Categories;

namespace ZdoroviaNaDoloni.GUInterfaces.Guest_GUI
{
    public partial class Categories_Form : Form
    {
        private Point previousLocation;
        private Categories_Form GetLocation() => this;

        public Categories_Form()
        {
            InitializeComponent();
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

        private void guest_home_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Guest_Home_1 homeForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            homeForm.Show();
        }

        private void Btn_Categor_1_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Medicine medicine_form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            medicine_form.Show();
        }

        private void Btn_Categor_2_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Vitamins_Minerals vitamins_minerals_form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            vitamins_minerals_form.Show();
        }

        private void Btn_Categor_3_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Beauty_Care beauty_care_form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            beauty_care_form.Show();
        }

        private void Btn_Categor_4_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Children_Moms children_moms_form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            children_moms_form.Show();
        }

        private void Btn_Categor_5_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Sport sport_form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            sport_form.Show();
        }

        private void Btn_Categor_6_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Medical_Equipment_Devices medical_equipment_devices_form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            medical_equipment_devices_form.Show();
        }

        private void Btn_Categor_7_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Different different_form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            different_form.Show();
        }
    }
}
