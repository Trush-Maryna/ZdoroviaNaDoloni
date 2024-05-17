using MySql.Data.MySqlClient;

namespace ZdoroviaNaDoloni
{
    public sealed class Constants
    {
        private static readonly Constants instance = new Constants();

        private Constants() { }

        public static Constants Instance
        {
            get
            {
                return instance;
            }
        }

        public int xCoord = 20;
        public int yCoord = 20;
        public string TelegramLink = "https://t.me/ZdoroviaNaDoloni_Bot";
        public string ConditionsRulesLink = "https://policies.google.com/terms?hl=uk";

        public string SlideImgUrl1 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\First_Form\Img_Show_1.jpg";
        public string SlideImgUrl2 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\First_Form\Img_Show_2.jpg";
        public string SlideImgUrl3 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\First_Form\Img_Show_3.jpg";
        public string SlideImgUrl4 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\First_Form\Img_Show_4.jpg";
        public int SlideTimerInterval = 3000;
        public string InfoShowUrl1 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Guest_Home_1\Info_Show_1.jpg";
        public string InfoShowUrl2 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Guest_Home_1\Info_Show_2.jpg";
        public string InfoShowUrl3 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Guest_Home_1\Info_Show_3.jpg";
        public string InfoShowUrl4 = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Guest_Home_1\Info_Show_4.jpg";

        public double KharkivCityPositionX = 49.988358;
        public double KharkivCityPositionY = 36.232845;
        public int MinZoom = 1;
        public int MaxZoom = 18;
        public int Zoom = 10;
        public string pharmpath = @"Classes\Json\pharmacies.json";

        public string EyeOpenUrl = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Eye_Btn_Open.jpg";
        public string EyeHideUrl = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Eye_Btn_Hide.jpg";
        public string CheckOpenUrl = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Registration_Form\Check_Open.jpg";
        public string CheckHideUrl = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Guest\Registration_Form\Check_Hide.jpg";
        public string CheckInfoOpenUrl = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Registered\Registered_Info_User\Check_Open.jpg";
        public string CheckInfoCloseUrl = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Registered\Registered_Info_User\Check_Close.jpg";
        public string StarOpenURL = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Feedback\Btn_Star_Check.jpg";
        public string StarHideURL = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\Images\Feedback\Btn_Star_Hide.jpg";

        public string productspath = @"Classes\Json\products.json";
        public string feedbackspath = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\ZdoroviaNaDoloni\bin\Debug\Classes\Json\feedbacks.json";
        public string panelspath = @"Classes\Json\panel_state.json";
        public string receiptpath = @"D:\VS Community\C#.NET_2\ZdoroviaNaDoloni\ZdoroviaNaDoloni\bin\Debug";

        public readonly int MinPassLength = 6;
        public readonly int MaxPassLength = 15;
        public readonly int MinPhoneNumbLength = 9;

        public MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=M4rrra4ma_4;database=zdorovianadoloni");

        public int pharm1phone = 666695822;
        public string pharm1pass = "Mfjkcnst1256lsm";
        public int pharm2phone = 952178855;
        public string pharm2pass = "Vfjkcnst1256lsm";
        public int pharm3phone = 502660795;
        public string pharm3pass = "Sfjkcnst1256lsm";
    }
}
