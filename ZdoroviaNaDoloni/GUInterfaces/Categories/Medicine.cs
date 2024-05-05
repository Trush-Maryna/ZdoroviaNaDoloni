using ZdoroviaNaDoloni.GUInterfaces.Categories;

namespace ZdoroviaNaDoloni.GUInterfaces.Guest_GUI
{
    public partial class Medicine : Form
    {
        private Point previousLocation;
        private Medicine GetLocation() => this;
        private Product product = new Product();

        public Medicine()
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

        private void guest_categor_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Categories_Form categoriesForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            categoriesForm.Show();
        }

        private void Btn_Categor_1_Click(object sender, EventArgs e)
        {
            List<Product> filteredProducts = product.FilterProducts(1, 6);
            OpenCatalogForm(filteredProducts);
        }

        private void Btn_Categor_2_Click(object sender, EventArgs e)
        {
            List<Product> filteredProducts = product.FilterProducts(7, 12);
            OpenCatalogForm(filteredProducts);
        }

        private void OpenCatalogForm(List<Product> filteredProducts)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Catalog_Form catalog_form = new Catalog_Form(filteredProducts)
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            catalog_form.Show();
        }
    }
}
