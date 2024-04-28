using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
using ZdoroviaNaDoloni.GUInterfaces.Product_GUI;
using ZdoroviaNaDoloniUser = ZdoroviaNaDoloni.Classes.User;

namespace ZdoroviaNaDoloni.GUInterfaces.Categories
{
    public partial class Catalog_Form : Form
    {
        private Point previousLocation;
        private Catalog_Form GetLocation() => this;
        private List<Product> products;
        private ZdoroviaNaDoloniUser loggedInSignedInUser;
        private Product selectedProduct;

        public Catalog_Form()
        {
            InitializeComponent();
            this.loggedInSignedInUser = loggedInSignedInUser;
            loggedInSignedInUser.UserAuthorized += OnUserAuthorized;
            loggedInSignedInUser.UserRegistered += OnUserRegistered;
        }

        public Catalog_Form(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
            DisplayProducts();
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

        private void DisplayProducts()
        {
            int count = Math.Min(products.Count, 6);

            for (int i = 0; i < count; i++)
            {
                PictureBox pictureBox = (PictureBox)Controls.Find($"Img_Product_Box_{i + 1}", true)[0];
                Label nameLabel = (Label)Controls.Find($"Name_Product_{i + 1}", true)[0];
                Label developerLabel = (Label)Controls.Find($"Developer_Product_{i + 1}", true)[0];
                Label priceLabel = (Label)Controls.Find($"Product_Price_{i + 1}", true)[0];
                Button buyButton = (Button)Controls.Find($"Btn_Buy_{i + 1}", true)[0];

                pictureBox.Image = Image.FromFile(products[i].Image);
                nameLabel.Text = products[i].Name;
                developerLabel.Text = products[i].Developer;
                priceLabel.Text = $"{products[i].Price}";
                buyButton.Tag = i;
                buyButton.Click += Btn_Buy_Click;
            }
        }

        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int index = int.Parse(button.Tag.ToString());
            Product product = new Product();
            products = product.LoadProducts(Constants.productspath);
            selectedProduct = products[index];

            if (loggedInSignedInUser is Registered || loggedInSignedInUser is Pharmacist)
            {
                OpenInfoProductForm(selectedProduct);
            }
            else 
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
        }

        private void OnUserAuthorized(Classes.User user)
        {
            if (user is Registered || user is Pharmacist)
            {
                OpenInfoProductForm(selectedProduct);
            }
        }

        private void OnUserRegistered(Classes.User user)
        {
            if (user is Registered)
            {
                OpenInfoProductForm(selectedProduct);
            }
        }

        private void OpenInfoProductForm(Product selectedProduct)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Info_Product_Form infoProductForm = new(selectedProduct)
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            infoProductForm.Show();
        }
    }
}
