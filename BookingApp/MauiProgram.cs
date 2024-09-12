//using BookingApp.Services;
//using BookingApp.ViewModels;
//using BookingApp.Views;
//using Microsoft.Extensions.Logging;

//using Microsoft.Extensions.Logging;
//using CommunityToolkit.Maui;

//namespace BookingApp
//{
//    public static class MauiProgram
//    {
//        public static MauiApp CreateMauiApp()
//        {
//            var builder = MauiApp.CreateBuilder();
//            builder
//                .UseMauiApp<App>()
//                .UseMauiCommunityToolkit()
//                .ConfigureFonts(fonts =>
//                {
//                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
//                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
//                });
//#if DEBUG
//            //builder.Logging.AddDebug();
//#endif

//            //builder.Services.AddSingleton<DatabaseService>();
//            //builder.Services.AddSingleton<BookingPageViewModel>();
//            //builder.Services.AddSingleton<BookingPage>();

//            //builder.Services.AddSingleton<ManageBookingsPageViewModel>();
//            //builder.Services.AddSingleton<ManageBookingsPage>();

//            //builder.Services.AddSingleton<OpeningPageViewModel>();
//            //builder.Services.AddSingleton<OpeningPage>();

//            return builder.Build();
//        }
//    }
//}

using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace BookingApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
