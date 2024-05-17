using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Pharmacist_GUI
{
    public partial class Pharmacist_Products_Form : Form
    {
        private Point previousLocation;
        private List<Product> products;
        private Pharmacist_Products_Form GetLocation() => this;

        public Pharmacist_Products_Form()
        {
            InitializeComponent();
        }

        private void Pharmacist_Products_Form_Load(object sender, EventArgs e)
        {
            products = Product.LoadProducts(Constants.Instance.productspath);
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            string query = Txt_Search.Text.ToLower();
            List<Product> searchResultsGuest = new Guest().SearchProductsByName(products, query);
            if (searchResultsGuest.Count > 0)
            {
                SearchResults.Items.Clear();
                foreach (var product in searchResultsGuest)
                {
                    SearchResults.Items.Add(product.Name);
                }
                SearchResults.Visible = true;
            }
            else
            {
                SearchResults.Items.Clear();
                SearchResults.Visible = false;
            }
        }

        private void Txt_Search_Click(object sender, EventArgs e)
        {
            Txt_Search.Text = "";
        }

        private void SearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchResults.SelectedItem != null)
            {
                string selectedProduct = SearchResults.SelectedItem.ToString();
                Txt_Search.Text = selectedProduct;
            }
        }

        private void pharm_home_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Pharmacist_Home_1 pharmForm1 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharmForm1.Show();
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

        private void pharm_user_info_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Pharmacist_Info_Form pharmInfoForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharmInfoForm.Show();
            Hide();
        }

        private void Btn_Add_product_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Pharmacist_Add_Product_Form pharmAddProductForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharmAddProductForm.Show();
            Hide();
        }
    }
}
