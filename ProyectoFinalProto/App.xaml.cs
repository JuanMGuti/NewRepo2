using ProyectoFinalProto.Models;
using ProyectoFinalProto.Services.ProductService;


namespace ProyectoFinalProto
{
    public partial class App : Application
    {
        public static UserInfo UserInfo;
        public static ProductService _productService;

        public static ProductService ProductService
        {
            get
            {
                if(_productService == null)
                {
                    _productService = new ProductService(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"ProductDB.db3"));
                }
                return _productService;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}