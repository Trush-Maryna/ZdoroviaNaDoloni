using ZdoroviaNaDoloni;

namespace UnitTests
{
    public class ProductTest
    {
        [Fact]
        public void Constructor_ValidParameters()
        {
            var product = new Product(1, "Фурагін", "АТ 'Олайнфарм', Латвія.", "таблетки по 50 мг", 159, 900);
            Assert.Equal(1, product.ID);
            Assert.Equal("Фурагін", product.Name);
            Assert.Equal("АТ 'Олайнфарм', Латвія.", product.Developer);
            Assert.Equal("таблетки по 50 мг", product.Description);
            Assert.Equal(159, product.Price);
            Assert.Equal(900, product.Quantity);
        }

        [Fact]
        public void Constructor_InvalidName_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Product(1, "", "АТ 'Олайнфарм', Латвія.", "таблетки по 50 мг", 159, 900));
        }

        [Fact]
        public void GetProductInfo_ShouldReturnCorrectString()
        {
            var product = new Product(1, "Фурагін", "АТ 'Олайнфарм', Латвія.", "таблетки по 50 мг", 159, 900);
            var expectedInfo = "Назва: Фурагін\nОпис: таблетки по 50 мг\nВиробник: АТ 'Олайнфарм', Латвія.\nЦіна: 159 ₴\nКількість на складі: 900 шт.\n";
            Assert.Equal(expectedInfo, product.GetProductInfo());
        }

        [Fact]
        public void GetJsonFilePath_ShouldReturnCorrectPath()
        {
            string jsonFilePath = "products.json";
            string expectedPath = Path.Combine(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName, jsonFilePath);
            Assert.Equal(expectedPath, Product.GetJsonFilePath(jsonFilePath));
        }

        [Fact]
        public void LoadProducts_ShouldLoadProductsFromJsonFile()
        {
            string jsonFilePath = "Test_products.json";
            string productsJson = "[{\"ID\":1,\"Name\":\"Фурагін\",\"Description\":\"АТ 'Олайнфарм', Латвія.\",\"Price\":159,\"Quantity\":900,\"Developer\":\"АТ 'Олайнфарм', Латвія.\"}]";
            File.WriteAllText(Product.GetJsonFilePath(jsonFilePath), productsJson);
            var products = Product.LoadProducts(jsonFilePath);
            Assert.Single(products);
            Assert.Equal(1, products[0].ID);
            Assert.Equal("Фурагін", products[0].Name);
        }

        [Fact]
        public void GetNextAvailableId_ShouldReturnNextId()
        {
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Фурагін", Description = "АТ 'Олайнфарм', Латвія.", Price = 159, Quantity = 900, Developer = "АТ 'Олайнфарм', Латвія."},
                new Product { ID = 2, Name = "Амоксил", Description = "таблетки по 500 мг", Price = 152, Quantity = 700, Developer = "ПАТ 'Київмедпрепарат', Україна."}
            };
            int nextId = Product.GetNextAvailableId(products);
            Assert.Equal(3, nextId);
        }

        [Fact]
        public void CompareTo_ShouldReturnPositive_WhenThisNameIsGreater()
        {
            var product1 = new Product { Name = "Фурагін" };
            var product2 = new Product { Name = "Амоксил" };
            int result = product1.CompareTo(product2);
            Assert.True(result > 0);
        }
    }
}
