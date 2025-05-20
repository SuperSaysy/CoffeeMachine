using CoffeeMachine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Services
{
    public interface INavigationService
    {
        ISubViewModel CurrentView { get; }
        void NavigateTo<T>(ViewModel mainViewModel) where T : ViewModel;

    }
}
