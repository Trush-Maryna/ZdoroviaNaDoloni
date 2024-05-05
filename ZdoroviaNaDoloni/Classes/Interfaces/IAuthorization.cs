using ZdoroviaNaDoloni.Classes.Enums;

namespace ZdoroviaNaDoloni.Classes.Interfaces
{
    public interface IAuthorization
    {
        bool Authorized(int phonenumber, string password);
    }
}
