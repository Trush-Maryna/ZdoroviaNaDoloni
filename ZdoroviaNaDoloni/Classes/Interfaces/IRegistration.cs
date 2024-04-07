using ZdoroviaNaDoloni.Classes.Enums;

namespace ZdoroviaNaDoloni.Classes.Interfaces
{
    public interface IRegistration
    {
        bool IsRegistered(string phonenumber, string password, bool confidentmark);
        void IsInRole(string phonenumber, Roles role);
    }
}
