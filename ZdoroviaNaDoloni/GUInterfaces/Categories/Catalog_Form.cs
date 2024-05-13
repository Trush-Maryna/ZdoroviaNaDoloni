using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
using ZdoroviaNaDoloni.GUInterfaces.Product_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Categories
{
    public partial class Catalog_Form : Form
    {
        private Point previousLocation;
        private List<Product> products;
        private Product selectedProduct;
        private Catalog_Form GetLocation() => this;

        public Catalog_Form()
        {
            InitializeComponent();
            Classes.User.UserAuthorized += OnUserAuthorized;
            Classes.User.UserRegistered += OnUserRegistered;
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

                Image originalImage = pictureBox.Image = Image.FromFile(products[i].Image);

                float ratio = (float)originalImage.Height / pictureBox.Height;
                int newWidth = (int)(originalImage.Width / ratio);
                Image resizedImage = new Bitmap(originalImage, newWidth, pictureBox.Height);
                pictureBox.Image = resizedImage;
                originalImage.Dispose();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

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
            selectedProduct = products[index];

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
    }
}