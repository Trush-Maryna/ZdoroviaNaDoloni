using ZdoroviaNaDoloni;
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
            var phoneNumber = "0666395820";
            var password = "Mar03Mar";
            var confidentMark = true;
            bool registeredEventRaised = false;

            guest.Registered += () => registeredEventRaised = true;

            guest.Register(phoneNumber, password, confidentMark);

            Assert.True(registeredEventRaised);
        }

        [Fact]
        public void Guest_Fail_Registration_Phone()
        {
            var guest = new Guest();
            var phoneNumber = "";

            Assert.Throws<ArgumentException>(() => guest.Register(phoneNumber, "Mar03Mar", true));
        }

        [Fact]
        public void Guest_Fail_Registration_Pass()
        {
            var guest = new Guest();
            var password = "";

            Assert.Throws<ArgumentException>(() => guest.Register("0666395820", password, true));
        }

        [Fact]
        public void Guest_Fail_Registration_ConfMark()
        {
            var guest = new Guest();

            Assert.Throws<ArgumentException>(() => guest.Register("0666395820", "Mar03Mar", false));
        }

        [Fact]
        public void Pharmacist_Successful_Authorization()
        {
            string validPhoneNumber = "0666395820";
            string validPassword = "Mar03Mar";
            string validEmail = "marina13@gmail.com";
            User user = new Pharmacist(validPhoneNumber, validPassword);

            bool isAuthorized = user.IsAuthorized(validPhoneNumber, validPassword, validEmail);

            Assert.True(isAuthorized);
        }

        [Fact]
        public void Pharmacist_Fail_Authorization_InvalidPassword()
        {
            string validPhoneNumber = "0666395820";
            string invalidPassword = "invalid";
            string validEmail = "marina13@gmail.com";
            User user = new Pharmacist(validPhoneNumber, invalidPassword);

            bool isAuthorized = user.IsAuthorized(validPhoneNumber, invalidPassword, validEmail);

            Assert.False(isAuthorized);
        }

        [Fact]
        public void Pharmacist_Fail_Authorization_InvalidEmail()
        {
            string validPhoneNumber = "0666395820";
            string validPassword = "Mar03Mar";
            string invalidEmail = "invalid";
            User user = new Pharmacist(validPhoneNumber, validPassword);

            bool isAuthorized = user.IsAuthorized(validPhoneNumber, validPassword, invalidEmail);

            Assert.False(isAuthorized);
        }

        [Fact]
        public void Pharmacist_Fail_Authorization_EmptyPhoneNumber()
        {
            string emptyPhoneNumber = "";
            string validPassword = "Mar03Mar";
            string validEmail = "marina13@gmail.com";
            User user = new Pharmacist(emptyPhoneNumber, validPassword);

            bool isAuthorized = user.IsAuthorized(emptyPhoneNumber, validPassword, validEmail);

            Assert.False(isAuthorized);
        }

        [Fact]
        public void Registered_Successful_Authorization()
        {
            string validPhoneNumber = "0666395820";
            string validPassword = "Mar03Mar";
            string validEmail = "marina13@gmail.com";
            User user = new Registered(validPhoneNumber, validPassword, Roles.Registered, Genders.Female);

            bool isAuthorized = user.IsAuthorized(validPhoneNumber, validPassword, validEmail);

            Assert.True(isAuthorized);
        }

        [Fact]
        public void Registered_Fail_Authorization_InvalidPassword()
        {
            string validPhoneNumber = "0666395820";
            string invalidPassword = "invalid";
            string validEmail = "marina13@gmail.com";
            User user = new Registered(validPhoneNumber, invalidPassword, Roles.Registered, Genders.Female);

            bool isAuthorized = user.IsAuthorized(validPhoneNumber, invalidPassword, validEmail);

            Assert.False(isAuthorized);
        }

        [Fact]
        public void Registered_Fail_Authorization_InvalidEmail()
        {
            string validPhoneNumber = "0666395820";
            string validPassword = "Mar03Mar";
            string invalidEmail = "invalid";
            User user = new Registered(validPhoneNumber, validPassword, Roles.Registered, Genders.Female);

            bool isAuthorized = user.IsAuthorized(validPhoneNumber, validPassword, invalidEmail);

            Assert.False(isAuthorized);
        }

        [Fact]
        public void Registered_Fail_Authorization_EmptyPhoneNumber()
        {
            string emptyPhoneNumber = "";
            string validPassword = "Mar03Mar";
            string validEmail = "marina13@gmail.com";
            User user = new Registered(emptyPhoneNumber, validPassword, Roles.Registered, Genders.Female);

            bool isAuthorized = user.IsAuthorized(emptyPhoneNumber, validPassword, validEmail);

            Assert.False(isAuthorized);
        }
    }
}