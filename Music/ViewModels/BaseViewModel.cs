using CommunityToolkit.Mvvm.Input;
using Prism.Navigation;
using System.ComponentModel;
using PropertyChanged;

namespace Music.ViewModels;

public partial class BaseViewModel : ObservableObject, INotifyPropertyChanged, IInitialize, IInitializeAsync, INavigationAware, INavigatedAware
{

    #region Members



    [ObservableProperty]
    string title;

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    bool isRefreshing;

    [ObservableProperty]
    Color pageStatusColor;

    [ObservableProperty]
    Color pageNavBarColor;

    [ObservableProperty]
    Color pageBavBarSeparatorColor;

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
    [ICommand]
    async Task GoToListenNowPage() => await NavigationService.NavigateAsync(nameof(ListenPage));

    [ICommand]
    async Task GoToLibraryPage() => await NavigationService.NavigateAsync(nameof(LibraryPage));

    [ICommand]
    async Task GoToBrowsePage() => await NavigationService.NavigateAsync(nameof(BrowsePage));

    [ICommand]
    async Task GoToRadioPage() => await NavigationService.NavigateAsync(nameof(RadioPage));

    [ICommand]
    async Task GoToSearchPage() => await NavigationService.NavigateAsync(nameof(SearchPage));

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
}
