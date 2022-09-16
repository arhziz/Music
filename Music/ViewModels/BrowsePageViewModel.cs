using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.ViewModels
{
    public partial class BrowsePageViewModel : Music.BaseLib.Base.BaseViewModel
    {
        #region Constructor
        public BrowsePageViewModel(INavigationService navigationService):base(navigationService)
        {

        }
        #endregion
    }
}
