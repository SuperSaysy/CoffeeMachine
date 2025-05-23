using CoffeeMachine.Core;
using CoffeeMachine.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.MVVM.ViewModel
{
    public class SettingsViewModel : Core.ViewModel, ISubViewModel
    {
        private MainViewModel _mainViewModel;
        public MainViewModel MainViewModel
        {
            get => _mainViewModel;
            private set 
            {
                _mainViewModel = value;
                OnPropertyChanged(nameof(MainViewModel));
            }
        }

        public RelayCommand FontDownCommand { get; set; }
        public RelayCommand FontUpCommand { get; set; }

        public void UpdateMainViewModel(Core.ViewModel mainViewModel)
        {
            MainViewModel = mainViewModel as MainViewModel;
            FontDownCommand = new RelayCommand(o => { FontDown(); } , o => { return (MainViewModel.Settings.FontSize <= 2) ? false : true; });
            FontUpCommand = new RelayCommand(o => { FontUp(); }, o => { return (MainViewModel.Settings.FontSize >= 20) ? false : true; });
        }

        private void FontUp()
        {
            MainViewModel.Settings.FontUp();
            MainViewModel.Settings = MainViewModel.Settings;
        }

        public void FontDown()
        {
            MainViewModel.Settings.FontDown();
            MainViewModel.Settings = MainViewModel.Settings;
        }


    }
}
