using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace WPFNavigationTemplate.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        private string _parameterText;

        public string ParameterText
        {
            get => _parameterText;
            set => Set(nameof(ParameterText), ref _parameterText, value);
        }

        public RelayCommand NavigateCommand { get; }
        public MainViewModel()
        {
            NavigateCommand = new RelayCommand(OnNavigateCommand, CanNavigateCommand);
        }

        private bool CanNavigateCommand()
        {
            return true;
        }

        private void OnNavigateCommand()
        {
            throw new NotImplementedException();
        }
    }
}
