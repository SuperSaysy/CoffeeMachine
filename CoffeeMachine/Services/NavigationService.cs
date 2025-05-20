using CoffeeMachine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Services
{
    public class NavigationService : ObservableObject, INavigationService
    {
        private readonly Func<Type, ViewModel> _viewModelFactory;
        private ISubViewModel _currentView;

        public ISubViewModel CurrentView
        {
            get => _currentView;
            private set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public NavigationService(Func<Type, ViewModel> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        public void NavigateTo<TViewmodel>(ViewModel mainViewModel) where TViewmodel : ViewModel
        {
            ViewModel viewModel = _viewModelFactory.Invoke(typeof(TViewmodel));
            CurrentView = (ISubViewModel)viewModel;
            CurrentView.UpdateMainViewModel(mainViewModel);
           
        }

       
    }
}
