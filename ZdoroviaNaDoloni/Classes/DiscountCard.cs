using ZdoroviaNaDoloni.Classes.Enums;

namespace ZdoroviaNaDoloni.Classes
{
    public class DiscountCard
    {
        private string code;
        private Guid cardId;
        private string ownerName;
        private string ownerSurname;
        private Discounts userDiscount;
        private DateTime creationDate;

        public string Code
        {
            get => code;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length == 13 && value.Distinct().Count() == value.Length)
                    code = value;
                else
                    throw new ArgumentException("Invalid code. It must be a non-empty string with length 13 and unique characters.");
            }
        }
        public Guid CardId
        {
            get => cardId;
            private set => cardId = value;
        }
        public string OwnerName
        {
            get => ownerName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 0)
                    ownerName = value;
                else
                    throw new ArgumentException("Owner name cannot be empty.");
            }
        }
        public string OwnerSurname
        {
            get => ownerSurname;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 0)
                    ownerSurname = value;
                else
                    throw new ArgumentException("Owner surname cannot be empty.");
            }
        }
        public Discounts UserDiscount
        {
            get => userDiscount;
            set => userDiscount = value;
        }
        public DateTime CreationDate { get; private set; }

        public DiscountCard(string ownerName, string ownerSurname, Discounts userDiscount, DateTime creationDate)
        {
            OwnerName = ownerName;
            OwnerSurname = ownerSurname;
            UserDiscount = userDiscount;
            CreationDate = creationDate;
            Code = GenerateDiscountCardCode();
            CardId = Guid.NewGuid();
        }

        private string GenerateDiscountCardCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 13)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void CalculateDiscount(List<OrderBasket> orders)
        {
            if (orders == null)
                throw new ArgumentNullException(nameof(orders), "Orders cannot be null.");

            int orderCount = orders.Count;
            UserDiscount = GetDiscountRate(orderCount);
        }

        private Discounts GetDiscountRate(int orderCount)
        {
            if (orderCount >= 20)
                return Discounts.Twenty;
            else if (orderCount >= 15)
                return Discounts.Fifteen;
            else if (orderCount >= 10)
                return Discounts.Ten;
            else if (orderCount >= 5)
                return Discounts.Five;
            else
                return Discounts.Null;
        }
    }
}
