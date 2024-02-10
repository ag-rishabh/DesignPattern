using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Abstract_Factory
{
    public class AbstractThemeFactory
    {
        public static IThemeFactory GetThemeFactory(String themeName)
        {
            IThemeFactory factory = null;
            if (themeName == "LIGHT")
            {
                factory = new LightThemeFactory();
            }
            else if (themeName == "DARK")
            {
                factory = new DarkThemeFactory();
            }
            return factory;
        }
    }
}
