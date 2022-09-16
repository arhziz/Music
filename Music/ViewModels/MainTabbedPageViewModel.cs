namespace Music.ViewModels;

public class MainTabbedPageViewModel : Music.BaseLib.Base.BaseViewModel
{

	private readonly INavigationService navigationService;
	public MainTabbedPageViewModel(INavigationService navigationService) :base(navigationService)
	{
		this.navigationService = navigationService;

	}

    


}

