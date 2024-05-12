using ZdoroviaNaDoloni.GUInterfaces.Feedback;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
using ZdoroviaNaDoloni.GUInterfaces.Registered_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Product_GUI
{
    public partial class Info_Registered_Product_Form : Form
    {
        private Point previousLocation;
        private readonly Product product;
        private Order_Basket_Register_Form orderBasketRegisterForm;
        private Add_Feedback_Register_Form feedbackRegisterForm;

        private Info_Registered_Product_Form GetLocation() => this;

        public Info_Registered_Product_Form()
        {
            InitializeComponent();
        }

        public Info_Registered_Product_Form(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void Info_Registered_Product_Form_Load(object sender, EventArgs e)
        {
            Name_Product.Text = product.Name;
            Developer_Product.Text = product.Developer;
            Product_Price.Text = product.Price.ToString();
            Img_Product_Box.Image = Image.FromFile(product.Image);
        }

        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            if (orderBasketRegisterForm == null || orderBasketRegisterForm.IsDisposed)
            {
                orderBasketRegisterForm = new Order_Basket_Register_Form
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = previousLocation
                };
                orderBasketRegisterForm.AddProductToPanel(product);
                orderBasketRegisterForm.Show();
            }
        }

        private void Btn_Map_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Registered_Home_2 registered_Home_2 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registered_Home_2.Show();
        }

        private void Detailed_Descr_Btn_Click(object sender, EventArgs e)
        {
            string productInfo = product.GetProductInfo();
            MessageBox.Show(productInfo, "Детальна інформація про товар");
        }

        private void Add_feedback_btn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            previousLocation = GetLocation().Location;
            Hide();
            Add_Feedback_Register_Form feedbackForm = new(product)
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            feedbackRegisterForm.AddProductToFeedback(product);
            feedbackForm.Show();
        }

        private void btn_open_home_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Registered_Home_1 registered_Home_1 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registered_Home_1.Show();
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

        private void register_home_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Registered_Home_1 registered_Home_1 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registered_Home_1.Show();
        }

        private void register_categor_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Categories_Form categorForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            categorForm.Show();
        }

        private void register_cart_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Order_Basket_Register_Form order_Basket_Register_Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            order_Basket_Register_Form.Show();
        }

        private void register_user_info_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Registered_Info_Form registered_Info_Form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registered_Info_Form.Show();
        }
    }
}
