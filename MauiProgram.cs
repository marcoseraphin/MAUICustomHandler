using NextMAUIApp.ViewModels;

namespace NextMAUIApp;

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

        // Call static custom entry handler method
        CustomEntryHandler.Handle();

        // Inject (DI) view model into page
        builder.Services.AddSingleton<MainPageModel>();
        builder.Services.AddSingleton<MainPage>();

        // Inject default GeoLocation service into viewmodel constructor
        builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);

        return builder.Build();
    }
}
