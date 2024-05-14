using Newtonsoft.Json;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Interfaces;

namespace ZdoroviaNaDoloni
{
    public class Product : IProductManagement, Classes.Interfaces.IComparable<Product>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public string Developer { get; set; }
        public bool Confirmation { get; private set; }

        public List<Feedback>? Feedbacks { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, string developer, string descr, decimal price, int quantity)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Назва товару не може бути порожньою.");

            if (string.IsNullOrWhiteSpace(developer))
                throw new ArgumentException("Виробник не може бути порожнім.");

            if (string.IsNullOrWhiteSpace(descr))
                throw new ArgumentException("Опис товару не може бути порожнім.");

            if (price <= 0)
                throw new ArgumentException("Ціна має бути більше нуля.");

            if (quantity <= 0)
                throw new ArgumentException("Кількість має бути більше нуля.");

            ID = id;
            Name = name;
            Description = descr;
            Developer = developer;
            Price = price;
            Quantity = quantity;
        }

        public Product(int id, string name, string developer, string descr, decimal price, int quantity, bool confirmation, List<Feedback>? feedbacks) : this(id, name, developer, descr, price, quantity)
        {
            Confirmation = confirmation;
            Feedbacks = feedbacks;
        }

        public string GetProductInfo()
        {
            return $"Назва: {Name}\n" +
                   $"Опис: {Description}\n" +
                   $"Виробник: {Developer}\n" +
                   $"Ціна: {Price} ₴\n" +
                   $"Кількість на складі: {Quantity} шт.\n";
        }

        public static string GetJsonFilePath(string jsonFilePath)
        {
            string projectDirectory = Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName;
            return Path.Combine(projectDirectory, jsonFilePath);
        }

        public static List<Product> LoadProducts(string jsonFilePath)
        {
            string productsJsonPath = GetJsonFilePath(jsonFilePath);
            string productsJson = File.ReadAllText(productsJsonPath);
            List<Product> ? productsData = JsonConvert.DeserializeObject<List<Product>>(productsJson);

            List<Product> products = new();

            foreach (var productData in productsData)
            {
                products.Add(new Product
                {
                    ID = productData.ID,
                    Name = productData.Name,
                    Description = productData.Description,
                    Price = productData.Price,
                    Quantity = productData.Quantity,
                    Image = productData.Image,
                    Developer = productData.Developer
                });
            }

            return products;
        }

        public List<Product> FilterProducts(int minId, int maxId)
        {
            string jsonFilePath = Constants.productspath;
            List<Product> products = LoadProducts(jsonFilePath);
            List<Product> filteredProducts = products.Where(p => p.ID >= minId && p.ID <= maxId).ToList();
            return filteredProducts;
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

        public static int GetNextAvailableId(List<Product> products)
        {
            int maxId = 0;
            foreach (var product in products)
            {
                if (product.ID > maxId)
                {
                    maxId = product.ID;
                }
            }
            return maxId + 1;
        }

        public int CompareTo(Product other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
