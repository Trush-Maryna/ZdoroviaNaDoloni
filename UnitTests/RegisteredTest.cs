using ZdoroviaNaDoloni;
using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.Classes;

namespace UnitTests
{
    public class RegisteredTest
    {
        [Fact]
        public void Registered_Phone_Add_Feedback_Email()
        {
            var registered = new Registered("0666395820", "Mar03Mar", Roles.Registered, Genders.Female);
            var fb = new Feedback("Feedback 1", 4, DateTime.Now);

            registered.AddFeedback(fb);

            Assert.Contains(fb, registered.Feedbacks);
        }

        [Fact]
        public void Registered_Email_Add_Feedback()
        {
            var registered = new Registered("marina.13@gmail.com");
            var fb = new Feedback("Feedback 1", 4, DateTime.Now);

            registered.AddFeedback(fb);

            Assert.Contains(fb, registered.Feedbacks);
        }

        [Fact]
        public void Registered_Add_DiscountCard_Success()
        {
            var registered = new Registered("0666395820", "Mar03Mar", Roles.Registered, Genders.Female);
            var card = new DiscountCard("1234567890123", "Trush", "Maryna", null, DateTime.Now);

            registered.AddDiscountCard("1234567890123", "Trush", "Maryna", null, DateTime.Now);

            Assert.Equal(card.Code, registered.Card.Code);
            Assert.Equal(card.OwnerName, registered.Card.OwnerName);
            Assert.Equal(card.OwnerSurname, registered.Card.OwnerSurname);
        }

        [Fact]
        public void Registered_Delete_Account_Success()
        {
            var registered = new Registered("0666395820", "Mar03Mar", Roles.Registered, Genders.Female);

            registered.DeleteAccount();

            Assert.Null(registered);
        }

        [Fact]
        public void Registered_Delete_Account_With_Unfinished_Orders_Fail()
        {
            var registered = new Registered("0666395820", "Mar03Mar", Roles.Registered, Genders.Female);
            var order = new OrderBasket("Address", DeliveryMethods.SelfPickup);
            registered.Orders = new List<OrderBasket> { order };

            Assert.Throws<InvalidOperationException>(() => registered.DeleteAccount());
        }

        [Fact]
        public void Registered_Search_Product_Return_True()
        {
            var registered = new Registered("0666395820", "Mar03Mar", Roles.Registered, Genders.Female);
            var products = new List<Product>() { new Product("Ibuprofen", "Description", 200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null) };

            registered.FoundProduct(products);

            Assert.True(true);
        }

        [Fact]
        public void Registered_Search_Product_Return_False()
        {
            var registered = new Registered("0666395820", "Mar03Mar", Roles.Registered, Genders.Female);
            var products = new List<Product>() { new Product("Ibuprofen", "Description", 200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null) };

            registered.FoundProduct(products);

            Assert.True(false);
        }

        [Fact]
        public void Registered_Search_Cities_Success()
        {
            var registered = new Registered("0666395820", "Mar03Mar", Roles.Registered, Genders.Female);

            var result = registered.SearchCities("Kiev");

            Assert.NotEmpty(result);
        }

        [Fact]
        public void Registered_Search_Cities_Fail()
        {
            var registered = new Registered("0666395820", "Mar03Mar", Roles.Registered, Genders.Female);

            Assert.Throws<ArgumentException>(() => registered.SearchCities(""));
        }
    }
}
