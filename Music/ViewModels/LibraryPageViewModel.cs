using Music.Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Music.ViewModels
{
    public partial class LibraryPageViewModel : Music.BaseLib.Base.BaseViewModel
    {
        #region Members
        [ObservableProperty]
        ObservableCollection<LibraryItems> libraries;

        [ObservableProperty]
        ObservableCollection<Album> recentlyAdded;

        [ObservableProperty]
        double albumWidth;

        
        LibraryItems selectedItem;

        public LibraryItems SelectedItem
        {
            get => selectedItem;
            set
            {
                SetProperty(ref selectedItem, value);
                if(selectedItem != null)
                {
                    OpenLibraryItem(selectedItem);

                }
            }
        }


        private readonly INavigationService navigationService;
        #endregion

        #region Constructor
        public LibraryPageViewModel(INavigationService navigationService):base(navigationService)
        {
            Title = "Library";
            this.navigationService = navigationService;


        }
        #endregion

        #region Methods

        public async override void Initialize(INavigationParameters parameters)
        {
            await GetData();
        }

        public async Task GetData()
        {
            var deviceDisplay = DeviceDisplay.Current;
            var displayWidth = deviceDisplay.MainDisplayInfo.Width;
            //if(displayWidth > )
            //simulate live data loading
            IsBusy = true;
            //await Task.Delay(2000);
            LoadDatas();
            IsBusy = false;
        }
        void LoadDatas()
        {
            Random rnd = new Random();
            try
            {
                //Liberary Items
                if (localLibraryItem != null)
                {
                    if (Libraries != null)
                        Libraries.Clear();

                    Libraries = new ObservableCollection<LibraryItems>(localLibraryItem);
                }

                //Recently Added
                var added =  localRecentlyAdded.OrderBy(x => rnd.Next());
                if(added != null)
                {
                    if(RecentlyAdded != null)
                        RecentlyAdded.Clear();

                    RecentlyAdded = new ObservableCollection<Album>(added);

                }
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }
        #endregion

        #region ICommands
        public ICommand LibraryItemClickedCommand => new DelegateCommand<LibraryItems>(OpenLibraryItem);

        private async void OpenLibraryItem(LibraryItems obj)
        {
            //throw new NotImplementedException();
            SelectedItem = null;
            if (obj.PageString != null)
                await navigationService.NavigateAsync(obj.PageString);

        }

        #endregion

        #region Properties
        List<LibraryItems> localLibraryItem = new List<LibraryItems>
        {
            new LibraryItems
            {
                Title = "Playlists",
                Icon = IconFont.PlaylistMusic,
                PageString = nameof(PlaylistsPage)
            },
            new LibraryItems
            {
                Title = "Artists",
                Icon = IconFont.MicrophoneVariant,
                PageString = nameof(PlaylistsPage)
            },
            new LibraryItems
            {
                Title = "Albums",
                Icon = IconFont.Album,
                PageString = nameof(AlbumsPage)
            },
            new LibraryItems
            {
                Title = "Songs",
                Icon = IconFont.MusicNote,
                PageString = nameof(SongsPage)
            },
            new LibraryItems
            {
                Title = "Downloaded",
                Icon = IconFont.ArrowDownCircleOutline,
                PageString = nameof(DownloadedPage)
            },
            new LibraryItems
            {
                Title = "TV & Movies",
                Icon = IconFont.Television
            }
        };

        List<Album> localRecentlyAdded = new List<Album>
        {
            new Album
            {
                Title = "Avril Lavigne",
                Artist = new Artist
                {
                    Title  = "Avril Lavigne"
                },
                AlbumArt = "avrillavigne.jpg"
            },
            new Album
            {
                Title = "Let Go",
                Artist = new Artist
                {
                    Title  = "Avril Lavigne"
                },
                AlbumArt = "letgo.jpg"
            },
            new Album
            {
                Title = "Under My Skin",
                Artist = new Artist
                {
                    Title  = "Avril Lavigne"
                },
                AlbumArt = "undermyskin.png"
            },
            new Album
            {
                Title = "The Best Damn Thing",
                Artist = new Artist
                {
                    Title  = "Avril Lavigne"
                },
                AlbumArt = "thebestdamnthing.jpg"
            },
            new Album
            {
                Title = "Head Above Water",
                Artist = new Artist
                {
                    Title  = "Avril Lavigne"
                },
                AlbumArt = "headabovewater.jpg"
            },
            new Album
            {
                Title = "Love Sux",
                Artist = new Artist
                {
                    Title  = "Avril Lavigne"
                },
                AlbumArt = "lovesux.jpg"
            },
            new Album
            {
                Title = "1989",
                Artist = new Artist
                {
                    Title  = "Taylor Swift"
                },
                AlbumArt = "dlx.png"
            },
            new Album
            {
                Title = "Red",
                Artist = new Artist
                {
                    Title  = "Taylor Swift"
                },
                AlbumArt = "red.png"
            },
            new Album
            {
                Title = "Folklore",
                Artist = new Artist
                {
                    Title  = "Nelly Furtado"
                },
                AlbumArt = "folklore.png"
            },
            new Album
            {
                Title = "Loose",
                Artist = new Artist
                {
                    Title  = "Nelly Furtado"
                },
                AlbumArt = "loose.jpg"
            },
            new Album
            {
                Title = "Nelly Furtado: Best Hits",
                Artist = new Artist
                {
                    Title  = "Nelly Furtado"
                },
                AlbumArt = "hits.jpg"
            },
            new Album
            {
                Title = "Cassie",
                Artist = new Artist
                {
                    Title  = "Cassie"
                },
                AlbumArt = "cassie.jpg"
            },
            new Album
            {
                Title = "LAX",
                Artist = new Artist
                {
                    Title  = "The Game"
                },
                AlbumArt = "lax.jpg"
            },
            new Album
            {
                Title = "Red",
                Artist = new Artist
                {
                    Title  = "The Game"
                },
                AlbumArt = "redgame.jpg"
            },
            new Album
            {
                Title = "The Documantary",
                Artist = new Artist
                {
                    Title  = "The Game"
                },
                AlbumArt = "thedoc.png"
            },
        };
        #endregion
    }
}
