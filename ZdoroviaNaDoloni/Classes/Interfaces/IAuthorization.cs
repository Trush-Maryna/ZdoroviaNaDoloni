using MySql.Data.MySqlClient;

namespace ZdoroviaNaDoloni.Classes.Interfaces
{
    public interface IAuthorization
    {
        bool Authorized(int phonenumber, string password);
        bool ValidatePhoneNumber(string value);
        bool ValidatePass(string value);
        MySqlConnection getConnection();
    }
}
