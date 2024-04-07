namespace ZdoroviaNaDoloni.Classes.Interfaces
{
    public interface IProductManagement
    {
        void GenerateID(string jsonFile);
        List<Product> LoadProduct(string source);
    }
}
