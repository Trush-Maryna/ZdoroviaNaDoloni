using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
using ZdoroviaNaDoloni.GUInterfaces.Product_GUI;
using ZdoroviaNaDoloni.GUInterfaces.Registered_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Feedback
{
    public partial class Add_Feedback_Register_Form : Form
    {
        private Point previousLocation;
        private Add_Feedback_Register_Form GetLocation() => this;
        private bool isStarButtonClicked = false;
        private string jsonPath = Constants.feedbackspath;
        private Product product;

        public Add_Feedback_Register_Form(Product product)
        {
            InitializeComponent();
            Btn_star_1.Click += Btn_star_Click;
            Btn_star_2.Click += Btn_star_Click;
            Btn_star_3.Click += Btn_star_Click;
            Btn_star_4.Click += Btn_star_Click;
            Btn_star_5.Click += Btn_star_Click;
            Btn_star_1.Tag = 1;
            Btn_star_2.Tag = 2;
            Btn_star_3.Tag = 3;
            Btn_star_4.Tag = 4;
            Btn_star_5.Tag = 5;
            this.product = product;
        }

        private void Name_User_Click(object sender, EventArgs e)
        {
            Name_User.Text = "";
        }

        private void Feedback_txt_Click(object sender, EventArgs e)
        {
            Feedback_txt.Text = "";
        }

        private void Btn_star_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                int stars = (int)clickedButton.Tag;
                if (isStarButtonClicked)
                {
                    clickedButton.BackgroundImage = Image.FromFile(Constants.StarHideURL);
                    string starsString = new string('★', stars);
                    Stars_txt.Text = starsString;
                }
                else
                {
                    clickedButton.BackgroundImage = Image.FromFile(Constants.StarOpenURL);
                    string starsString = new string('★', stars);
                    Stars_txt.Text = starsString;
                }

                isStarButtonClicked = !isStarButtonClicked;
            }
        }

        private void Add_feedback_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = Name_User.Text;
                string textFeedback = Feedback_txt.Text;
                int grade = GetSelectedGrade();

                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(textFeedback) && grade > 0)
                {
                    Classes.Feedback newFeedback = new Classes.Feedback(product.ID, textFeedback, grade, DateTime.Now, userName);
                    Classes.Feedback.SaveFeedbackToJson(jsonPath, newFeedback);
                    MessageBox.Show("Фідбек успішно збережено у JSON файлі.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Будь ласка, введіть всі необхідні дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні фідбеку: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedGrade()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button && button.BackgroundImage != null && AreImagesEqual(button.BackgroundImage, Image.FromFile(Constants.StarOpenURL)))
                {
                    return (int)button.Tag;
                }
            }
            return 0;
        }

        private bool AreImagesEqual(Image img1, Image img2)
        {
            using (MemoryStream ms1 = new MemoryStream())
            using (MemoryStream ms2 = new MemoryStream())
            {
                img1.Save(ms1, img1.RawFormat);
                img2.Save(ms2, img2.RawFormat);
                return ms1.ToArray().SequenceEqual(ms2.ToArray());
            }
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