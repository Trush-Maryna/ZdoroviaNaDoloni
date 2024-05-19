using Newtonsoft.Json;

namespace ZdoroviaNaDoloni.Classes
{
    public class Pharmacist : User
    {
        private string? name;
        private string? surname;
        private string uniquePhoneNumber;
        private string uniquePass;

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
        public string? Surname
        {
            get => surname;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 0)
                    surname = value;
                else
                    throw new ArgumentException("Прізвище не може бути пустим.");
            }
        }

        public string UniquePhoneNumber
        {
            get => uniquePhoneNumber;
            set => uniquePhoneNumber = value;
        }

        public string UniquePass
        {
            get => uniquePass;
            set => uniquePass = value;
        }

        public List<OrderBasket>? Orders { get; set; }
        public List<Feedback>? Feedbacks { get; set; }

        public Pharmacist() { }

        public Pharmacist(string uniquePhoneNumber, string uniquePass) 
            : base(uniquePhoneNumber, uniquePass)
        {
            UniquePhoneNumber = uniquePhoneNumber;
            UniquePass = uniquePass;
            Orders = new List<OrderBasket>();
            Feedbacks = new List<Feedback>();
        }

        public Pharmacist(string? name, string? surname, string uniquePhoneNumber, string uniquePass, List<OrderBasket>? orders, List<Feedback>? feedbacks) 
            : this(uniquePhoneNumber, uniquePass)
        {
            Name = name;
            Surname = surname;
            Orders = orders ?? new List<OrderBasket>();
            Feedbacks = feedbacks ?? new List<Feedback>();
        }

        public int ReceiveOrderCount()
        {
            return Orders?.Count ?? throw new InvalidOperationException("Немає замовлень у цього користувача.");
        }

        public List<OrderBasket> ReceiveOrders()
        {
            return Orders ?? throw new InvalidOperationException("Немає замовлень у цього користувача.");
        }

        public void OrderProducts(List<Product> products)
        {
            if (products.Any(p => p.Quantity <= 0))
            {
                throw new InvalidOperationException("Кількість товару не може бути менше або дорівнювати нулю.");
            }

            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Surname) || string.IsNullOrWhiteSpace(UniquePhoneNumber))
            {
                throw new InvalidOperationException("Заповніть обов'язкові поля.");
            }

            Orders ??= new List<OrderBasket>();
            Orders.Add(new OrderBasket(products));
        }

        public void AddFeedback(Feedback feedback)
        {
            Feedbacks ??= new List<Feedback>();
            Feedbacks.Add(feedback);
        }

        public void DeleteFeedback(Feedback feedback) => Feedbacks?.Remove(feedback);

        public static string GetJsonFilePath(string jsonFilePath)
        {
            string projectDirectory = Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName;
            return Path.Combine(projectDirectory, jsonFilePath);
        }

        public static void AddProductToJson(Product newProduct, string jsonFilePath)
        {
            string productsJsonPath = GetJsonFilePath(jsonFilePath);
            try
            {
                List<Product> products = ReadJson(productsJsonPath);
                products.Add(newProduct);
                string productsJson = JsonConvert.SerializeObject(products, Formatting.Indented);
                File.WriteAllText(productsJsonPath, productsJson);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Помилка при додаванні нового продукту: {ex.Message}");
            }
        }

        public static List<Product> ReadJson(string jsonFilePath)
        {
            string productsJsonPath = GetJsonFilePath(jsonFilePath);
            try
            {
                string productsJson = File.ReadAllText(productsJsonPath);
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(productsJson);
                return products;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Помилка при зчитуванні даних: {ex.Message}");
            }
        }

        public void EditProduct(Product product, string newName, string newDescription, decimal newPrice)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Заповніть обов'язкові поля.");

            product.Name = newName;
            product.Description = newDescription;
            product.Price = newPrice;
        }
    }
}
