using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.Classes.Interfaces;

namespace ZdoroviaNaDoloni
{
    public class Product: IProductManagement, Classes.Interfaces.IComparable<Product>
    {
        private static int id = 1;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Statuses Status { get; set; }
        public Categories Category { get; set; }
        public Discounts TotalDiscount { get; set; }
        public bool Confirmation { get; private set; }

        public List<Feedback>? Feedbacks { get; set; }

        public Product(string name, string description, decimal price, int quantity, Statuses status, Categories category, Discounts totalDiscount, List<Feedback>? feedbacks)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description cannot be empty.");

            if (price <= 0)
                throw new ArgumentException("Price must be positive.");

            if (quantity <= 0)
                throw new ArgumentException("Quantity must be positive.");

            ID = id++;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Status = status;
            Category = category;
            TotalDiscount = totalDiscount;
            Feedbacks = feedbacks;
        }

        public void StockUpdated(int newQuantity)
        {
            if (newQuantity < 0)
                throw new ArgumentException("Quantity cannot be negative.");

            Quantity = newQuantity;
            Confirmation = true;
        }

        public void GenerateID(string jsonFile)
        {
            List<Product> products = LoadProduct(jsonFile);
            foreach (var product in products)
            {
                product.ID = id++;
            }
        }

        public List<Product> LoadProduct(string source)
        {
            return new List<Product>();
        }

        public int CompareTo(Product other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
