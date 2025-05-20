using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Core
{
    /// <summary>
    /// This interface is used for views inside a Window to get Access to the MainViewModel
    /// </summary>
    public interface ISubViewModel
    {
        ViewModel MainViewModel { get; }
        void UpdateMainViewModel(ViewModel mainViewModel);
    }
}
