using Microsoft.Extensions.Logging;
using ProyectoFinalProto.Pages;
using ProyectoFinalProto.ViewModels;
using ProyectoFinalProto.Views;
using HomePage = ProyectoFinalProto.Views.HomePage;

namespace ProyectoFinalProto
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<ContactPage>();
            builder.Services.AddSingleton<AboutPage>();

            builder.Services.AddSingleton<LoginPageViewModel>();
            builder.Services.AddSingleton<ProductPageViewModel>();
            builder.Services.AddSingleton<AddProductPageViewModel>();
#endif

            return builder.Build();
        }
    }
}