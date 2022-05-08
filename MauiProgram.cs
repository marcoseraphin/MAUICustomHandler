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

        builder.Services.AddSingleton<MainPageModel>();
        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
    }
}
