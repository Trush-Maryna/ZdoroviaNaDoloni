using System.Text.RegularExpressions;
using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.Classes.Interfaces;

namespace ZdoroviaNaDoloni.Classes
{
    public abstract class User : IAuthorization, IRegistration, ISearchableProducts
    {
        public static readonly int MinPassLength = 6;
        public static readonly int MaxPassLength = 20;
        public static readonly int MinPhoneNumbLength = 9;

        private Roles role;
        private Genders? gender;

        private string phoneNumber;
        private string email;
        private string password;

        public Roles Role
        {
            get => role;
            set => role = value;
        }
        public Genders? Gender
        {
            get => gender;
            set => gender = value;
        }

        protected string PhoneNumber 
        {
            get => phoneNumber;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value) && ValidatePhoneNumb(value))
                    phoneNumber = value;
                else
                    throw new ArgumentException("Invalid phone number format.");
            }
        }
        protected string Email 
        {
            get => email;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Contains("@"))
                    email = value;
                else
                    throw new ArgumentException("Invalid email format.");
            }
        }
        protected string Password 
        {
            get => password;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= MinPassLength && value.Length <= MaxPassLength && ContainsNumber(value) && ContainsUppercase(value))
                    password = value;
                else
                    throw new ArgumentException("Invalid password format.");
            }
        }

        protected List<Product>? Products { get; set; }

        public User() { }

        public User(string phoneNumber, string password)
        {
            PhoneNumber = phoneNumber;
            Password = password;
        }

        public User(string email) => Email = email;

        public User(string phoneNumber, string password, Roles role, Genders gender) : this(phoneNumber, password)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Phone number cannot be empty.");

            Role = role;
            Gender = gender;
        }

        public User(string email, Roles role, Genders gender) 
            : this(email)
        {
            Role = role;
            Gender = gender;
        }

        public event Action Registered = delegate { };
        public event Action AccountDeleted = delegate { };

        public static bool ValidatePhoneNumb(string phoneNumber) 
        {
            string strippedNumber = Regex.Replace(phoneNumber, @"\s+", "");
            return Regex.IsMatch(strippedNumber, @"^\d{9}$");
        }

        public static bool ContainsNumber(string input) => input.Any(char.IsDigit);

        public static bool ContainsUppercase(string input) => input.Any(char.IsUpper);

        public static string EncryptPass(string password) => Regex.Replace(password, @"\d", "*");

        public bool IsAuthorized(string phonenumber, string password, string email) => (PhoneNumber == phonenumber || Email == email) && Password == password;

        public void Authorized(string phonenumber, string password, string email)
        {
            throw new NotImplementedException(); //db
        }

        public bool IsRegistered(string phonenumber, string password, bool confidentmark) => PhoneNumber == phonenumber && Password == password && confidentmark;

        public void Register(string phonenumber, string password, bool confidentmark)
        {
            PhoneNumber = phonenumber;
            Password = password;
            if (confidentmark)
                Registered?.Invoke();
            else
                throw new ArgumentException("Confident mark is required for registration.");
        }

        public void IsInRole(string phonenumber, string email, Roles role)
        {
            if (Role != role || (PhoneNumber != phonenumber && Email != email))
                throw new UnauthorizedAccessException("User is not in the specified role.");
        }

        public void IsInRole(string phonenumber, Roles role)
        {
            if (Role != role || PhoneNumber != phonenumber)
                throw new UnauthorizedAccessException("User is not in the specified role.");
        }

        public List<Product> SearchProducts(string query) => Products?.Where(p => p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList() ?? new List<Product>();
    }
}
