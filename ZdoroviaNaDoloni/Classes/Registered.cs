using MySql.Data.MySqlClient;
using System.Data;
using ZdoroviaNaDoloni.Classes.Enums;

namespace ZdoroviaNaDoloni.Classes
{
    public class Registered : User
    {
        private MySqlConnection connectDB = Constants.Instance.connection;
        private string? name;
        private string? city;

        private string numTel;
        public string? NumTel
        {
            get => numTel;
            set
            {
                if (!ValidatePhoneNumber(value))
                    throw new Exception("Невірний формат номеру телефону. Перевірте, щоб рядок складався з 9 цифр та спробуйте знову.");
                numTel = value;
            }
        }

        public string? Name
        {
            get => name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 0)
                    name = value;
                else
                    throw new ArgumentException("Ім'я не може бути пустим.");
            }
        }

        public string? City
        {
            get => city;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 0)
                    city = value;
                else
                    throw new ArgumentException("Місто не може бути пустим.");
            }
        }

        public Genders Gender { get; set; }
        public string Region { get; set; }
        public int NumNP { get; set; }

        public List<OrderBasket>? Orders { get; set; }
        public List<Feedback>? Feedbacks { get; set; }

        public Registered() { }

        public Registered(string phoneNumber, string password) 
            : base(phoneNumber, password)
        {
            Orders = new List<OrderBasket>();
            Feedbacks = new List<Feedback>();
        }

        public Registered(string? name, string? city, string phoneNumber, string password, List<OrderBasket>? orders, List<Feedback>? feedbacks) 
            : base(phoneNumber, password)
        {
            Name = name;
            City = city;
            Orders = orders ?? new List<OrderBasket>();
            Feedbacks = feedbacks ?? new List<Feedback>();
        }

        public Registered(string name, string region, string city, string phoneNumber, int numNP)
        {
            Name = name;
            Region = region;
            City = city;
            PhoneNumber = phoneNumber;
            NumNP = numNP;
        }


        public Registered(string name, string region, string city, string phoneNumber, int numNP, Genders gender)
        {
            Name = name;
            Region = region;
            City = city;
            PhoneNumber = phoneNumber;
            NumNP = numNP;
        }

        public void OrderProducts(List<Product> products)
        {
            if (Orders == null)
                Orders = new List<OrderBasket>();

            foreach (var product in products)
            {
                if (product.Quantity <= 0)
                {
                    throw new InvalidOperationException($"Кількість {product.Name} не знайдено.");
                }
            }

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(NumTel))
            {
                throw new InvalidOperationException("Заповніть обов'язкові поля.");
            }

            Orders ??= new List<OrderBasket>();
            Orders.Add(new OrderBasket(products));
        }

        public void AddFeedback(Feedback feedback)
        {
            Feedbacks?.Add(feedback);
        }

        public void DeleteAccount()
        {
            Name = null;
            City = null;
            Orders = null;
            Feedbacks = null;
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

        public bool LoadUserDataFromDatabase(string? phoneNumber)
        {
            try
            {
                string query = "SELECT * FROM information WHERE PhoneNumber = @pn";
                MySqlCommand command = new MySqlCommand(query, getConnection());
                command.Parameters.AddWithValue("@pn", phoneNumber);

                openConnectionDB();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        this.Name = reader["Name"].ToString();
                        this.Region = reader["Region"].ToString();
                        this.City = reader["City"].ToString();
                        this.PhoneNumber = reader["PhoneNumber"].ToString();
                        this.NumNP = int.Parse(reader["NumNP"].ToString());
                        this.Gender = (Genders)Enum.Parse(typeof(Genders), reader["Gender"].ToString());
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnectionDB();
            }

            return false;
        }

        public bool isInfoExists(int? phoneNumber)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `information` WHERE `PhoneNumber` = @pn", getConnection());
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

        public bool SaveUserDataToDatabase(string name, string region, string city, string phoneNumber, int numNP)
        {
            try
            {
                string query = @"INSERT INTO `information` (Name, Region, City, PhoneNumber, NumNP) 
                                VALUES (@name, @reg, @c, @pn, @numNP)";
                MySqlCommand command = new MySqlCommand(query, getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@reg", MySqlDbType.VarChar).Value = region;
                command.Parameters.Add("@c", MySqlDbType.VarChar).Value = city;
                command.Parameters.Add("@pn", MySqlDbType.Int32).Value = phoneNumber;
                command.Parameters.Add("@numNP", MySqlDbType.Int32).Value = numNP;
                openConnectionDB();
                if (command.ExecuteNonQuery() == 1)
                {
                    closeConnectionDB();
                    return true;
                }
                else
                {
                    closeConnectionDB();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                closeConnectionDB();
                return false;
            }
        }

        public bool SaveUserDataToDatabase(string name, string region, string city, string phoneNumber, int numNP, Genders gender)
        {
            try
            {
                string query = @"INSERT INTO `information` (Name, Region, City, PhoneNumber, NumNP, Gender) 
                                VALUES (@name, @reg, @c, @pn, @numNP, @gender)";
                MySqlCommand command = new MySqlCommand(query, getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@reg", MySqlDbType.VarChar).Value = region;
                command.Parameters.Add("@c", MySqlDbType.VarChar).Value = city;
                command.Parameters.Add("@pn", MySqlDbType.Int32).Value = phoneNumber;
                command.Parameters.Add("@numNP", MySqlDbType.Int32).Value = numNP;
                command.Parameters.Add("@gender", MySqlDbType.Enum).Value = gender;
                openConnectionDB();
                if (command.ExecuteNonQuery() == 1)
                {
                    closeConnectionDB();
                    return true;
                }
                else
                {
                    closeConnectionDB();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                closeConnectionDB();
                return false;
            }
        }

        public bool UpdateUserGenderInDatabase(string phoneNumber, Genders gender)
        {
            try
            {
                string query = @"UPDATE `information` SET Gender = @gender WHERE PhoneNumber = @pn";
                MySqlCommand command = new MySqlCommand(query, getConnection());
                command.Parameters.Add("@gender", MySqlDbType.Enum).Value = gender;
                command.Parameters.Add("@pn", MySqlDbType.Int32).Value = phoneNumber;
                openConnectionDB();
                if (command.ExecuteNonQuery() == 1)
                {
                    closeConnectionDB();
                    return true;
                }
                else
                {
                    closeConnectionDB();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                closeConnectionDB();
                return false;
            }
        }
    }
}
