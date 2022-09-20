using Music.Helpers.Interfaces;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Prism;
using Music.Library;

#if ANDROID
using static Music.MainActivity;
#endif


namespace Music;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        MauiAppBuilder builder = MauiApp.CreateBuilder()
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit().UseMauiCommunityToolkitMarkup()

            .UsePrism(prism =>
                prism.RegisterTypes(c =>
                {
                    PlatformInitializer.RegisterTypes(c);
                    c.RegisterForNavigation<NavigationPage>();
                    c.RegisterForNavigation<SearchPage, SearchPageViewModel>();
                    c.RegisterForNavigation<ListenPage, ListenPageViewModel>();
                    c.RegisterForNavigation<LibraryPage, LibraryPageViewModel>();
                    c.RegisterForNavigation<BrowsePage, BrowsePageViewModel>();
                    c.RegisterForNavigation<RadioPage, RadioPageViewModel>();
                    c.RegisterForNavigation<MainTabbedPage, MainTabbedPageViewModel>();
                    
                    //Register Library pages
                    c.RegisterPagesLibrary();

                    //Register Services
                    //c.RegisterSingleton<IEntry>();

#if ANDROID
                    c.RegisterSingleton<INavBarService, NavBarService>();
#endif

                })
                .OnAppStart($"{nameof(MainTabbedPage)}?selectedTab=NavigationPage|{nameof(LibraryPage)}"))

                    //.OnAppStart(async (container, navigationService) =>
                    //{
                    //    var result = await navigationService.NavigateAsync($"{nameof(MainTabbedPage)}?selectedTab=NavigationPage|{nameof(LibraryPage)}");
                    //    if (!result.Success)
                    //    {
                    //        // use the container to resolve a logger
                    //        var t = 1;
                    //        Console.WriteLine(result.Exception);
                    //    }
                    //}))

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

        builder.Services.AddSingleton<IShare>(Share.Default);

        //builder.Services.AddRefitClient<ISecurityApi>()
        //   .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.github.com"));

        return builder.Build();
    }
}
