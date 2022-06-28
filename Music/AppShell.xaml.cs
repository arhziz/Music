using Music.Views.Library;

namespace Music;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        //Register Shell Routes
        Routing.RegisterRoute(nameof(LibraryPage), typeof(LibraryPage));
        Routing.RegisterRoute(nameof(BrowsePage), typeof(BrowsePage));
        //Routing.RegisterRoute(nameof(ListenPage), typeof(ListenPage));
        Routing.RegisterRoute(nameof(RadioPage), typeof(RadioPage));
        Routing.RegisterRoute(nameof(SearchPage), typeof(SearchPage));
        Routing.RegisterRoute(nameof(ArtistsPage), typeof(ArtistsPage));
        Routing.RegisterRoute(nameof(AlbumsPage), typeof(AlbumsPage));
        Routing.RegisterRoute(nameof(SongsPage), typeof(SongsPage));
        Routing.RegisterRoute(nameof(PlaylistsPage), typeof(PlaylistsPage));
        Routing.RegisterRoute(nameof(DownloadedPage), typeof(DownloadedPage));
    }
}
