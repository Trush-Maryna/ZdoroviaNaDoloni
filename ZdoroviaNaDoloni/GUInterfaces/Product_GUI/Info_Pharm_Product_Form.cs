using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
using ZdoroviaNaDoloni.GUInterfaces.Pharmacist_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Product_GUI
{
    public partial class Info_Pharm_Product_Form : Form
    {
        private Point previousLocation;
        private readonly Product product;
        private Info_Pharm_Product_Form GetLocation() => this;

        public Info_Pharm_Product_Form()
        {
            InitializeComponent();
            DisplayFeedback();
        }

        public Info_Pharm_Product_Form(Product product)
        {
            InitializeComponent();
            this.product = product;
            DisplayFeedback();
        }

        private void Info_Pharm_Product_Form_Load(object sender, EventArgs e)
        {
            if (product != null)
            {
                Name_Product.Text = product.Name;
                Developer_Product.Text = product.Developer;
                Product_Price.Text = product.Price.ToString();
                Img_Product_Box.Image = Image.FromFile(product.Image);
            }
        }

        private void DisplayFeedback()
        {
            try
            {
                string jsonFilePath = Constants.Instance.feedbackspath;
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

        private void Btn_Map_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Pharmacist_Home_2 pharmacist_Home_2 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharmacist_Home_2.Show();
            ClearForm();
            Hide();
        }

        private void Detailed_Descr_Btn_Click(object sender, EventArgs e)
        {
            string productInfo = product.GetProductInfo();
            MessageBox.Show(productInfo, "Детальна інформація про товар");
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
            Pharmacist_Home_1 pharm_Home_1 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharm_Home_1.Show();
            ClearForm();
            Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Search_Form searchForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            searchForm.Show();
            ClearForm();
            Hide();
        }

        private void pharm_home_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Pharmacist_Home_1 pharm_Home_1 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharm_Home_1.Show();
            ClearForm();
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
            ClearForm();
            Hide();
        }

        private void pharm_user_info_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Pharmacist_Info_Form pharmacist_info_form = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharmacist_info_form.Show();
            ClearForm();
            Hide();
        }
    }
}
