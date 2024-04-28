namespace ZdoroviaNaDoloni.GUInterfaces.Product_GUI
{
    public partial class Info_Product_Form : Form
    {
        private Point previousLocation;
        private readonly Product product;

        public Info_Product_Form()
        {
            InitializeComponent();
        }

        public Info_Product_Form(Product product)
        {
            InitializeComponent();
            this.product = product;
        }
    }
}
