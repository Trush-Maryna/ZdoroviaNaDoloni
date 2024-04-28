using ZdoroviaNaDoloni.Classes.Enums;

namespace ZdoroviaNaDoloni.Classes.Interfaces
{
    public interface IAuthorization
    {
        bool Authorized(int phonenumber, string password);
        bool Authorized(int phonenumber, string password, string email);
        void IsInRole(string phonenumber, string email, Roles role);
    }
}
