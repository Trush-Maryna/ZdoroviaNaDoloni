using Microsoft.VisualBasic.ApplicationServices;
using ZdoroviaNaDoloni;
using ZdoroviaNaDoloni.Classes;

namespace UnitTests
{
    public class UserTest
    {
        private ZdoroviaNaDoloni.Classes.User CreateRegisterInstance()
        {
            return new Registered();
        }

        private ZdoroviaNaDoloni.Classes.User CreatePharmacistInstance()
        {
            return new Pharmacist();
        }

        [Fact]
        public void Register_ValidatePhoneNumber_ReturnsTrue()
        {
            var user = CreateRegisterInstance();
            var result = user.ValidatePhoneNumber("666666666");
            Assert.True(result);
        }

        [Fact]
        public void Pharmacist_ValidatePhoneNumber_ReturnsTrue()
        {
            var user = CreatePharmacistInstance();
            var result = user.ValidatePhoneNumber("666695822");
            Assert.True(result);
        }

        [Fact]
        public void Register_ValidatePass_ReturnsTrue()
        {
            var user = CreateRegisterInstance();
            var result = user.ValidatePass("Abasd45");
            Assert.True(result);
        }

        [Fact]
        public void Pharmacist_ValidatePass_ReturnsTrue()
        {
            var user = CreatePharmacistInstance();
            var result = user.ValidatePass("Mfjkcnst1256lsm");
            Assert.True(result);
        }

        [Fact]
        public void Register_Authorized_ReturnsTrue()
        {
            var user = CreateRegisterInstance();
            int phoneNumber = 666666666;
            string password = "Abasd45";
            var result = user.Authorized(phoneNumber, password);
            Assert.True(result);
        }

        [Fact]
        public void Pharmacist_Authorized_ReturnsTrue()
        {
            var user = CreatePharmacistInstance();
            int phoneNumber = 666695822;
            string password = "Mfjkcnst1256lsm";
            var result = user.Authorized(phoneNumber, password);
            Assert.True(result);
        }

        [Fact]
        public void Register_isUserExists_ReturnsTrue()
        {
            var user = CreateRegisterInstance();
            int phoneNumber = 666666666;
            var result = user.isUserExists(phoneNumber);
            Assert.True(result);
        }

        [Fact]
        public void Register_isUserExists_ReturnsFalse()
        {
            var user = CreateRegisterInstance();
            int phoneNumber = 111111111;
            var result = user.isUserExists(phoneNumber);
            Assert.False(result);
        }

        [Fact]
        public void Pharmacist_Authorized_ReturnsFalsePass()
        {
            var user = CreatePharmacistInstance();
            int phoneNumber = 666666666;
            string password = "mfj";
            var result = user.Authorized(phoneNumber, password);
            Assert.False(result);
        }

        [Fact]
        public void Pharmacist_isUserExists_ReturnsTrue()
        {
            var user = CreatePharmacistInstance();
            int phoneNumber = 666695822;
            var result = user.isUserExists(phoneNumber);
            Assert.True(result);
        }

        [Fact]
        public void Pharmacist_isUserExists_ReturnsFalse()
        {
            var user = CreatePharmacistInstance();
            int phoneNumber = 111111111;
            var result = user.isUserExists(phoneNumber);
            Assert.False(result);
        }

        [Fact]
        public void Register_Registered_ReturnsTrue()
        {
            var user = CreateRegisterInstance();
            int phoneNumber = 666666666;
            string password = "Abasd45";
            bool confidentmark = true;
            var result = user.Register(phoneNumber, password, confidentmark);
            Assert.True(result);
        }

        [Fact]
        public void Register_Logout()
        {
            var user = CreateRegisterInstance();
            ZdoroviaNaDoloni.Classes.User.IsAuthorized = true;
            ZdoroviaNaDoloni.Classes.User.IsRegistered = true;
            ZdoroviaNaDoloni.Classes.User.CurrentUser = user;
            ZdoroviaNaDoloni.Classes.User.Logout();
            Assert.False(ZdoroviaNaDoloni.Classes.User.IsAuthorized);
            Assert.False(ZdoroviaNaDoloni.Classes.User.IsRegistered);
            Assert.Null(ZdoroviaNaDoloni.Classes.User.CurrentUser);
        }

        [Fact]
        public void Pharmacist_Logout()
        {
            var user = CreatePharmacistInstance();
            ZdoroviaNaDoloni.Classes.User.IsAuthorized = true;
            ZdoroviaNaDoloni.Classes.User.IsRegistered = true;
            ZdoroviaNaDoloni.Classes.User.CurrentUser = user;
            ZdoroviaNaDoloni.Classes.User.Logout();
            Assert.False(ZdoroviaNaDoloni.Classes.User.IsAuthorized);
            Assert.False(ZdoroviaNaDoloni.Classes.User.IsRegistered);
            Assert.Null(ZdoroviaNaDoloni.Classes.User.CurrentUser);
        }

        [Fact]
        public void Register_SearchProductsByName_ReturnsEmptyList()
        {
            var user = CreateRegisterInstance();
            var products = new List<Product>
            {
                new Product { Name = "Ношпа" },
                new Product { Name = "Парацетамол" },
                new Product { Name = "Азітроміцин" }
            };
            var query = "Іва";
            var result = user.SearchProductsByName(products, query);
            Assert.Empty(result);
        }

        [Fact]
        public void Pharmacist_SearchProductsByName_ReturnsEmptyList()
        {
            var user = CreateRegisterInstance();
            var products = new List<Product>
            {
                new Product { Name = "Ношпа" },
                new Product { Name = "Парацетамол" },
                new Product { Name = "Азітроміцин" }
            };
            var query = "Іва";
            var result = user.SearchProductsByName(products, query);
            Assert.Empty(result);
        }
    }
}