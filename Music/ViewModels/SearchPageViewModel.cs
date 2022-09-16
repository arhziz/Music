using System.Collections.ObjectModel;

namespace Music.ViewModels
{
    public partial class SearchPageViewModel : BaseViewModel
    {
        #region Members
        private readonly INavBarService androidNavBarService;
        private int visitCounter = 0;
        
        public ObservableCollection<SearchCategory> SearchCatList { get; set; } = new ObservableCollection<SearchCategory>();

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
            
        }

        protected override async void RaiseIsActiveChanged()
        {
            base.RaiseIsActiveChanged();
            if (IsActive)
            {
                if (visitCounter < 1)
                {
                    IsBusy = true;

                    await InitializeData();
                    IsBusy = false;
                    //Increment counter
                    visitCounter++;
                }
            }
                

        }

        public async Task InitializeData()
        {
            PageStatusColor = Color.FromHex("#1c1c1e");
            PageBavBarSeparatorColor = Color.FromHex("#1c1c1e");
#if ANDROID
            //Set the android Status bar Colors 
            androidNavBarService.SetStatusBarColor(PageStatusColor);
            androidNavBarService.SetNavSeparationColor(PageBavBarSeparatorColor);
#endif

           

            //simulate live loading of data;
            await Task.Delay(2000);
            LoadData();
           

        }

        async void LoadData()
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
