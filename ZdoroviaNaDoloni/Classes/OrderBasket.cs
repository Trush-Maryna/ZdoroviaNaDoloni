using Newtonsoft.Json;
using System.Collections;
using System.Diagnostics;
using ZdoroviaNaDoloni.Classes.Enums;

namespace ZdoroviaNaDoloni.Classes
{
    public class OrderBasket : IEnumerable<Product>
    {
        protected List<Product> orders;
        public static int CounterOrders => CounterOrders;
        public string DeliveryAddress { get; set; }
        public decimal TotalCost { get; private set; }
        public List<Product> Orders => orders;
        public static int СurrentProductBlock { get; set; } = 0;

        protected Dictionary<int, Product> products = new Dictionary<int, Product>();
        public List<Product> CartItems => products.Values.ToList();

        public DiscountCard? DiscountCard { get; set; }

        public OrderBasket()
        {
            orders = new List<Product>();
        }

        public OrderBasket(List<Product>? Orders)
        {
            orders = Orders;
        }

        public OrderBasket(string deliveryAddress)
        {
            DeliveryAddress = !string.IsNullOrWhiteSpace(deliveryAddress) ? deliveryAddress : throw new ArgumentException("Delivery address cannot be empty.");
            orders = new List<Product>();
        }

        public OrderBasket(string deliveryAddress, DiscountCard? discountCard)
            : this(deliveryAddress)
        {
            DiscountCard = discountCard;
        }

        public event Action OrderCompleted = delegate { };

        public void AddProduct(Product product)
        {
            if (СurrentProductBlock < 3)
            {
                products.Add(product.ID, product);
                СurrentProductBlock++;
            }
            else
            {
                throw new InvalidOperationException("Кошик повний.");
            }
        }

        public static string GetJsonFilePath(string jsonFilePath)
        {
            string projectDirectory = Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName;
            return Path.Combine(projectDirectory, jsonFilePath);
        }

        public void SaveProducts(string jsonFilePath, List<Feedback> panelDataList) 
        {
            try
            {
                string jsonPath = GetJsonFilePath(jsonFilePath);

                PanelAndProductsData data;

                if (File.Exists(jsonPath))
                {
                    string existingJson = File.ReadAllText(jsonPath);
                    PanelAndProductsData existingData = JsonConvert.DeserializeObject<PanelAndProductsData>(existingJson);
                    existingData.PanelDataList.AddRange(panelDataList);
                    data = existingData;
                }
                else
                {
                    data = new PanelAndProductsData
                    {
                        PanelDataList = panelDataList
                    };
                }
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(jsonPath, json);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RestorePanelStateAndProductsFromJson(string jsonFilePath, List<Panel> productPanels)
        {
            try
            {
                string jsonPath = GetJsonFilePath(jsonFilePath);

                if (File.Exists(jsonPath))
                {
                    string json = File.ReadAllText(jsonPath);
                    PanelAndProductsData panelAndProductsData = JsonConvert.DeserializeObject<PanelAndProductsData>(json);

                    HideAllProductPanels(productPanels);

                    СurrentProductBlock = panelAndProductsData.PanelDataList.Count;

                    for (int i = 0; i < СurrentProductBlock && i < productPanels.Count; i++)
                    {
                        Feedback panelData = panelAndProductsData.PanelDataList[i];
                        productPanels[i].Visible = panelData.PanelVisible;
                        if (panelData.Product != null)
                        {
                            ShowProducts(productPanels[i], i + 1, panelData.Product);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void HideAllProductPanels(List<Panel> productPanels)
        {
            foreach (var panel in productPanels)
            {
                panel.Visible = false;
            }
        }

        public void ShowProducts(Panel nextPanel, int index, Product product)
        {
            var pictureBoxArray = nextPanel.Controls.Find($"Img_Product_{index}", true);
            var nameLabelArray = nextPanel.Controls.Find($"Name_Product_{index}", true);
            var quantityLabelArray = nextPanel.Controls.Find($"Product_Quantity_{index}", true);
            var priceLabelArray = nextPanel.Controls.Find($"Product_Price_{index}", true);

            if (pictureBoxArray.Length > 0 && nameLabelArray.Length > 0 &&
                quantityLabelArray.Length > 0 && priceLabelArray.Length > 0)
            {
                var pictureBox = (PictureBox)pictureBoxArray[0];
                var nameLabel = (Label)nameLabelArray[0];
                var quantityLabel = (Label)quantityLabelArray[0];
                var priceLabel = (Label)priceLabelArray[0];

                Image originalImage = pictureBox.Image = Image.FromFile(product.Image);
                float ratio = (float)originalImage.Height / pictureBox.Height;
                int newWidth = (int)(originalImage.Width / ratio);
                Image resizedImage = new Bitmap(originalImage, newWidth, pictureBox.Height);
                pictureBox.Image = resizedImage;
                originalImage.Dispose();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                nameLabel.Text = product.Name;
                quantityLabel.Text = product.Quantity.ToString();
                priceLabel.Text = product.Price.ToString();

                nextPanel.Visible = true;
            }
        }

        public Panel? GetNextAvailablePanel(int desiredIndex, List<Panel> productPanels)
        {
            for (int i = desiredIndex - 1; i < productPanels.Count; i++)
            {
                Panel panel = productPanels[i];
                if (!panel.Visible)
                {
                    panel.Visible = true;
                    return panel;
                }
            }
            return null;
        }

        public void ShowPanel(int panelIndex, List<Panel> productPanels)
        {
            if (panelIndex < productPanels.Count)
            {
                if (panelIndex > 0 && productPanels[panelIndex - 1].Visible)
                {
                    productPanels[panelIndex].Visible = true;
                }
                else if (panelIndex == 0)
                {
                    productPanels[panelIndex].Visible = true;
                }
            }
        }

        public void ClearJsonFile(string jsonFilePath)
        {
            string jsonPath = GetJsonFilePath(jsonFilePath);

            if (File.Exists(jsonPath))
            {
                File.Delete(jsonPath);
            }
            else
            {
                throw new Exception("Кошик пустий.");
            }
        }

        public class Feedback
        {
            public bool PanelVisible { get; set; }
            public Product Product { get; set; }
        }

        public class PanelAndProductsData
        {
            public List<Feedback> PanelDataList { get; set; }
        }

        public bool IsProductAdd(string jsonFilePath, Product product)
        {
            try
            {
                string jsonPath = GetJsonFilePath(jsonFilePath);

                if (File.Exists(jsonPath))
                {
                    string json = File.ReadAllText(jsonPath);
                    PanelAndProductsData panelAndProductsData = JsonConvert.DeserializeObject<PanelAndProductsData>(json);

                    if (panelAndProductsData.PanelDataList.Any(panelData => panelData.Product.Name == product.Name && panelData.Product.ID == product.ID))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public void DeleteProductWithFile(string jsonFilePath, int productId)
        {
            try
            {
                string jsonPath = GetJsonFilePath(jsonFilePath);

                if (File.Exists(jsonPath))
                {
                    string json = File.ReadAllText(jsonPath);
                    PanelAndProductsData panelAndProductsData = JsonConvert.DeserializeObject<PanelAndProductsData>(json);

                    products.Remove(productId);

                    panelAndProductsData.PanelDataList.RemoveAll(panelData => panelData.Product.ID == productId);

                    SavePanelData(jsonPath, panelAndProductsData);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void SavePanelData(string jsonFilePath, PanelAndProductsData panelAndProductsData)
        {
            try
            {
                string jsonPath = GetJsonFilePath(jsonFilePath);

                string json = JsonConvert.SerializeObject(panelAndProductsData, Formatting.Indented);
                File.WriteAllText(jsonPath, json);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetProductIdFromJson(string jsonFilePath, int panelIndex)
        {
            try
            {
                string jsonPath = GetJsonFilePath(jsonFilePath);

                if (File.Exists(jsonPath))
                {
                    string json = File.ReadAllText(jsonPath);
                    PanelAndProductsData panelAndProductsData = JsonConvert.DeserializeObject<PanelAndProductsData>(json);

                    if (panelIndex < panelAndProductsData.PanelDataList.Count)
                    {
                        return panelAndProductsData.PanelDataList[panelIndex].Product.ID;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(nameof(panelIndex), "ID не знайдено.");
                    }
                }
                else
                {
                    throw new FileNotFoundException("JSON файл не знайдено.", jsonPath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка при отриманні ID товару з JSON: " + ex.Message);
            }
        }

        public void HideOneProductPanels(int index, List<Panel> productPanels)
        {
            Panel panelToRemove = productPanels[index];
            panelToRemove.Visible = false;
        }

        public decimal GetProductPriceByIndex(string jsonFilePath, int index)
        {
            string jsonPath = GetJsonFilePath(jsonFilePath);

            if (File.Exists(jsonPath))
            {
                string jsonContent = File.ReadAllText(jsonPath);
                PanelAndProductsData panelAndProductsData = JsonConvert.DeserializeObject<PanelAndProductsData>(jsonContent);

                if (index < panelAndProductsData.PanelDataList.Count)
                {
                    var product = panelAndProductsData.PanelDataList[index].Product;
                    if (product != null)
                    {
                        return product.Price;
                    }
                }
            }
            return 0;
        }

        public List<Feedback> RestoreFileJson(string jsonFilePath)
        {
            try
            {
                List<Feedback> panelDataList = new List<Feedback>();
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);
                    PanelAndProductsData data = JsonConvert.DeserializeObject<PanelAndProductsData>(json);
                    panelDataList = data.PanelDataList;
                }
                else
                {
                    throw new Exception("Файл JSON не знайдено");
                }
                return panelDataList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при зчитуванні даних з JSON: {ex.Message}");
            }
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return products.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}