using ZdoroviaNaDoloni.Classes.Enums;
using ZdoroviaNaDoloni.Classes.Interfaces;

namespace ZdoroviaNaDoloni.Classes
{
    public class Guest : User, ISearchableProducts
    {
        private static int id = 1;

        public static int ID => id++;

        public Guest()
        {
            Role = Roles.Guest;
        }

        public List<Product> SearchProductsByName(List<Product> products, string query)
        {
            List<Product> results = new List<Product>();

            foreach (var product in products)
            {
                if (product.Name.ToLower().Contains(query))
                {
                    results.Add(product);
                }
            }

            return results;
        }
    }
}
