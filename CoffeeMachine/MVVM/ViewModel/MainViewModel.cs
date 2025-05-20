using CoffeeMachine.Core;
using CoffeeMachine.MVVM.Model;
using CoffeeMachine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.MVVM.ViewModel
{
    public class MainViewModel : Core.ViewModel
    {
        private INavigationService _navigationService;
        private string _status;
        private Settings _settings;
        public INavigationService NavigationService
        {
            get => _navigationService;
            set
            {
                _navigationService = value;
                OnPropertyChanged(nameof(NavigationService));
            }
        }

        public string Status
        {
            get => _status;
            set
            {
                _status = "Status: " + value;
            }
        }

        public Settings Settings
        {
            get => _settings;
            set
            {
                _settings = value;
                OnPropertyChanged(nameof(Settings));
            }
        }


        public RelayCommand NavigateToHomeCommand { get; set; }
        public RelayCommand NavigateToSettingsCommand { get; set; }

        public MainViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            NavigateToHomeCommand = new RelayCommand(o => { NavigationService.NavigateTo<HomeViewModel>(this);}, o => true);
            NavigateToSettingsCommand = new RelayCommand(o => { NavigationService.NavigateTo<SettingsViewModel>(this); }, o => true);
            Status = "Ready";
            Settings = new Settings();
        }
    }
}

