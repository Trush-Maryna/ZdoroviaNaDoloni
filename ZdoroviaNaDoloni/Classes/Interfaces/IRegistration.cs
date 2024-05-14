using MySql.Data.MySqlClient;

namespace ZdoroviaNaDoloni.Classes.Interfaces
{
    public interface IRegistration
    {
        bool Register(int phonenumber, string password, bool confidentmark);
        bool ValidatePhoneNumber(string value);
        bool ValidatePass(string value);
        void openConnectionDB();
        void closeConnectionDB();
        MySqlConnection getConnection();
        bool isUserExists(int phoneNumber);
    }
}
