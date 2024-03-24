using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.Classes.Interfaces;

namespace ZdoroviaNaDoloni.Classes
{
    public abstract class User : IAuthorization, IRegistration, ISearchableProducts
    {
        public static readonly int MinPassLength = 6;
        public static readonly int MaxPassLength = 20;
        public static readonly int MinPhoneNumbLength = 10;

        private Roles role;
        private Genders? gender;

        private string phoneNumber;
        private string email;
        private string password;

        public Roles Role { get; set; }
        public Genders? Gender { get; set; }

        protected string PhoneNumber { get; set; }
        protected string Email { get; set; }
        protected string Password { get; set; }

        protected List<Product>? Products { get; set; }

        public User()
        {
            throw new NotImplementedException();
        }

        public User(string phoneNumber, string password)
        {
            throw new NotImplementedException();
            //PhoneNumber = phoneNumber;
            //Password = password;
        }

        public User(string email)
        {
            throw new NotImplementedException();
            //Email = email;
        }

        public User(string phoneNumber, string password, Roles role, Genders gender) : this(phoneNumber, password)
        {
            throw new NotImplementedException();
            //Role = role;
            //Gender = gender;
        }

        public User(string email, Roles role, Genders gender) : this(email)
        {
            throw new NotImplementedException();
            //Role = role;
            //Gender = gender;
        }

        public event Action Registered = delegate { };
        public event Action AccountDeleted = delegate { };

        public static void ValidatePhoneNumb(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public static void ValidatePass(string password)
        {
            throw new NotImplementedException();
        }

        public static void ValidateEmail(string email)
        {
            throw new NotImplementedException();
        }

        public static void EncryptPass(string password)
        {
            throw new NotImplementedException();
        }

        public bool IsAuthorized(string phonenumber, string password, string email)
        {
            throw new NotImplementedException();
        }

        public void Authorized(string phonenumber, string password, string email)
        {
            throw new NotImplementedException();
        }

        public bool IsRegistered(string phonenumber, string password, bool confidentmark)
        {
            throw new NotImplementedException();
        }

        public void Register(string phonenumber, string password, bool confidentmark)
        {
            throw new NotImplementedException();
        }

        public void IsInRole(string phonenumber, string email, Roles role)
        {
            throw new NotImplementedException();
        }

        public void IsInRole(string phonenumber, Roles role)
        {
            throw new NotImplementedException();
        }

        public List<Product> SearchProducts(string query)
        {
            throw new NotImplementedException();
        }
    }
}
