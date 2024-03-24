namespace ZdoroviaNaDoloni.Classes
{
    public class DiscountCard
    {
        private string code;
        private string ownerName;
        private string ownerSurname;
        private double? userDiscount;
        private DateTime creationDate;

        public string Code { get; private set; }
        public string OwnerName { get; set; }
        public string OwnerSurname { get; set; }
        public double? UserDiscount { get; set; }
        public DateTime CreationDate { get; private set; }

        public DiscountCard(string code, string ownerName, string ownerSurname, double? userDiscount, DateTime creationDate)
        {
            throw new NotImplementedException();
            //Code = code;
            //OwnerName = ownerName;
            //OwnerSurname = ownerSurname;
            //UserDiscount = userDiscount;
            //CreationDate = creationDate;
        }

        public static void CalculateDiscount(double userDiscount, List<Product> orders)
        {
            throw new NotImplementedException();
        }
    }
}
