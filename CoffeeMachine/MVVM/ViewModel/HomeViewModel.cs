using CoffeeMachine.Core;
using CoffeeMachine.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeMachine.MVVM.ViewModel
{
    public class HomeViewModel : Core.ViewModel, ISubViewModel
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
