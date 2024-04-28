using ZdoroviaNaDoloni.Classes.Enums;

namespace ZdoroviaNaDoloni.Classes.Interfaces
{
    public interface IRegistration
    {
        bool Register(int phonenumber, string password, bool confidentmark);
        void IsInRole(string phonenumber, Roles role);
    }
}
