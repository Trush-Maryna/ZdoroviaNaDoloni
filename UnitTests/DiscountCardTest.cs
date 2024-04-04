using Newtonsoft.Json;
using ZdoroviaNaDoloni;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Enums;

namespace UnitTests
{
    public class DiscountCardTest
    {
        [Fact]
        public void Add_DiscountCard_Successfully()
        {
            var card_1 = new DiscountCard("1234567890123", "Trush", "Maryna", null, DateTime.Now);
            var pharmacist = new Pharmacist("trush.marina.13@gmail.com");
            var registered = new Registered("0666395820", "Mar03Mar", Roles.Registered, Genders.Female);
            var card_2 = registered.AddDiscountCard("1234567890123", "Trush", "Maryna", null, DateTime.Now);
            
            pharmacist.AddDiscountCard(card_1);

            Assert.Contains(card_1, pharmacist.Cards);
            Assert.Equal(card_2, registered.Card);
        }

        [Fact]
        public void Add_DiscountCard_Already_Exists()
        {
            var card = new DiscountCard("1234567890123", "Trush", "Maryna", null, DateTime.Now);
            var pharmacist = new Pharmacist("trush.marina.13@gmail.com");
            pharmacist.Cards?.Add(card);

            Action act = () => pharmacist.AddDiscountCard(card);

            var exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal("This card already exists.", exception.Message);
        }

        [Fact]
        public void Remove_DiscountCard_Successfully()
        {
            var card = new DiscountCard("1234567890123", "Trush", "Maryna", 0.5, DateTime.Now);
            var pharmacist = new Pharmacist("trush.marina.13@gmail.com");
            pharmacist.Cards?.Add(card);

            pharmacist.RemoveDiscountCard(card);

            Assert.DoesNotContain(card, pharmacist.Cards);
        }

        [Fact]
        public void Calculate_Discount_With_Orders()
        {
            var card = new DiscountCard("1234567890123", "Trush", "Maryna", null, DateTime.Now);

            string json = File.ReadAllText("products.json");
            var productDataList = JsonConvert.DeserializeObject<List<Product>>(json);

            var orders = productDataList?.Select(data =>
                new Product(data.Name, data.Description, data.Price, data.Quantity, data.Status, data.Category, data.TotalDiscount, null)
            ).ToList();

            DiscountCard.CalculateDiscount(orders);

            var discount = card.UserDiscount;

            Assert.NotNull(discount);
            Assert.True(discount > 0);
        }

        [Fact]
        public void Calculate_Discount_With_No_Orders()
        {
            var card = new DiscountCard("1234567890123", "Trush", "Maryna", null, DateTime.Now);

            var discount = card.UserDiscount;

            Assert.Null(discount);
        }
    }
}
