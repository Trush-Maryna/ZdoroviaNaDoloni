using MySql.Data.MySqlClient;

namespace ZdoroviaNaDoloni
{
    public static class Constants
    {
        public const int xCoord = 20;
        public const int yCoord = 20;
        public const string TelegramLink = "https://t.me/ZdoroviaNaDoloni_Bot";

        public const string SlideImgUrl1 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\First_Form\Img_Show_1.jpg";
        public const string SlideImgUrl2 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\First_Form\Img_Show_2.jpg";
        public const string SlideImgUrl3 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\First_Form\Img_Show_3.jpg";
        public const string SlideImgUrl4 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\First_Form\Img_Show_4.jpg";
        public const int SlideTimerInterval = 3000;
        public const string InfoShowUrl1 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Guest_Home_1\Info_Show_1.jpg";
        public const string InfoShowUrl2 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Guest_Home_1\Info_Show_2.jpg";
        public const string InfoShowUrl3 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Guest_Home_1\Info_Show_3.jpg";
        public const string InfoShowUrl4 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Guest_Home_1\Info_Show_4.jpg";

        public const double KharkivCityPositionX = 49.988358;
        public const double KharkivCityPositionY = 36.232845;
        public const int MinZoom = 1;
        public const int MaxZoom = 18;
        public const int Zoom = 10;
        public const string pharmpath = @"Classes\Json\pharmacies.json";

        public const string EyeOpenUrl = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Eye_Btn_Open.jpg";
        public const string EyeHideUrl = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Eye_Btn_Hide.jpg";
        public const string CheckOpenUrl = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Registration_Form\Check_Open.jpg";
        public const string CheckHideUrl = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Registration_Form\Check_Hide.jpg";

        public const string productspath = @"Classes\Json\products.json";
        public const string productsSmallpath = @"Classes\Json\products_small.json";

        public static readonly int MinPassLength = 6;
        public static readonly int MaxPassLength = 20;
        public static readonly int MinPhoneNumbLength = 9;

        public static MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=08mar040;database=zdorovianadoloni");

        public const int pharm1phone = 666695822;
        public const string pharm1pass = "Mfjkcnst1256lsm";
        public const int pharm2phone = 952178855;
        public const string pharm2pass = "Vfjkcnst1256lsm";
        public const int pharm3phone = 502660795;
        public const string pharm3pass = "Sfjkcnst1256lsm";
    }
}
