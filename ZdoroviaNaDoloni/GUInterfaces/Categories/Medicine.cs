using ZdoroviaNaDoloni.GUInterfaces.Categories;

namespace ZdoroviaNaDoloni.GUInterfaces.Guest_GUI
{
    public partial class Medicine : Form
    {
        private Point previousLocation;
        private Medicine GetLocation() => this;
        private List<Product> products;

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
            Product product = new Product();
            products = product.LoadProducts(Constants.productsSmallpath);
            List<Product> filteredProducts = products.Where(p => p.ID >= 1 && p.ID <= 6).ToList();
            previousLocation = GetLocation().Location;
            Hide();
            Catalog_Form catalog_form = new Catalog_Form(filteredProducts)
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            catalog_form.Show();
        }

        private void Btn_Categor_2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            products = product.LoadProducts(Constants.productsSmallpath);
            List<Product> filteredProducts = products.Where(p => p.ID >= 7 && p.ID <= 12).ToList();
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
