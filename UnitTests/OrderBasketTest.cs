using ZdoroviaNaDoloni;
using ZdoroviaNaDoloni.Classes;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace UnitTests
{
    public class OrderBasketTest
    {
        [Fact]
        public void Constructor_ShouldInitializeOrderBasket()
        {
            var orderBasket = new OrderBasket();
            Assert.NotNull(orderBasket.Orders);
            Assert.Empty(orderBasket.Orders);
        }

        [Fact]
        public void AddProduct_ShouldAddProductToBasket()
        {
            var orderBasket = new OrderBasket();
            var product = new Product { ID = 1, Name = "Фурагін", Quantity = 900 };
            orderBasket.AddProduct(product);
            Assert.Single(orderBasket.CartItems);
            Assert.Equal(product, orderBasket.CartItems.First());
        }

        [Fact]
        public void NumTel_SetInvalidPhoneNumber()
        {
            var orderBasket = new OrderBasket();
            Assert.Throws<Exception>(() => orderBasket.NumTel = "123");
        }

        [Fact]
        public void GetJsonFilePath_ShouldReturnCorrectPath()
        {
            string jsonFilePath = "orders.json";
            string expectedPath = Path.Combine(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName, jsonFilePath);
            Assert.Equal(expectedPath, OrderBasket.GetJsonFilePath(jsonFilePath));
        }

        [Fact]
        public void SaveProducts_ShouldSaveProductsToJsonFile()
        {
            string jsonFilePath = "orders_test.json";
            var feedbackList = new List<OrderBasket.Feedback>
            {
                new OrderBasket.Feedback { PanelVisible = true, Product = new Product { ID = 1, Name = "Фурагін", Quantity = 900 } }
            };
            var orderBasket = new OrderBasket();
            orderBasket.SaveProducts(jsonFilePath, feedbackList);
            string jsonPath = OrderBasket.GetJsonFilePath(jsonFilePath);
            string json = File.ReadAllText(jsonPath);
            var data = JsonConvert.DeserializeObject<OrderBasket.PanelAndProductsData>(json);
            Assert.Single(data.PanelDataList);
            Assert.Equal(feedbackList[0].Product.ID, data.PanelDataList[0].Product.ID);
        }

        [Fact]
        public void RestorePanelStateAndProductsFromJson_ShouldRestorePanels()
        {
            string jsonFilePath = "orders_test.json";
            var feedbackList = new List<OrderBasket.Feedback>
            {
                new OrderBasket.Feedback { PanelVisible = true, Product = new Product { ID = 1, Name = "Фурагін", Quantity = 900 } }
            };
            var data = new OrderBasket.PanelAndProductsData { PanelDataList = feedbackList };
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(OrderBasket.GetJsonFilePath(jsonFilePath), json);
            var panels = new List<Panel> { new Panel { Visible = false } };
            var orderBasket = new OrderBasket();
            orderBasket.RestorePanelStateAndProductsFromJson(jsonFilePath, panels);
            Assert.True(panels[0].Visible);
        }

        [Fact]
        public void ClearJsonFile_ShouldDeleteJsonFile()
        {
            string jsonFilePath = "orders_test.json";
            File.WriteAllText(OrderBasket.GetJsonFilePath(jsonFilePath), "{}");
            var orderBasket = new OrderBasket();
            orderBasket.ClearJsonFile(jsonFilePath);
            Assert.False(File.Exists(OrderBasket.GetJsonFilePath(jsonFilePath)));
        }

        [Fact]
        public void DeleteProductWithFile_ShouldRemoveProductFromJson()
        {
            string jsonFilePath = "orders_test.json";
            var feedbackList = new List<OrderBasket.Feedback>
            {
                new OrderBasket.Feedback { PanelVisible = true, Product = new Product { ID = 1, Name = "Фурагін", Quantity = 900 } }
            };
            var data = new OrderBasket.PanelAndProductsData { PanelDataList = feedbackList };
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(OrderBasket.GetJsonFilePath(jsonFilePath), json);
            var orderBasket = new OrderBasket();
            orderBasket.DeleteProductWithFile(jsonFilePath, 1);
            string newJson = File.ReadAllText(OrderBasket.GetJsonFilePath(jsonFilePath));
            var newData = JsonConvert.DeserializeObject<OrderBasket.PanelAndProductsData>(newJson);
            Assert.Empty(newData.PanelDataList);
        }

        [Fact]
        public void GetProductPriceByIndex_ShouldReturnCorrectPrice()
        {
            string jsonFilePath = "orders_test.json";
            var feedbackList = new List<OrderBasket.Feedback>
            {
                new OrderBasket.Feedback { PanelVisible = true, Product = new Product { ID = 1, Name = "Фурагін", Price = 159, Quantity = 900 } }
            };
            var data = new OrderBasket.PanelAndProductsData { PanelDataList = feedbackList };
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(OrderBasket.GetJsonFilePath(jsonFilePath), json);
            var orderBasket = new OrderBasket();
            decimal price = orderBasket.GetProductPriceByIndex(jsonFilePath, 0);
            Assert.Equal(159, price);
        }

        [Fact]
        public void RestoreFileJson_ShouldReturnFeedbackList()
        {
            string jsonFilePath = "feedback_test.json";
            var feedbackList = new List<OrderBasket.Feedback>
            {
                new OrderBasket.Feedback { PanelVisible = true, Product = new Product { ID = 1, Name = "Фурагін", Quantity = 900 } }
            };
            var data = new OrderBasket.PanelAndProductsData { PanelDataList = feedbackList };
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(OrderBasket.GetJsonFilePath(jsonFilePath), json);
            var orderBasket = new OrderBasket();
            var restoredFeedbackList = orderBasket.RestoreFileJson(OrderBasket.GetJsonFilePath(jsonFilePath));
            Assert.Single(restoredFeedbackList);
            Assert.Equal(feedbackList[0].Product.ID, restoredFeedbackList[0].Product.ID);
        }

        [Fact]
        public void GetEnumerator_ShouldReturnProductsEnumerator()
        {
            var orderBasket = new OrderBasket();
            var product1 = new Product { ID = 1, Name = "Фурагін", Quantity = 900 };
            var product2 = new Product { ID = 2, Name = "Спазмалгон", Quantity = 50 };
            orderBasket.AddProduct(product1);
            orderBasket.AddProduct(product2);
            var enumerator = orderBasket.GetEnumerator();
            var products = new List<Product>();
            while (enumerator.MoveNext())
            {
                products.Add(enumerator.Current);
            }
            Assert.Equal(2, products.Count);
            Assert.Contains(product1, products);
            Assert.Contains(product2, products);
        }
    }
}
