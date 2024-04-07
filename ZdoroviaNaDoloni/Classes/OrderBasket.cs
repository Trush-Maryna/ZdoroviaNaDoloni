using System.Collections;
using ZdoroviaNaDoloni.Classes.Enums;

namespace ZdoroviaNaDoloni.Classes
{
    public class OrderBasket : IEnumerable
    {
        protected List<Product> orders;

        public static int CounterOrders => CounterOrders;
        public string DeliveryAddress { get; set; }
        public DeliveryMethods DeliveryMethod { get; set; }
        public decimal TotalCost { get; private set; }
        public List<Product> Orders => orders;

        public DiscountCard? DiscountCard { get; set; }

        public OrderBasket(List<Product>? Orders) 
        {
            orders = Orders;
        }

        public OrderBasket(string deliveryAddress, DeliveryMethods deliveryMethod)
        {
            DeliveryAddress = !string.IsNullOrWhiteSpace(deliveryAddress) ? deliveryAddress : throw new ArgumentException("Delivery address cannot be empty.");
            DeliveryMethod = deliveryMethod;
            orders = new List<Product>();
        }

        public OrderBasket(string deliveryAddress, DeliveryMethods deliveryMethod, DiscountCard? discountCard) 
            : this(deliveryAddress, deliveryMethod)
        {
            DiscountCard = discountCard;
        }

        public event Action OrderCompleted = delegate { };

        public void AddProducts(Product product)
        {
            orders.Add(product);
        }

        public void DeleteProducts(Product product, List<Product> orders)
        {
            orders.Remove(product);
        }

        public void CalculateTotalCost()
        {
            if (orders != null && orders.Count > 0)
            {
                decimal totalCost = orders.Sum(product => product.Price);
                TotalCost = totalCost;
            }
            else
            {
                throw new ArgumentException("Orders list is null or empty.");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return orders.GetEnumerator();
        }
    }
}
