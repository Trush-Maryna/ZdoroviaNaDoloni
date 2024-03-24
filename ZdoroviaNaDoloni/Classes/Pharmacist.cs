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

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string UniqueEmail { get; set; }
        public string UniquePhoneNumber { get; set; }
        public string UniquePass { get; set; }

        public List<OrderBasket>? Orders { get; set; }
        public List<DiscountCard>? Cards { get; set; }
        public List<Feedback>? Feedbacks { get; set; }

        public Pharmacist(string uniquePhoneNumber, string uniquePass)
        {
            throw new NotImplementedException();
            //UniquePhoneNumber = uniquePhoneNumber;
            //UniquePass = uniquePass;
            //Role = Roles.Pharmacist;
        }

        public Pharmacist(string uniqueEmail)
        {
            throw new NotImplementedException();
            //UniqueEmail = uniqueEmail;
            //Role = Roles.Pharmacist;
        }

        public Pharmacist(string? name, string? surname, string uniquePhoneNumber, string uniquePass, Genders? gender, List<OrderBasket>? orders, List<DiscountCard>? cards, List<Feedback>? feedbacks) : this(uniquePhoneNumber, uniquePass)
        {
            throw new NotImplementedException();
            //Name = name;
            //Surname = surname;
            //Gender = gender;
            //Orders = orders;
            //Cards = cards;
            //Feedbacks = feedbacks;
        }

        public Pharmacist(string? name, string? surname, string uniqueEmail, Genders? gender, List<OrderBasket>? orders, List<DiscountCard>? cards, List<Feedback>? feedbacks) : this(uniqueEmail)
        {
            throw new NotImplementedException();
            //Name = name;
            //Surname = surname;
            //Gender = gender;
            //Orders = orders;
            //Cards = cards;
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

        public void RemoveDiscountCard(DiscountCard card)
        {
            throw new NotImplementedException();
        }

        public void AddFeedback(Feedback feedback)
        {
            throw new NotImplementedException();
        }

        public void EditFeedback(Feedback feedback, Feedback newfeedback)
        {
            throw new NotImplementedException();
        }

        public void DeleteFeedback(Feedback feedback)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(Product product, string newName, string newDescription, decimal newPrice)
        {
            throw new NotImplementedException();
        }

        public void DeleteProducts(Product product)
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
