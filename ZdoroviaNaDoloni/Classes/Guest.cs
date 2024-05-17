using ZdoroviaNaDoloni.Classes.Interfaces;

namespace ZdoroviaNaDoloni.Classes
{
    public class Guest : User, ISearchableProducts
    {
        private static int id = 1;

        public static int ID => id++;

        public Guest() {}
    }
}
