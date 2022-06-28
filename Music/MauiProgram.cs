using Music.Helpers.Interfaces;
using Prism;
using Prism.Ioc;

#if ANDROID
    using static Music.MainActivity;
#endif


namespace Music;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{


        var builder = MauiApp.CreateBuilder()
            .UsePrismApp<App>(prism =>
            prism.RegisterTypes(c =>
            {
                c.RegisterForNavigation<SearchPage, SearchPageViewModel>();
                c.RegisterForNavigation<ListenPage, ListenPageViewModel>();
                c.RegisterForNavigation<LibraryPage, LibraryPageViewModel>();
                c.RegisterForNavigation<BrowsePage, BrowsePageViewModel>();
                c.RegisterForNavigation<RadioPage, RadioPageViewModel>();
                c.RegisterForNavigation<MainTabbedPage>();

            })
            .OnAppStart(nameof(MainTabbedPage)))
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMarkup()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("materialdesignicons-webfont.ttf", "MDI");
                fonts.AddFont("Montserrat-Black.ttf", "MontserratBlack");
                fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold");
                fonts.AddFont("Montserrat-ExtraBold.ttf", "MontserratExtraBold");
                fonts.AddFont("Montserrat-Light.ttf", "MontserratLight");
                fonts.AddFont("Montserrat-Medium.ttf", "MontserratMedium");
                fonts.AddFont("Montserrat-Regular.ttf", "MontserratRegular");
                fonts.AddFont("Montserrat-SemiBold.ttf", "MontserratSemiBold");
                fonts.AddFont("Montserrat-Thin.ttf", "MontserratThin");
                fonts.AddFont("icomoon.ttf", "ICO");
            });

        //Register Services
        builder.Services.AddSingleton<IEntry>(new Entry());

#if ANDROID
        builder.Services.AddSingleton<INavBarService,NavBarService>();
#endif

        //builder.Services.AddSingleton<IWindow>();

        return builder.Build();
	}
}
