using ZdoroviaNaDoloni.Classes;

namespace UnitTests
{
    public class GuestTest
    {
        [Fact]
        public void ID_ShouldIncrement_OnEachCall()
        {
            int firstId = Guest.ID;
            int secondId = Guest.ID;
            int thirdId = Guest.ID;
            Assert.Equal(firstId + 1, secondId);
            Assert.Equal(secondId + 1, thirdId);
        }

        [Fact]
        public void Constructor_ShouldInitializeGuest()
        {
            var guest = new Guest();
            Assert.NotNull(guest);
        }
    }
}
