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
        public void UpdateMainViewModel(Core.ViewModel mainViewModel)
        {
            MainViewModel = mainViewModel as MainViewModel;
        }
    }
}
