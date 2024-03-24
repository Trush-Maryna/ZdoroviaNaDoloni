using ZdoroviaNaDoloni.Classes.Interfaces;

namespace ZdoroviaNaDoloni.Classes
{
    public class Registered : User, ISearchableCities
    {
        private string? name;
        private string? surname;
        private DateTime? birthDate;
        private string? city;

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? City { get; set; }

        public DiscountCard? Card { get; set; }

        public List<OrderBasket>? Orders { get; set; }
        public List<Feedback>? Feedbacks { get; set; }

        public Registered(string phoneNumber, string password) : base(phoneNumber, password)
        {
            throw new NotImplementedException();
            //PhoneNumber = phoneNumber;
            //Password = password;
            //Role = Roles.Registered;
        }

        public Registered(string email) : base(email)
        {
            throw new NotImplementedException();
            //Email = email;
            //Role = Roles.Registered;
        }

        public Registered(string? name, string? surname, DateTime? birthDate, string? city, string phoneNumber, string password, DiscountCard? card, List<OrderBasket>? orders, List<Feedback>? feedbacks) : this(phoneNumber, password)
        {
            throw new NotImplementedException();
            //Name = name;
            //Surname = surname;
            //BirthDate = birthDate;
            //City = city;
            //Card = card;
            //Orders = orders;
            //Feedbacks = feedbacks;
        }

        public Registered(string? name, string? surname, DateTime? birthDate, string? city, string email, DiscountCard? card, List<OrderBasket>? orders, List<Feedback>? feedbacks) : this(email)
        {
            throw new NotImplementedException();
            //Name = name;
            //Surname = surname;
            //BirthDate = birthDate;
            //City = city;
            //Card = card;
            //Orders = orders;
            //Feedbacks = feedbacks;
        }

        public void FoundProduct(List<Product> products)
        {
            throw new NotImplementedException();
        }

        public void OrderProducts(List<Product> products)
        {
            throw new NotImplementedException();
        }

        public void AddDiscountCard(DiscountCard card)
        {
            throw new NotImplementedException();
        }

        public void AddFeedback(Feedback feedback)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount()
        {
            throw new NotImplementedException();
        }

        public List<string> SearchCities(string query)
        {
            throw new NotImplementedException();
        }
    }
}
