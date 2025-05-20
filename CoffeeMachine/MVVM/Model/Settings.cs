using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CoffeeMachine.MVVM.Model
{
    public class Settings
    {
        private List<Theme> _themes;
        private Theme _activeTheme;
        private int _fontSize;

        public List<Theme> Themes { get => _themes; set => _themes = value; }
        public Theme ActiveTheme { get => _activeTheme; set => _activeTheme = value; }
        public int FontSize { get => _fontSize; set => _fontSize = value; }

        public Settings()
        {
            Themes = new List<Theme>();
            _activeTheme = new Theme("Darkmode",new SolidColorBrush(Colors.Black),new SolidColorBrush(Colors.White));
            FontSize = 12;
        }

    }
}
