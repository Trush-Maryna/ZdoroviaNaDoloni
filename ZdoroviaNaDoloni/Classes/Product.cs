using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.Classes.Interfaces;

namespace ZdoroviaNaDoloni
{
    public class Product: IProductManagement, Classes.Interfaces.IComparable<Product>
    {
        private static int id;
        private string name;
        private string description;
        private decimal price;
        private int quantity;

        private Statuses status;
        private Categories category;
        private TotalDiscounts totalDiscount;

        public static int ID => ID;
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Statuses Status { get; set; }
        public Categories Category { get; set; }
        public TotalDiscounts TotalDiscount { get; set; }

        private List<Feedback>? Feedbacks { get; set; }

        public Product(string name, string description, decimal price, int quantity, Statuses status, Categories category, TotalDiscounts totalDiscount, List<Feedback>? feedbacks)
        {
            throw new NotImplementedException();
            //Name = name;
            //Description = description;
            //Price = price;
            //Quantity = quantity;
            //Status = status;
            //Category = category;
            //TotalDiscount = totalDiscount;
            //Feedbacks = feedbacks;
        }

        public static void StockUpdated() 
        {
            throw new NotImplementedException();
        }

        public static void GenerateID(int id) 
        {
            throw new NotImplementedException();
        }

        public void LoadFromJson(string jsonFile)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Product other)
        {
            throw new NotImplementedException();
        }
    }
}
