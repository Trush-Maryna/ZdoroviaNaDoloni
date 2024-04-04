using ZdoroviaNaDoloni;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Enums;

namespace UnitTests
{
    public class GuestTest
    {
        [Fact]
        public void Guest_InitializesWithID()
        {
            var guest = new Guest();

            Assert.Equal(1, Guest.ID);
        }

        [Fact]
        public void Guest_Search_Product_Return_True()
        {
            var guest = new Guest();
            var products = new List<Product>() { new Product("Ibuprofen", "Description", 200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null) };

            guest.FoundProduct(products);

            Assert.True(true);
        }

        [Fact]
        public void Guest_Search_Product_Return_False()
        {
            var guest = new Guest();
            var products = new List<Product>() { new Product("Ibuprofen", "Description", 200, 5, Statuses.InStock, Categories.Medicines, TotalDiscounts.Null, null) };

            guest.FoundProduct(products);

            Assert.True(false);
        }
    }
}
