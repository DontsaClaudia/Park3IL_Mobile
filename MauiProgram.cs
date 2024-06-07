using Microsoft.Extensions.Logging;
using Park3IL_Mobile;

namespace Park3IL_Mobile
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
                    fonts.AddFont("Poppins-Regular.ttf","Poppins");
                    fonts.AddFont("materialdesignicons-webfont.ttf","Material Design Icons");
                })

                .ConfigureMauiHandlers(handlers =>
                {
                    handlers.AddHandler<NavigationPage, UXDivers.Grial.GrialNavigationPageHandler>();
                    handlers.AddHandler<ScrollView, Park3IL_Mobile.ScrollViewHandler>();
                    handlers.AddHandler<Label, Park3IL_Mobile.LabelHandler>();
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
