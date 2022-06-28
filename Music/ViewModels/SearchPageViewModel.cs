using System.Collections.ObjectModel;

namespace Music.ViewModels
{
    public partial class SearchPageViewModel : BaseViewModel
    {
        #region Members
        private readonly INavBarService androidNavBarService;

        [ObservableProperty]
        ObservableCollection<SearchCategory> searchCatList;

        [ObservableProperty]
        string searchText;

        #endregion

        #region Constructor
        public SearchPageViewModel(INavBarService androidNavBarService, INavigationService navigationService): base(navigationService)
        {
            this.androidNavBarService = androidNavBarService;
        }
        #endregion

        #region Methods

        public async override Task InitializeAsync(INavigationParameters parameters)
        {
            await Initialize();
        }

        public async Task Initialize()
        {
            PageStatusColor = Color.FromHex("#1c1c1e");
            PageBavBarSeparatorColor = Color.FromHex("#1c1c1e");
#if ANDROID
            androidNavBarService.SetStatusBarColor(PageStatusColor);
            androidNavBarService.SetNavSeparationColor(PageBavBarSeparatorColor);
#endif

            ////Load Data
            IsBusy = true;
            
            //simulate live loading of data;
            //await Task.Delay(2000);
            await LoadData();
            IsBusy = false;
            
        }

        async Task LoadData()
        {

            try
            {
                Random rnd = new Random();
                var searchcats = LocalSearchCatList.OrderBy(x => rnd.Next());
                if (searchcats != null)
                {
                    SearchCatList = new ObservableCollection<SearchCategory>(searchcats);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        #endregion

        #region Properties
        List<SearchCategory> LocalSearchCatList = new List<SearchCategory>
        {
            new SearchCategory
            {
                Title = "Apple Music Live: Harry Styles",
                Image = "harry"
            },
            new SearchCategory
            {
                Title = "Hits",
                Image = "drake"
            },
            new SearchCategory
            {
                Title = "African",
                Image = "wizkid"
            },
            new SearchCategory
            {
                Title = "Punk",
                Image = "avril"
            },
            new SearchCategory
            {
                Title = "Hip-Hop",
                Image = "lamar"
            },
            new SearchCategory
            {
                Title = "RNB",
                Image = "abisha"
            },
            new SearchCategory
            {
                Title = "Pop",
                Image = "other"
            },
            new SearchCategory
            {
                Title = "Apple Music Live: Harry Styles",
                Image = "harry"
            },
            new SearchCategory
            {
                Title = "Hits",
                Image = "drake"
            },
            new SearchCategory
            {
                Title = "African",
                Image = "wizkid"
            },
            new SearchCategory
            {
                Title = "Punk",
                Image = "avril"
            },
            new SearchCategory
            {
                Title = "Hip-Hop",
                Image = "lamar"
            },
            new SearchCategory
            {
                Title = "RNB",
                Image = "abisha"
            },
            new SearchCategory
            {
                Title = "Pop",
                Image = "other"
            },

        };
        #endregion

    }
}
