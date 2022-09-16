using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Library.ViewModels
{
    public class BaseViewModel : Music.BaseLib.Base.BaseViewModel
    {
        public BaseViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
