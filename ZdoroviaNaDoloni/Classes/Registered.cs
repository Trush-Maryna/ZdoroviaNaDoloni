namespace ZdoroviaNaDoloni.Classes
{
    public class Registered : User
    {
        private string? name;
        private string? surname;
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

        public List<OrderBasket>? Orders { get; set; }
        public List<Feedback>? Feedbacks { get; set; }
        public int PhoneNumber1 { get; }
        public string NumNP1 { get; }

        public Registered() { }

        public Registered(string phoneNumber, string password) 
            : base(phoneNumber, password)
        {
            Orders = new List<OrderBasket>();
            Feedbacks = new List<Feedback>();
        }

        public Registered(string? name, string? surname, string? city, string phoneNumber, string password, List<OrderBasket>? orders, List<Feedback>? feedbacks) 
            : base(phoneNumber, password)
        {
            Name = name;
            Surname = surname;
            City = city;
            Orders = orders ?? new List<OrderBasket>();
            Feedbacks = feedbacks ?? new List<Feedback>();
        }

        public Registered(string phoneNumber, string password, string city, int phoneNumber1, string numNP) : base(phoneNumber, password)
        {
            this.city = city;
            PhoneNumber1 = phoneNumber1;
            NumNP1 = numNP;
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

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(PhoneNumber))
            {
                throw new InvalidOperationException("Required fields are missing.");
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
            Surname = null;
            City = null;
            Orders = null;
            Feedbacks = null;
        }
    }
}
