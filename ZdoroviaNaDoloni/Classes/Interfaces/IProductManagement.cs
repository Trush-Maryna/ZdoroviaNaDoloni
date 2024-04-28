namespace ZdoroviaNaDoloni.Classes.Interfaces
{
    public interface IProductManagement
    {
        List<Product> LoadProducts(string jsonFilePath);
    }
}
