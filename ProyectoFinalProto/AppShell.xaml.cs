using ProyectoFinalProto.Models;
using ProyectoFinalProto.ViewModels;
using ProyectoFinalProto.Views;


namespace ProyectoFinalProto
{
    public partial class AppShell : Shell
    {
        public static UserInfo UserInfo;
        public AppShell()
        {
            InitializeComponent();
            this.BindingContext = new AppShellViewModel();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(AddProductPage), typeof(AddProductPage));

        }
    }
}