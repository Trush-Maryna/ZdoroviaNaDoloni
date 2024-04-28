using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;
using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.Classes.Interfaces;

namespace ZdoroviaNaDoloni.Classes
{
    public abstract class User : IAuthorization, IRegistration, ISearchableProducts
    {
        private MySqlConnection connectDB = Constants.connection;

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

        public bool IsAuthorized { get; private set; }
        public bool IsRegistered { get; private set; }

        protected bool IsLoggedInOrSignIn { get; set; }

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
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= Constants.MinPassLength && value.Length <= Constants.MaxPassLength && ContainsNumber(value) && ContainsUppercase(value))
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

        public event Action<User> UserAuthorized = user => { };
        public event Action<User> UserRegistered = user => { };

        public event Action AccountDeleted = delegate { };

        public static bool ValidatePhoneNumb(string phoneNumber) 
        {
            string strippedNumber = Regex.Replace(phoneNumber, @"\s+", "");
            return Regex.IsMatch(strippedNumber, @"^\d{9}$");
        }

        public static bool ContainsNumber(string input) => input.Any(char.IsDigit);

        public static bool ContainsUppercase(string input) => input.Any(char.IsUpper);

        public static string EncryptPass(string password) => Regex.Replace(password, @"\d", "*");

        public void openConnectionDB() 
        {
            if (connectDB.State == ConnectionState.Closed)
            {
                connectDB.Open();
            }
        }

        public void closeConnectionDB()
        {
            if (connectDB.State == ConnectionState.Open)
            {
                connectDB.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connectDB;
        }

        public bool Authorized(int phonenumber, string password)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `phone_number` = @pn AND `pass` = @p", getConnection());
            command.Parameters.Add("@pn", MySqlDbType.Int32).Value = phonenumber;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                IsAuthorized = true;
                UserAuthorized?.Invoke(this);
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool Authorized(int phonenumber, string password, string email)
        {
            //db
            return true;
        }

        public bool Register(int phonenumber, string password, bool confidentmark)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`phone_number`, `pass`, `CheckButtonClicked`) VALUES (@pn, @p, @cbc)", getConnection());
            command.Parameters.Add("@pn", MySqlDbType.Int32).Value = phonenumber;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@cbc", MySqlDbType.Bit).Value = confidentmark;

            openConnectionDB();
            if (command.ExecuteNonQuery() == 1)
            {
                closeConnectionDB();
                IsRegistered = true;
                UserRegistered?.Invoke(this);
                return true;
            }
            else
            {
                closeConnectionDB();
                return false;
            }
        }

        public bool isUserExists(int phoneNumber)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `phone_number` = @pn", getConnection());
            command.Parameters.Add("@pn", MySqlDbType.Int32).Value = phoneNumber;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CheckAuthorizationStatus()
        {
            IsAuthorized = true;
            UserAuthorized?.Invoke(this);
        }

        public void CheckRegistrationStatus()
        {
            IsRegistered = true;
            UserRegistered?.Invoke(this);
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

        public List<Product> SearchProductsByName(List<Product> products, string query)
        {
            List<Product> results = new List<Product>();

            foreach (var product in products)
            {
                if (product.Name.ToLower().Contains(query))
                {
                    results.Add(product);
                }
            }

            return results;
        }
    }
}
