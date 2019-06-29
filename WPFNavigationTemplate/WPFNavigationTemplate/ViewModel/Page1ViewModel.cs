using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNavigationTemplate.ViewModel
{
    public class Page1ViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public Page1ViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
