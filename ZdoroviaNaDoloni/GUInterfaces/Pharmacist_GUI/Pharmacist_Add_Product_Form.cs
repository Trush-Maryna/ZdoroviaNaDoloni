using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;
using System.IO;
using System.Windows.Forms;

namespace ZdoroviaNaDoloni.GUInterfaces.Pharmacist_GUI
{
    public partial class Pharmacist_Add_Product_Form : Form
    {
        private Point previousLocation;
        private string json = Constants.productspath;
        private Pharmacist_Add_Product_Form GetLocation() => this;

        public Pharmacist_Add_Product_Form()
        {
            InitializeComponent();
        }

        private void Choice_picture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Зображення|*.jpg;*.jpeg;*.png;*.gif|Всі файли|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pictr_product.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Btn_Add_product_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Product.GetNextAvailableId(Product.LoadProducts(json));
                string name = Name_product_txt.Text;
                string developer = Develop_product_txt.Text;
                string descr = Descr_product_txt.Text;
                decimal price = decimal.Parse(Price_product_txt.Text);
                int quantity = int.Parse(Quant_product_txt.Text);
                string image = Pictr_product.ImageLocation;
                Product newProduct = new(id, name, developer, descr, price, quantity);
                newProduct.Image = image;
                Product.AddProductToJson(newProduct, json);
                MessageBox.Show("Новий продукт успішно додано!");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            Name_product_txt.Text = "";
            Develop_product_txt.Text = "";
            Descr_product_txt.Text = "";
            Price_product_txt.Text = "";
            Quant_product_txt.Text = "";
            Pictr_product.Image = null;
        }

        private void pharm_home_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Pharmacist_Home_1 pharmForm1 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharmForm1.Show();
        }

        private void pharm_categor_btn_Click(object sender, EventArgs e)
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

        private void pharm_user_info_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Hide();
            Pharmacist_Info_Form pharmInfoForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharmInfoForm.Show();
        }
    }
}
