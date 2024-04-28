namespace ZdoroviaNaDoloni.Classes.Interfaces
{
    public interface ISearchableProducts
    {
        List<Product> SearchProductsByName(List<Product> products, string query);
    }
}
