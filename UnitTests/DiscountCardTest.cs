using Newtonsoft.Json;
using ZdoroviaNaDoloni;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Enums;

namespace UnitTests
{
    public class DiscountCardTest
    {
        [Fact]
        public void Pharmacist_Add_DiscountCardRegistered_Successfully()
        {
            var pharmacist = new Pharmacist("trush.marina.13@gmail.com");
            var registered = new Registered("666395820", "Mar03Mar", Roles.Registered, Genders.Female);
            registered.AddDiscountCard("Trush", "Maryna", Discounts.Null, DateTime.Now);

            pharmacist.AddDiscountCard(registered.Card.OwnerName, registered.Card.OwnerSurname, registered.Card.UserDiscount, registered.Card.CreationDate);

            Assert.Contains(registered.Card, pharmacist.Cards);
            Assert.Equal(registered.Card, pharmacist.Cards.FirstOrDefault());
        }

        [Fact]
        public void Pharmacist_Add_DiscountCard_Already_Exists()
        {
            var pharmacist = new Pharmacist("trush.marina.13@gmail.com");
            var card = new DiscountCard("Trush", "Maryna", Discounts.Five, DateTime.Now);
            pharmacist.AddDiscountCard(card.OwnerName, card.OwnerSurname, card.UserDiscount, card.CreationDate);

            Action act = () => pharmacist.AddDiscountCard(card.OwnerName, card.OwnerSurname, card.UserDiscount, card.CreationDate);

            var exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal("This user already has a discount card.", exception.Message);
        }

        [Fact]
        public void Remove_DiscountCard_Successfully()
        {
            var card = new DiscountCard("Trush", "Maryna", Discounts.Five, DateTime.Now);
            var pharmacist = new Pharmacist("trush.marina.13@gmail.com");
            pharmacist.Cards?.Add(card);

            pharmacist.RemoveDiscountCard(card);

            Assert.DoesNotContain(card, pharmacist.Cards);
        }

        [Fact]
        public void Calculate_Discount_With_Orders()
        {
            var card = new DiscountCard("Trush", "Maryna", Discounts.Five, DateTime.Now);

            string json = File.ReadAllText("Json/products.json");
            var productDataList = JsonConvert.DeserializeObject<List<Product>>(json);

            var orderBaskets = new List<OrderBasket>();
            var orderBasket = new OrderBasket("Address", DeliveryMethods.SelfPickup, card);
            foreach (var data in productDataList)
            {
                var product = new Product(data.Name, data.Description, data.Price, data.Quantity, data.Status, data.Category, data.TotalDiscount, null);
                orderBasket.AddProducts(product);
            }
            orderBaskets.Add(orderBasket);

            card.CalculateDiscount(orderBaskets);

            var discount = card.UserDiscount;

            Assert.NotNull(discount);
            Assert.True(discount > 0);
        }

        [Fact]
        public void Calculate_Discount_With_No_Orders()
        {
            var card = new DiscountCard("Trush", "Maryna", Discounts.Five, DateTime.Now);

            var discount = card.UserDiscount;

            Assert.Null(discount);
        }
    }
}
