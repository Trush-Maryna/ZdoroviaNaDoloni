using Xunit.Abstractions;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Enums;

namespace UnitTests
{
    public class UserTest
    {
        [Fact]
        public void Guest_Successful_Registration()
        {
            var guest = new Guest();
            var phoneNumber = "666395820";
            var password = "Mar03Mar";
            var confidentMark = true;
            bool registeredEventRaised = false;

            guest.Registered += () => registeredEventRaised = true;

            guest.Register(phoneNumber, password, confidentMark);

            Assert.True(registeredEventRaised);
        }

        [Fact]
        public void Guest_Fail_Registration_InvalidPhone()
        {
            var guest = new Guest();
            var phoneNumber = "";

            Assert.Throws<ArgumentException>(() => guest.Register(phoneNumber, "Mar03Mar", true));
        }

        [Fact]
        public void Guest_Fail_Registration_InvalidPassword()
        {
            var guest = new Guest();
            var password = "";

            Assert.Throws<ArgumentException>(() => guest.Register("666395820", password, true));
        }

        [Fact]
        public void Guest_Fail_Registration_InvalidConfMark()
        {
            var guest = new Guest();

            Assert.Throws<ArgumentException>(() => guest.Register("666395820", "Mar03Mar", false));
        }

        [Fact]
        public void Pharmacist_Successful_Authorization()
        {
            string validPhoneNumber = "666395820";
            string validPassword = "Mar03Mar";
            string validEmail = "marina13@gmail.com";
            User user = new Pharmacist(validPhoneNumber, validPassword, Roles.Registered, Genders.Female);

            bool isAuthorized = user.IsAuthorized(validPhoneNumber, validPassword, validEmail);

            Assert.True(isAuthorized);
        }

        [Fact]
        public void Pharmacist_Fail_Authorization_InvalidPassword()
        {
            string validPhoneNumber = "666395820";
            string invalidPassword = "invalid";
            Assert.Throws<ArgumentException>(() => new Pharmacist(validPhoneNumber, invalidPassword, Roles.Registered, Genders.Female));
        }

        [Fact]
        public void Pharmacist_Fail_Authorization_InvalidEmail()
        {
            string invalidEmail = "marina13gmail.com";

            Assert.Throws<ArgumentException>(() => new Pharmacist(invalidEmail));
        }

        [Fact]
        public void Pharmacist_Fail_Authorization_InvalidPhone()
        {
            string validPhoneNumber = "66639582";
            string invalidPassword = "Mar03Mar";
            Assert.Throws<ArgumentException>(() => new Pharmacist(validPhoneNumber, invalidPassword, Roles.Registered, Genders.Female));
        }

        [Fact]
        public void Pharmacist_Fail_SubAuthorization()
        {
            string validPhoneNumber = "666395820";
            string validPassword = "Mar03Mar";
            string validEmail = "marina13@gmail.com";
            User user = validPhoneNumber != null && validPassword != null ? new Pharmacist(validPhoneNumber, validPassword, Roles.Registered, Genders.Female) : null;

            bool isAuthorized = user != null && user.IsAuthorized(validPhoneNumber, validPassword, validEmail);

            Assert.True(isAuthorized);
        }

        [Fact]
        public void Registered_Successful_Authorization()
        {
            string validPhoneNumber = "666395820";
            string validPassword = "Mar03Mar";
            string validEmail = "marina13@gmail.com";
            User user = new Registered(validPhoneNumber, validPassword, Roles.Registered, Genders.Female);

            bool isAuthorized = user.IsAuthorized(validPhoneNumber, validPassword, validEmail);

            Assert.True(isAuthorized);
        }

        [Fact]
        public void Registered_Fail_Authorization_InvalidPassword()
        {
            string validPhoneNumber = "666395820";
            string invalidPassword = "invalid";
            Assert.Throws<ArgumentException>(() => new Registered(validPhoneNumber, invalidPassword, Roles.Registered, Genders.Female));
        }

        [Fact]
        public void Registered_Fail_Authorization_InvalidEmail()
        {
            string invalidEmail = "marina13gmail.com";

            Assert.Throws<ArgumentException>(() => new Registered(invalidEmail));
        }

        [Fact]
        public void Registered_Fail_Authorization_InvalidPhone()
        {
            string validPhoneNumber = "66639582";
            string invalidPassword = "Mar03Mar";
            Assert.Throws<ArgumentException>(() => new Registered(validPhoneNumber, invalidPassword, Roles.Registered, Genders.Female));
        }

        [Fact]
        public void Registered_Fail_SubAuthorization()
        {
            string validPhoneNumber = "666395820";
            string validPassword = "Mar03Mar";
            string validEmail = "marina13@gmail.com";
            User user = validPhoneNumber != null && validPassword != null ? new Registered(validPhoneNumber, validPassword, Roles.Registered, Genders.Female) : null;

            bool isAuthorized = user != null && user.IsAuthorized(validPhoneNumber, validPassword, validEmail);

            Assert.True(isAuthorized);
        }
    }
}