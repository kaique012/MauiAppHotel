using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("Oswald-Bold.ttf", "Oswald-Bold");
                    fonts.AddFont("Oswald-ExtraLight.ttf", "Oswald-ExtraLight");
                    fonts.AddFont("Oswald-Light.ttf", "Oswald-Light");
                    fonts.AddFont("Oswald-Medium.ttf", "Oswald-Medium");
                    fonts.AddFont("Oswald-Regular.ttf", "Oswald-Regular");
                    fonts.AddFont("Oswald-SemiBold.ttf", "Oswald-SemiBold"); 
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
