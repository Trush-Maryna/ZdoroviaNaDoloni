using Newtonsoft.Json;
using System.Diagnostics;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Enums;
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
        public Discounts TotalDiscount { get; set; }
        public bool Confirmation { get; private set; }

        public List<Feedback>? Feedbacks { get; set; }

        public Product(int id, string name, string descr, decimal price, int quantity)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");

            if (string.IsNullOrWhiteSpace(descr))
                throw new ArgumentException("Description cannot be empty.");

            if (price <= 0)
                throw new ArgumentException("Price must be positive.");

            if (quantity <= 0)
                throw new ArgumentException("Quantity must be positive.");

            ID = id;
            Name = name;
            Description = descr;
            Price = price;
            Quantity = quantity;
        }

        public Product(int id, string name, string description, decimal price, int quantity, Discounts totalDiscount, bool confirmation, List<Feedback>? feedbacks) : this(id, name, description, price, quantity)
        {
            TotalDiscount = totalDiscount;
            Confirmation = confirmation;
            Feedbacks = feedbacks;
        }

        public Product()
        {
        }

        private class ProductData
        {
            public int id { get; set; }
            public string name { get; set; }
            public string descr { get; set; }
            public decimal price { get; set; }
            public int quantity { get; set; }
            public string image { get; set; }
            public string developer { get; set; }
        }

        public string GetProductInfo()
        {
            return $"Назва: {Name}\n" +
                   $"Опис: {Description}\n" +
                   $"Виробник: {Developer}\n" +
                   $"Ціна: {Price} ₴\n" +
                   $"Кількість на складі: {Quantity} шт.\n";
        }

        public void StockUpdated(int newQuantity)
        {
            if (newQuantity < 0)
                throw new ArgumentException("Quantity cannot be negative.");

            Quantity = newQuantity;
            Confirmation = true;
        }

        public List<Product> LoadProducts(string jsonFilePath)
        {
            string projectDirectory = Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName;
            string productsJsonPath = Path.Combine(projectDirectory, jsonFilePath);
            string productsJson = File.ReadAllText(productsJsonPath);
            List<ProductData> productsData = JsonConvert.DeserializeObject<List<ProductData>>(productsJson);

            List<Product> products = new List<Product>();

            foreach (var productData in productsData)
            {
                products.Add(new Product
                {
                    ID = productData.id,
                    Name = productData.name,
                    Description = productData.descr,
                    Price = productData.price,
                    Quantity = productData.quantity,
                    Image = productData.image,
                    Developer = productData.developer
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

        public int CompareTo(Product other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
