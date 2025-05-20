using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CoffeeMachine.MVVM.Model
{
    public class Theme
    {
        public string ThemeName { get; set; } = string.Empty;
        public SolidColorBrush? BackgroundColor { get; set; }
        public SolidColorBrush? FontColor { get; set; }

        public Theme(string themeName, SolidColorBrush? backgroundColor, SolidColorBrush? fontColor)
        {
            ThemeName = themeName;
            BackgroundColor = backgroundColor;
            FontColor = fontColor;
        }
    }
}
