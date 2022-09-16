

using Music.Library.ViewModels;
using Music.Library.Views;

namespace Music.Library
{
    public static class ContainerRegistry
    {
        public static void RegisterPagesLibrary(this IContainerRegistry c)
        {
            //Register any page that have not implement the marker interface
            c.RegisterForNavigation<ArtistsPage, ArtistPageViewModel>();
            c.RegisterForNavigation<AlbumsPage, AlbumPageViewModel>();
            c.RegisterForNavigation<SongsPage, SongsPageViewModel>();
            c.RegisterForNavigation<PlaylistsPage, PlaylistsPageViewModel>();
            c.RegisterForNavigation<DownloadedPage, DownloadedPageViewModel>();

        }

        public static void RegisterServices(this IContainerRegistry containerRegistry)
        {
            //  containerRegistry.Register<IAppSettingsConfig, AppSettingsConfig>();
        }
    }
}
