using ZdoroviaNaDoloni;
using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.Classes;

namespace UnitTests
{
    public class OrderBasketTest
    {
        [Fact]
        public void Add_Product_ToOrderList_SelfPickup()
        {
            var orderBasket = new OrderBasket("Address", DeliveryMethods.SelfPickup);
            var product = new Product("Ibuprofen", "Description", 200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null);

            orderBasket.AddProducts(product, new List<Product>());

            Assert.Contains(product, orderBasket.Orders);
        }

        [Fact]
        public void Add_Product_ToOrderList_DeliveryService()
        {
            var orderBasket = new OrderBasket("PostalService", DeliveryMethods.DeliveryService);
            var product = new Product("Ibuprofen", "Description", 200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null);

            orderBasket.AddProducts(product, new List<Product>());

            Assert.Contains(product, orderBasket.Orders);
        }

        [Fact]
        public void Remove_Product_FromOrderList()
        {
            var product = new Product("Ibuprofen", "Description", 200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null);
            var orderBasket = new OrderBasket("Address", DeliveryMethods.SelfPickup, null);
            orderBasket.AddProducts(product, new List<Product>());

            orderBasket.DeleteProducts(product, new List<Product>());

            Assert.DoesNotContain(product, orderBasket.Orders);
        }

        [Fact]
        public void Constructor_With_ValidParameters()
        {
            string deliveryAddress = "Address";
            DeliveryMethods deliveryMethod = DeliveryMethods.SelfPickup;

            var orderBasket = new OrderBasket(deliveryAddress, deliveryMethod);

            Assert.Equal(deliveryAddress, orderBasket.DeliveryAddress);
            Assert.Equal(deliveryMethod, orderBasket.DeliveryMethod);
        }

        [Fact]
        public void Constructor_With_DiscountCard()
        {
            string deliveryAddress = "Address";
            DeliveryMethods deliveryMethod = DeliveryMethods.SelfPickup;
            var discountCard = new DiscountCard("1234567890123", "Trush", "Maryna", null, DateTime.Now);

            var orderBasket = new OrderBasket(deliveryAddress, deliveryMethod, discountCard);

            Assert.Equal(deliveryAddress, orderBasket.DeliveryAddress);
            Assert.Equal(deliveryMethod, orderBasket.DeliveryMethod);
            Assert.Equal(discountCard, orderBasket.DiscountCard);
        }

        [Fact]
        public void Constructor_With_InvalidParameters()
        {
            string deliveryAddress = "";
            DeliveryMethods deliveryMethod = DeliveryMethods.SelfPickup;

            Assert.Throws<ArgumentException>(() => new OrderBasket(deliveryAddress, deliveryMethod));
        }

        [Fact]
        public void Calculate_TotalCost_Correctly()
        {
            var product1 = new Product("Ibuprofen", "Description", 100, 2, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null);
            var product2 = new Product("Analgin", "Description", 50, 3, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null);
            var orderBasket = new OrderBasket("Address", DeliveryMethods.SelfPickup);
            orderBasket.AddProducts(product1, new List<Product>());
            orderBasket.AddProducts(product2, new List<Product>());

            OrderBasket.CalculateTotalCost(orderBasket.Orders);

            Assert.Equal(100 * 2 + 50 * 3, orderBasket.TotalCost);
        }

        [Fact]
        public void Transfer_OrderDetails_Correctly()
        {
            var product1 = new Product("Ibuprofen", "Description", 100, 2, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null);
            var product2 = new Product("Analgin", "Description", 200, 5, Statuses.InStock, Categories.VitaminsAndMinerals, TotalDiscounts.Five, null);
            var orderBasket = new OrderBasket("Address", DeliveryMethods.SelfPickup);
            orderBasket.AddProducts(product1, new List<Product>());
            orderBasket.AddProducts(product2, new List<Product>());

            orderBasket.TransferOrderDetails();
        }
    }
}
