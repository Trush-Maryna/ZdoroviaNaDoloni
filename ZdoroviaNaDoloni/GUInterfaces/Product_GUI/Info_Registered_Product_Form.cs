using ZdoroviaNaDoloni.GUInterfaces.Feedback;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
using ZdoroviaNaDoloni.GUInterfaces.Registered_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Product_GUI
{
    public partial class Info_Registered_Product_Form : Form
    {
        private Point previousLocation;
        private readonly Product product;
        private string jsonPath = Constants.feedbackspath;
        private Order_Basket_Register_Form orderBasketRegisterForm;

        private Info_Registered_Product_Form GetLocation() => this;

        public Info_Registered_Product_Form()
        {
            InitializeComponent();
        }

        public Info_Registered_Product_Form(Product product)
        {
            InitializeComponent();
            this.product = product;
            DisplayFeedback();
        }

        private void Info_Registered_Product_Form_Load(object sender, EventArgs e)
        {
            Name_Product.Text = product.Name;
            Developer_Product.Text = product.Developer;
            Product_Price.Text = product.Price.ToString();
            Img_Product_Box.Image = Image.FromFile(product.Image);
        }

        private void DisplayFeedback()
        {
            try
            {
                string jsonFilePath = jsonPath;
                Classes.Feedback feedback = Classes.Feedback.GetRandomFeedbackFromJson(jsonFilePath);

                if (feedback != null)
                {
                    User_or_phone.Text = feedback.UserName;
                    Star_Lbl.Text = Classes.Feedback.GetStarsString(feedback.Grade);
                    Feedback_txt.Text = feedback.TextFeedback;
                }
                else
                {
                    User_or_phone.Text = "Відгуків немає";
                    Star_Lbl.Text = "";
                    Feedback_txt.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            ClearForm();
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
            ClearForm();
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
            previousLocation = GetLocation().Location;
            ClearForm();
            Hide();
            Add_Feedback_Register_Form feedbackForm = new Add_Feedback_Register_Form(product)
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            feedbackForm.Show();
        }

        private void ClearForm()
        {
            Name_Product.Text = "";
            Developer_Product.Text = "";
            Product_Price.Text = "";
            Img_Product_Box.Image = null;
        }

        private void btn_open_home_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            ClearForm();
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
            ClearForm();
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
            ClearForm();
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
            ClearForm();
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
            ClearForm();
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
            ClearForm();
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
