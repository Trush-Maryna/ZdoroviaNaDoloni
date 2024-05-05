using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.Classes.Interfaces;

namespace ZdoroviaNaDoloni.Classes
{
    public class Registered : User, ISearchableCities
    {
        private string? name;
        private string? surname;
        private DateTime? birthDate;
        private string? city;

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

        public DateTime? BirthDate 
        { 
            get => birthDate; 
            set => birthDate = value; 
        }

        public string? City
        {
            get => city;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 0)
                    city = value;
                else
                    throw new ArgumentException("City cannot be empty.");
            }
        }

        public DiscountCard? Card { get; set; }

        public List<OrderBasket>? Orders { get; set; }
        public List<Feedback>? Feedbacks { get; set; }

        public Registered() { }

        public Registered(string phoneNumber, string password, Genders gender) 
            : base(phoneNumber, password, gender)
        {
            Orders = new List<OrderBasket>();
            Feedbacks = new List<Feedback>();
            Card = null;
        }

        public Registered(string? name, string? surname, DateTime? birthDate, string? city, string phoneNumber, string password, DiscountCard? card, List<OrderBasket>? orders, List<Feedback>? feedbacks, Genders gender) 
            : base(phoneNumber, password, gender)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            City = city;
            Card = card;
            Orders = orders ?? new List<OrderBasket>();
            Feedbacks = feedbacks ?? new List<Feedback>();
        }

        public delegate void ProductFoundEventHandler(Product product);
        public event ProductFoundEventHandler ProductFound;

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

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(PhoneNumber))
            {
                throw new InvalidOperationException("Required fields are missing.");
            }

            Orders ??= new List<OrderBasket>();
            Orders.Add(new OrderBasket(products));
        }

        public DiscountCard AddDiscountCard(string ownerName, string ownerSurname, Discounts userDiscount, DateTime creationDate)
        {
            if (Card == null)
            {
                string code = GenerateDiscountCardCode();
                var card = new DiscountCard(ownerName, ownerSurname, userDiscount, creationDate);
                Card = card;
                return card;
            }
            else
            {
                throw new InvalidOperationException("This user already has a discount card.");
            }
        }

        private string GenerateDiscountCardCode()
        {
            return Guid.NewGuid().ToString().Substring(0, 13);
        }

        public void AddFeedback(Feedback feedback)
        {
            Feedbacks?.Add(feedback);
        }

        public void DeleteAccount()
        {
            Name = null;
            Surname = null;
            BirthDate = null;
            City = null;
            Card = null;
            Orders = null;
            Feedbacks = null;
        }

        public List<string> SearchCities(string query)
        {
            return new List<string>();
        }
    }
}
