using ZdoroviaNaDoloni.Classes.Enums;

namespace ZdoroviaNaDoloni.Classes.Interfaces
{
    public interface IAuthorization
    {
        bool IsAuthorized(string phonenumber, string password, string email);
        void Authorized(string phonenumber, string password, string email);
        void IsInRole(string phonenumber, string email, Roles role);
    }
}
