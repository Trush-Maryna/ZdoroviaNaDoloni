using System.Collections;
using ZdoroviaNaDoloni.Classes.Enums;

namespace ZdoroviaNaDoloni.Classes
{
    public class OrderBasket : IEnumerable
    {
        private string deliveryAddress;
        private static int counterOrders;
        private DeliveryMethods deliveryMethod;
        protected List<Product>? orders;

        public static int CounterOrders => CounterOrders;
        public string DeliveryAddress { get; set; }
        public DeliveryMethods DeliveryMethod { get; set; }
        public List<Product>? Orders => Orders;

        protected DiscountCard? DiscountCard { get; set; }

        public OrderBasket(string deliveryAddress, DeliveryMethods deliveryMethod)
        {
            throw new NotImplementedException();
            //DeliveryAddress = deliveryAddress;
            //DeliveryMethod = deliveryMethod;
        }

        public OrderBasket(string deliveryAddress, DeliveryMethods deliveryMethod, DiscountCard? discountCard) : this(deliveryAddress, deliveryMethod)
        {
            throw new NotImplementedException();
            //DiscountCard = discountCard;
        }

        public event Action OrderCompleted = delegate { };

        public void AddProducts(Product product, List<Product> orders)
        {
            throw new NotImplementedException();
        }

        public void DeleteProducts(Product product, List<Product> orders)
        {
            throw new NotImplementedException();
        }

        public static void CalculateTotalCost(List<Product> orders)
        {
            throw new NotImplementedException();
        }

        public void TransferOrderDetails()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
