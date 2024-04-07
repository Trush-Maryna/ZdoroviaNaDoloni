using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.Classes.Interfaces;

namespace ZdoroviaNaDoloni.Classes
{
    public class Pharmacist : User, ISearchableCities
    {
        private string? name;
        private string? surname;
        private string uniqueEmail;
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
                    throw new ArgumentException("Name cannot be empty.");
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
                    throw new ArgumentException("Surname cannot be empty.");
            }
        }
        public string UniqueEmail
        {
            get => uniqueEmail;
            set => uniqueEmail = value;
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
        public List<DiscountCard>? Cards { get; set; }
        public List<Feedback>? Feedbacks { get; set; }

        public Pharmacist(string uniquePhoneNumber, string uniquePass, Roles role, Genders gender) 
            : base(uniquePhoneNumber, uniquePass, role, gender)
        {
            UniquePhoneNumber = uniquePhoneNumber;
            UniquePass = uniquePass;
            Orders = new List<OrderBasket>();
            Feedbacks = new List<Feedback>();
            Cards = new List<DiscountCard>();
        }

        public Pharmacist(string uniqueEmail) 
            : base(uniqueEmail)
        {
            Orders = new List<OrderBasket>();
            Feedbacks = new List<Feedback>();
            Cards = new List<DiscountCard>();
        }

        public Pharmacist(string? name, string? surname, string uniquePhoneNumber, string uniquePass, Roles role, Genders gender, List<OrderBasket>? orders, List<DiscountCard>? cards, List<Feedback>? feedbacks) 
            : this(uniquePhoneNumber, uniquePass, role, gender)
        {
            Name = name;
            Surname = surname;
            Orders = orders ?? new List<OrderBasket>();
            Cards = cards;
            Feedbacks = feedbacks ?? new List<Feedback>();
        }

        public void FindProduct(List<Product> products)
        {
            throw new NotImplementedException(); // json
        }

        public int ReceiveOrderCount()
        {
            if (Orders == null || Orders.Count == 0)
                throw new InvalidOperationException("No orders found for this account.");

            return Orders.Count;
        }

        public List<OrderBasket> ReceiveOrders()
        {
            if (Orders == null || Orders.Count == 0)
                throw new InvalidOperationException("No orders found for this account.");

            return Orders;
        }

        public void OrderProducts(List<Product> products)
        {
            if (Orders == null)
                Orders = new List<OrderBasket>();

            foreach (var product in products)
            {
                if (product.Quantity <= 0)
                {
                    throw new InvalidOperationException($"The quantity of {product.Name} is not available.");
                }
            }

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(UniqueEmail) || string.IsNullOrEmpty(UniquePhoneNumber))
            {
                throw new InvalidOperationException("Required fields are missing.");
            }

            Orders ??= new List<OrderBasket>();
            Orders.Add(new OrderBasket(products));
        }

        public DiscountCard AddDiscountCard(string ownerName, string ownerSurname, Discounts userDiscount, DateTime creationDate)
        {
            string code = GenerateDiscountCardCode();
            var card = new DiscountCard(ownerName, ownerSurname, userDiscount, creationDate);

            if (Cards == null)
                Cards = new List<DiscountCard>();

            Cards.Add(card);
            return card;
        }

        private string GenerateDiscountCardCode()
        {
            return Guid.NewGuid().ToString().Substring(0, 13);
        }

        public void RemoveDiscountCard(DiscountCard card) => Cards?.Remove(card);

        public void AddFeedback(Feedback feedback)
        {
            Feedbacks ??= new List<Feedback>();
            Feedbacks.Add(feedback);
        }

        public void EditFeedback(Feedback feedback, Feedback newFeedback)
        {
            if (Feedbacks != null && Feedbacks.Contains(feedback))
            {
                int index = Feedbacks.IndexOf(feedback);
                Feedbacks[index] = newFeedback;
            }
        }

        public void DeleteFeedback(Feedback feedback) => Feedbacks?.Remove(feedback);

        public void EditProduct(Product product, string newName, string newDescription, decimal newPrice)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");

            product.Name = newName;
            product.Description = newDescription;
            product.Price = newPrice;
        }

        public void DeleteProducts(Product product)
        {
            if (Orders != null && Orders.Any(order => order.Orders.Contains(product)))
            {
                throw new InvalidOperationException("Cannot delete product as it is present in an order.");
            }

            Products?.Remove(product);
        }

        public void DeleteAccount()
        {
            Name = null;
            Surname = null;
            Orders = null;
            Cards = null;
            Feedbacks = null;
        }

        public List<string> SearchCities(string query) => throw new NotImplementedException();
    }
}
