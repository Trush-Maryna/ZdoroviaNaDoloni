using System.Diagnostics;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Product_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Guest_GUI
{
    public partial class Search_Form : Form
    {
        private Point previousLocation;
        private List<Product> products;
        private Product selectedProduct;

        public Search_Form()
        {
            InitializeComponent();
        }

        private void Search_Form_Load(object sender, EventArgs e)
        {
            Product product = new Product();
            products = product.LoadProducts(Constants.productspath);
        }

        private void btn_open_home_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Guest_Home_1 guestForm1 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guestForm1.Show();
        }

        private Search_Form GetLocation() => this;

        private void Btn_tg_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = Constants.TelegramLink,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка відкриття посилання!" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            string query = Txt_Search.Text.ToLower();
            List<Product> searchResults = new Guest().SearchProductsByName(products, query);
            if (searchResults.Count > 0)
            {
                SearchResults.Items.Clear();
                foreach (var product in searchResults)
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

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            string query = Txt_Search.Text.ToLower();
            List<Product> searchResults = new Guest().SearchProductsByName(products, query);
            if (searchResults.Count == 1)
            {
                selectedProduct = searchResults[0];
                previousLocation = GetLocation().Location;
                Hide();
                Info_Guest_Product_Form info_product_Form = new(selectedProduct)
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = previousLocation
                };
                info_product_Form.Show();
            }
        }
    }
}
