using ZdoroviaNaDoloni;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Enums;

namespace UnitTests
{
    public class ProductTest
    {
        [Fact]
        public void Product_Constructor_Initialize()
        {
            string name = "Ibuprofen";
            string description = "Description";
            decimal price = 200;
            int quantity = 5;
            Statuses status = Statuses.InStock;
            Categories category = Categories.Medicines;
            TotalDiscounts totalDiscount = TotalDiscounts.Five;
            List<Feedback>? feedbacks = new List<Feedback>();

            var product = new Product(name, description, price, quantity, status, category, totalDiscount, feedbacks);

            Assert.Equal(name, product.Name);
            Assert.Equal(description, product.Description);
            Assert.Equal(price, product.Price);
            Assert.Equal(quantity, product.Quantity);
            Assert.Equal(status, product.Status);
            Assert.Equal(category, product.Category);
            Assert.Equal(totalDiscount, product.TotalDiscount);
            Assert.Equal(feedbacks, product.Feedbacks);
        }

        [Theory]
        [InlineData("", "Description", 200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Five, null)]
        [InlineData("Ibuprofen", "", 200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Five, null)]
        [InlineData("Ibuprofen", "Description", -200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Five, null)]
        [InlineData("Ibuprofen", "Description", 200, 0, Statuses.InStock, Categories.Medicines, TotalDiscounts.Five, null)]

        public void Product_Constructor_InvalidValues(string name, string description, decimal price, int quantity, Statuses status, Categories category, TotalDiscounts totalDiscount, List<Feedback>? feedbacks)
        {
            Assert.Throws<ArgumentException>(() => new Product(name, description, price, quantity, status, category, totalDiscount, feedbacks));
        }

        [Fact]
        public void Product_With_Feedbacks_ShouldBeSet()
        {
            string name = "Test Product";
            string description = "Test Description";
            decimal price = 10.99m;
            int quantity = 5;
            Statuses status = Statuses.InStock;
            Categories category = Categories.Medicines;
            TotalDiscounts totalDiscount = TotalDiscounts.Null;
            List<Feedback> feedbacks = new List<Feedback>
            {
                new Feedback("Feedback 1", 4, DateTime.Now),
                new Feedback("Feedback 2", 5, DateTime.Now)
            };

            var product = new Product(name, description, price, quantity, status, category, totalDiscount, feedbacks);

            Assert.Equal(feedbacks, product.Feedbacks);
        }
    }
}
