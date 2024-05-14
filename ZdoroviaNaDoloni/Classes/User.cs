using MySql.Data.MySqlClient;
using System.Data;
using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.Classes.Interfaces;

namespace ZdoroviaNaDoloni.Classes
{
    public abstract class User : IAuthorization, IRegistration, ISearchableProducts
    {
        private MySqlConnection connectDB = Constants.connection;
        protected List<Product>? Products { get; set; }

        private string phoneNumber;
        private string password;
        private Genders? gender;

        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (!ValidatePhoneNumber(value))
                    throw new Exception("Невірний формат номеру телефону. Перевірте, щоб рядок складався з 9 цифр та спробуйте знову.");
                phoneNumber = value;
            }
        }

        public string Password
        {
            get => password;
            set
            {
                if (!ValidatePass(value))
                    throw new Exception("Невірний формат паролю. Перевірте, щоб рядок складався від 6 до 15 символів та містив хоча б одну велику літеру.");
                password = value;
            }
        }

        public Genders? Gender
        {
            get => gender;
            set => gender = value;
        }

        public static bool IsAuthorized;
        public static bool IsRegistered;
        public static bool IsDeleted;
        public static User? CurrentUser { get; private set; }

        public static event Action<User> UserAuthorized = user => { };
        public static event Action<User> UserRegistered = user => { };
        public static event Action<User> AccountDeleted = user => { };

        public User() { }

        public User(string phoneNumber, string password)
        {
            PhoneNumber = phoneNumber;
            Password = password;
        }

        public User(string phoneNumber, string password, Genders gender) : this(phoneNumber, password)
        {
            Gender = gender;
        }

        public bool ValidatePhoneNumber(string value)
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length == Constants.MinPhoneNumbLength)
            {
                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        return false; 
                    }
                }
                return true; 
            }
            return false;
        }

        public bool ValidatePass(string value)
        {
            bool isValidLength = value.Length > Constants.MinPassLength && value.Length <= Constants.MaxPassLength;
            bool hasUpperCase = value.Any(char.IsUpper);
            return isValidLength && hasUpperCase;
        }

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
                CurrentUser = this;
                UserAuthorized?.Invoke(this);
                return true;
            }
            else 
            {
                return false;
            }
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
                CurrentUser = this;
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

        public static void Logout()
        {
            IsAuthorized = false;
            IsRegistered = false;
            CurrentUser = null;
        }

        public string? DeleteUserFromDatabase(User currentUser)
        {
            try
            {
                if (currentUser != null)
                {
                    AccountDeleted?.Invoke(this);
                    MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `phone_number` = @pn", getConnection());
                    command.Parameters.AddWithValue("@pn", currentUser.PhoneNumber);

                    openConnectionDB();
                    int rowsAffected = command.ExecuteNonQuery();

                    MySqlCommand getMaxIdCommand = new MySqlCommand("SELECT MAX(id) FROM users", getConnection());
                    int maxId = Convert.ToInt32(getMaxIdCommand.ExecuteScalar());

                    MySqlCommand updateAutoIncrementCommand = new MySqlCommand($"ALTER TABLE users AUTO_INCREMENT = {maxId + 1}", getConnection());
                    updateAutoIncrementCommand.ExecuteNonQuery();

                    closeConnectionDB();

                    if (rowsAffected > 0)
                    {
                        return null;
                    }
                    else
                    {
                        return "Не вдалося видалити користувача";
                    }
                }
                else
                {
                    return "Користувач не зареєстрований у БД";
                }
            }
            catch (MySqlException ex)
            {
                return "Помилка: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "Не вдалося видалити користувача: " + ex.Message;
            }
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
