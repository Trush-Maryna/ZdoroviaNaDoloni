namespace ZdoroviaNaDoloni.Classes.Interfaces
{
    public interface IProductManagement
    {
        List<Product> FilterProducts(int minId, int maxId);
        int CompareTo(Product other);
    }
}
