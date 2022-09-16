using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Navigation;
using System.ComponentModel;


namespace Music.BaseLib.Base;

public partial class BaseViewModel : ObservableObject, INotifyPropertyChanged, IInitialize, IInitializeAsync, INavigationAware, INavigatedAware, IActiveAware, IPageLifecycleAware
{

    #region Members

    [ObservableProperty]
    string title;

    [ObservableProperty]
    bool isBusy;

    [ObservableProperty]
    bool isRefreshing;

    [ObservableProperty]
    Color pageStatusColor;

    [ObservableProperty]
    Color pageNavBarColor;

    [ObservableProperty]
    Color pageBavBarSeparatorColor;

    private bool _isActive;
    public bool IsActive
    {
        get { return _isActive; }
        set
        {
            SetProperty(ref _isActive, value);
            RaiseIsActiveChanged();
        }
    }

    public event EventHandler IsActiveChanged;

    public bool IsNotBusy => !IsBusy;

    public INavigationService NavigationService { get; private set; }
    #endregion

    #region Constructor
    public BaseViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }
    #endregion

    #region ICommands
    //[RelayCommand]
    //async Task GoToListenNowPage() => await NavigationService.NavigateAsync(nameof(ListenPage));

    //[RelayCommand]
    //async Task GoToLibraryPage() => await NavigationService.NavigateAsync(nameof(LibraryPage));

    //[RelayCommand]
    //async Task GoToBrowsePage() => await NavigationService.NavigateAsync(nameof(BrowsePage));

    //[RelayCommand]
    //async Task GoToRadioPage() => await NavigationService.NavigateAsync(nameof(RadioPage));

    //[RelayCommand]
    //async Task GoToSearchPage() => await NavigationService.NavigateAsync(nameof(SearchPage));

    public virtual void Initialize(INavigationParameters parameters)
    {

    }

    public virtual void OnNavigatedFrom(INavigationParameters parameters)
    {

    }

    public virtual void OnNavigatedTo(INavigationParameters parameters)
    {

    }

    public async virtual Task InitializeAsync(INavigationParameters parameters)
    {

    }
    #endregion

    #region Methods
    protected virtual void RaiseIsActiveChanged()
    {
        IsActiveChanged?.Invoke(this, EventArgs.Empty);
    }

    public void OnAppearing()
    {
        //throw new NotImplementedException();
    }

    public void OnDisappearing()
    {
        //throw new NotImplementedException();
    }
    #endregion
}
