using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.ViewModels
{
    public partial class ListenPageViewModel : BaseViewModel
    {
        #region Members

                private readonly INavBarService androidNavBarService;

        #endregion

        #region Constructor
                public ListenPageViewModel(INavBarService androidNavBarService, INavigationService navigationService):base(navigationService)
                {
                    this.androidNavBarService = androidNavBarService;
                }
        #endregion

        #region Methods
                public async Task Initialize()
                {
                    PageStatusColor = Color.FromHex("#1c1c1e");
                    PageBavBarSeparatorColor = Color.FromHex("#1c1c1e");
        #if ANDROID
                    androidNavBarService.SetStatusBarColor(PageStatusColor);
                    androidNavBarService.SetNavSeparationColor(PageBavBarSeparatorColor);
        #endif
                }
        #endregion
    }
}
