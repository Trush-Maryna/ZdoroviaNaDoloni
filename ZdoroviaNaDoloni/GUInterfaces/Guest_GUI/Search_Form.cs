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
        private string json = Constants.productspath;
        private Search_Form GetLocation() => this;

        public Search_Form()
        {
            InitializeComponent();
            Classes.User.UserAuthorized += OnUserAuthorized;
            Classes.User.UserRegistered += OnUserRegistered;
        }

        private void Search_Form_Load(object sender, EventArgs e)
        {
            products = Product.LoadProducts(json);
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

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            string query = Txt_Search.Text.ToLower();
            List<Product> searchResults = new Guest().SearchProductsByName(products, query);
            if (searchResults.Count == 1)
            {
                selectedProduct = searchResults[0];
                if (!Classes.User.IsRegistered && !Classes.User.IsAuthorized)
                {
                    previousLocation = GetLocation().Location;
                    Hide();
                    Info_Guest_Product_Form infoGuestProductForm = new(selectedProduct)
                    {
                        StartPosition = FormStartPosition.Manual,
                        Location = previousLocation
                    };
                    infoGuestProductForm.Show();
                }
                else if (Classes.User.IsRegistered)
                {
                    OnUserRegistered(Classes.User.CurrentUser);
                }
                else if (Classes.User.IsAuthorized)
                {
                    OnUserAuthorized(Classes.User.CurrentUser);
                }
            }
        }

        private void OnUserRegistered(Classes.User user)
        {
            if (user != null)
            {
                Classes.User.IsRegistered = true;
                OpenInfoRegisterProductForm(selectedProduct);
            }
        }

        private void OnUserAuthorized(Classes.User user)
        {
            if (user != null)
            {
                Classes.User.IsAuthorized = true;
                if (user is Pharmacist)
                {
                    OpenInfoPharmProductForm(selectedProduct);
                }
                else
                {
                    OpenInfoRegisterProductForm(selectedProduct);
                }
            }
        }

        private void OpenInfoRegisterProductForm(Product selectedProduct)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Info_Registered_Product_Form infoProductForm = new(selectedProduct)
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            infoProductForm.Show();
        }

        private void OpenInfoPharmProductForm(Product selectedProduct)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Info_Pharm_Product_Form infoProductForm = new(selectedProduct)
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            infoProductForm.Show();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> products = Product.LoadProducts(json);
                Product selectedProduct = products.FirstOrDefault(p => p.ID == 13);

                if (selectedProduct != null)
                {
                    if (!Classes.User.IsRegistered && !Classes.User.IsAuthorized)
                    {
                        previousLocation = GetLocation().Location;
                        Hide();
                        Info_Guest_Product_Form infoGuestProductForm = new(selectedProduct)
                        {
                            StartPosition = FormStartPosition.Manual,
                            Location = previousLocation
                        };
                        infoGuestProductForm.Show();
                    }
                    else if (Classes.User.IsRegistered)
                    {
                        OnUserRegistered(Classes.User.CurrentUser);
                    }
                    else if (Classes.User.IsAuthorized)
                    {
                        OnUserAuthorized(Classes.User.CurrentUser);
                    }
                }
                else
                {
                    MessageBox.Show("Продукт з не знайдено.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}");
            }
        }

        private void Btn_tg_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Constants.TelegramLink,
                UseShellExecute = true
            };
            Process.Start(psi);
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
    }
}
