using CoffeeMachine.Core;
using CoffeeMachine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeMachine.MVVM.ViewModel
{
    public class HomeViewModel : Core.ViewModel, ISubViewModel
    {
        public Core.ViewModel MainViewModel
        {
            get => MainViewModel;
            private set
            {
                MainViewModel = value;
            }
        }

        public void UpdateMainViewModel(Core.ViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }
    }
}
