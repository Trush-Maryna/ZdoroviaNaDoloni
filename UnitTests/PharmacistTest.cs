using ZdoroviaNaDoloni;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Enums;

namespace UnitTests
{
    public class PharmacistTest
    {
        [Fact]
        public void Pharmacist_Add_Feedback()
        {
            var pharmacist = new Pharmacist("pharm_Maryna@google.com");
            var fb = new Feedback("Feedback 1", 4, DateTime.Now);

            pharmacist.AddFeedback(fb);

            Assert.Contains(fb, pharmacist.Feedbacks);
        }

        [Fact]
        public void Pharmacist_Delete_Feedback()
        {
            var pharmacist = new Pharmacist("pharm_Maryna@google.com");
            var fb = new Feedback("Feedback 1", 4, DateTime.Now);
            pharmacist.Feedbacks = new List<Feedback> { fb };

            pharmacist.DeleteFeedback(fb);

            Assert.DoesNotContain(fb, pharmacist.Feedbacks);
        }

        [Fact]
        public void Pharmacist_Edit_Product()
        {
            var pharmacist = new Pharmacist("pharm_Maryna@google.com");
            var product = new Product("Ibuprofen", "Description", 200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null);
            var newName = "Ibuprofen125";
            var newDescription = "New Description";
            var newPrice = 150;

            pharmacist.EditProduct(product, newName, newDescription, newPrice);

            Assert.Equal(newName, product.Name);
            Assert.Equal(newDescription, product.Description);
            Assert.Equal(newPrice, product.Price);
        }

        [Fact]
        public void Pharmacist_Add_DiscountCard_Success()
        {
            var pharmacist = new Pharmacist("pharm_Maryna@google.com");
            var card = new DiscountCard("1234567890123", "Trush", "Maryna", null, DateTime.Now);

            pharmacist.AddDiscountCard(card);

            Assert.Contains(card, pharmacist.Cards);
        }

        [Fact]
        public void Pharmacist_Remove_DiscountCard_Success()
        {
            var pharmacist = new Pharmacist("pharm_Maryna@google.com");
            var card = new DiscountCard("1234567890123", "Trush", "Maryna", null, DateTime.Now);
            pharmacist.Cards = new List<DiscountCard> { card };

            pharmacist.RemoveDiscountCard(card);

            Assert.DoesNotContain(card, pharmacist.Cards);
        }

        [Fact]
        public void Pharmacist_Remove_DiscountCard_Fail()
        {
            var pharmacist = new Pharmacist("pharm_Maryna@google.com");
            var card = new DiscountCard("1234567890123", "Trush", "Maryna", null, DateTime.Now);

            Assert.Throws<InvalidOperationException>(() => pharmacist.RemoveDiscountCard(card));
        }

        [Fact]
        public void Pharmacist_Delete_Account_Success()
        {
            var pharmacist = new Pharmacist("pharm_Maryna@google.com");

            pharmacist.DeleteAccount();

            Assert.Null(pharmacist.UniqueEmail);
        }

        [Fact]
        public void Pharmacist_Delete_Account_With_Unfinished_Orders_Fail()
        {
            var pharmacist = new Pharmacist("pharm_Maryna@google.com");
            var order = new OrderBasket("Address", DeliveryMethods.SelfPickup);
            pharmacist.Orders = new List<OrderBasket> { order };

            Assert.Throws<InvalidOperationException>(() => pharmacist.DeleteAccount());
        }

        [Fact]
        public void Pharmacist_Search_Product_Return_True()
        {
            var pharmacist = new Pharmacist("pharm_Maryna@google.com");
            var products = new List<Product>() { new Product("Ibuprofen", "Description", 200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null) };

            pharmacist.FoundProduct(products);

            Assert.True(true);
        }

        [Fact]
        public void Pharmacist_Search_Product_Return_False()
        {
            var pharmacist = new Pharmacist("pharm_Maryna@google.com");
            var products = new List<Product>() { new Product("Ibuprofen", "Description", 200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null) };

            pharmacist.FoundProduct(products);

            Assert.True(false);
        }

        [Fact]
        public void Pharmacist_Search_Cities_Success()
        {
            var pharmacist = new Pharmacist("pharm_Maryna@google.com");

            var result = pharmacist.SearchCities("Kiev");

            Assert.NotEmpty(result);
        }

        [Fact]
        public void Pharmacist_Search_Cities_Fail()
        {
            var pharmacist = new Pharmacist("pharm_Maryna@google.com");

            Assert.Throws<ArgumentException>(() => pharmacist.SearchCities(""));
        }
    }
}
