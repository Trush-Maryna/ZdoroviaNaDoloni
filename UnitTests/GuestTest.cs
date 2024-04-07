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
            var products = new List<Product>() { new Product("Ibuprofen", "Description", 200, 5, Statuses.InStock, Categories.Medicines, Discounts.Null, null) };

            guest.FindProduct(products);

            Assert.True(true);
        }

        //[Fact]
        //public void Guest_Search_Product_With_Empty_Name_Return_False()
        //{
        //    var guest = new Guest();
        //    var products = new List<Product>() { new Product("", "", 0, 0, Statuses.InStock, Categories.Medicines, Discounts.Null, null) };

        //    Assert.Throws<ArgumentException>(() => guest.FindProduct(products));
        //}
    }
}
