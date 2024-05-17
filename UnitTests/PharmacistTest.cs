using Newtonsoft.Json;
using ZdoroviaNaDoloni;
using ZdoroviaNaDoloni.Classes;

namespace UnitTests
{
    public class PharmacistTest
    {
        [Fact]
        public void Pharmacist_SetName_ValidValue()
        {
            var pharmacist = new Pharmacist();
            pharmacist.Name = "Марина";
            Assert.Equal("Марина", pharmacist.Name);
        }

        [Fact]
        public void Pharmacist_SetName_InvalidValue_ThrowsException()
        {
            var pharmacist = new Pharmacist();
            Assert.Throws<ArgumentException>(() => pharmacist.Name = "");
        }

        [Fact]
        public void Pharmacist_SetSurname_ValidValue()
        {
            var pharmacist = new Pharmacist();
            pharmacist.Surname = "Труш";
            Assert.Equal("Труш", pharmacist.Surname);
        }

        [Fact]
        public void Pharmacist_SetSurname_InvalidValue_ThrowsException()
        {
            var pharmacist = new Pharmacist();
            Assert.Throws<ArgumentException>(() => pharmacist.Surname = "");
        }

        [Fact]
        public void Pharmacist_ReceiveOrderCount_ValidOrders_ReturnsOrderCount()
        {
            var pharmacist = new Pharmacist
            {
                Orders = new List<OrderBasket> { new OrderBasket(), new OrderBasket() }
            };
            var count = pharmacist.ReceiveOrderCount();
            Assert.Equal(2, count);
        }

        [Fact]
        public void Pharmacist_ReceiveOrderCount_NoOrders_ThrowsException()
        {
            var pharmacist = new Pharmacist();
            Assert.Throws<InvalidOperationException>(() => pharmacist.ReceiveOrderCount());
        }

        [Fact]
        public void Pharmacist_ReceiveOrders_ValidOrders_ReturnsOrders()
        {
            var expectedOrders = new List<OrderBasket> { new OrderBasket(), new OrderBasket() };
            var pharmacist = new Pharmacist
            {
                Orders = expectedOrders
            };
            var orders = pharmacist.ReceiveOrders();
            Assert.Equal(expectedOrders, orders);
        }

        [Fact]
        public void Pharmacist_ReceiveOrders_NoOrders_ThrowsException()
        {
            var pharmacist = new Pharmacist();
            Assert.Throws<InvalidOperationException>(() => pharmacist.ReceiveOrders());
        }

        [Fact]
        public void Pharmacist_OrderProducts_ValidProducts_AddsOrder()
        {
            var pharmacist = new Pharmacist
            {
                Name = "Марина",
                Surname = "Труш",
                UniquePhoneNumber = "666666666"
            };
            var products = new List<Product> { new Product { Name = "Азітроміцин", Quantity = 10 } };
            pharmacist.OrderProducts(products);
            Assert.Single(pharmacist.Orders);
        }

        [Fact]
        public void Pharmacist_AddFeedback_Valid()
        {
            var pharmacist = new Pharmacist();
            var feedback = new Feedback();
            pharmacist.AddFeedback(feedback);
            Assert.Single(pharmacist.Feedbacks);
        }

        [Fact]
        public void Pharmacist_DeleteFeedback_Valid()
        {
            var pharmacist = new Pharmacist();
            var feedback = new Feedback();
            pharmacist.AddFeedback(feedback);
            pharmacist.DeleteFeedback(feedback);
            Assert.Empty(pharmacist.Feedbacks);
        }

        [Fact]
        public void GetJsonFilePath_ValidPath()
        {
            string relativePath = "products.json";
            string fullPath = Pharmacist.GetJsonFilePath(relativePath);
            Assert.True(fullPath.EndsWith(relativePath));
        }

        [Fact]
        public void Pharmacist_EditProduct_ValidProduct_EditsProduct()
        {
            var product = new Product { Name = "Аугментин (BD)", Description = "таблетки, в/плів. обол. по 875 мг/125 мг", Price = 394 };
            var pharmacist = new Pharmacist();
            pharmacist.EditProduct(product, "Фурадонін", "таблетки по 100 мг", 104);
            Assert.Equal("Фурадонін", product.Name);
            Assert.Equal("таблетки по 100 мг", product.Description);
            Assert.Equal(104, product.Price);
        }
    }
}
