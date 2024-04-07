using ZdoroviaNaDoloni.Classes.Enums;

namespace ZdoroviaNaDoloni.Classes
{
    public class Guest : User
    {
        private static int id = 1;

        public static int ID => id++;

        public Guest()
        {
            Role = Roles.Guest;
        }

        public bool FindProduct(List<Product> products)
        {
            if (products == null || !products.Any())
            {
                throw new InvalidOperationException("The product list is empty.");
            }

            foreach (var product in products)
            {
                if (string.IsNullOrWhiteSpace(product.Name))
                {
                    throw new ArgumentException("The product name cannot be empty.");
                }

                if (product.Status == Statuses.InStock)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
