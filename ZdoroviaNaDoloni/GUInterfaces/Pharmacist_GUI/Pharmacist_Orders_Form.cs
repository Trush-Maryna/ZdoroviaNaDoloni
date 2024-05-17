using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.GUInterfaces.Guest_GUI;

namespace ZdoroviaNaDoloni.GUInterfaces.Pharmacist_GUI
{
    public partial class Pharmacist_Orders_Form : Form
    {
        private Point previousLocation;
        private string json = Constants.Instance.receiptpath;
        private List<string> existingFiles = new List<string>();
        private Pharmacist_Orders_Form GetLocation() => this;

        public Pharmacist_Orders_Form()
        {
            InitializeComponent();
        }

        private void Pharmacist_Orders_Form_Load(object sender, EventArgs e)
        {
            LoadExistingOrderReceiptFiles();
        }

        private void LoadExistingOrderReceiptFiles()
        {
            try
            {
                existingFiles = ReceiptWord.GetExistingOrderReceiptFiles(json);

                Orders_Box.Items.Clear();

                foreach (string file in existingFiles)
                {
                    Orders_Box.Items.Add(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні файлів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Orders_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFileName = Orders_Box.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedFileName))
            {
                string basePath = json;
                string fullFilePath = Path.Combine(basePath, selectedFileName);

                if (File.Exists(fullFilePath))
                {
                    ReceiptWord.OpenReceiptFile(fullFilePath);
                    Orders_Box.Items.Remove(selectedFileName);
                    existingFiles.Remove(selectedFileName);
                }
                else
                {
                    MessageBox.Show($"Файл '{selectedFileName}' не існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Orders_Box_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0 && (e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                ListBox listBox = sender as ListBox;
                e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
                e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);
            }
            else
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
            }
        }

        private void pharm_home_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Pharmacist_Home_1 pharmForm1 = new Pharmacist_Home_1()
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
            Categories_Form categorForm = new Categories_Form()
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
            Pharmacist_Info_Form pharmInfoForm = new Pharmacist_Info_Form()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            pharmInfoForm.Show();
            Hide();
        }
    }
}
