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
            Theme new01 = new Theme("Cremy",new SolidColorBrush(Colors.AntiqueWhite),new SolidColorBrush(Colors.Black));
            Theme new02 = new Theme("Bright",new SolidColorBrush(Colors.White),new SolidColorBrush(Colors.Black));
            Theme new03 = new Theme("Darkmode",new SolidColorBrush(Colors.Black),new SolidColorBrush(Colors.White));
            FontSize = 12;
            Themes.Add(new01);
            Themes.Add(new02);
            Themes.Add(new03);
            ActiveTheme = new01;
        }

    }
}
