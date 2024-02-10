using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Abstract_Factory
{
    public class DarkThemeFactory : IThemeFactory
    {
        public IButton GetButton()
        {
            return new DarkThemeButton();
        }

        public ICheckBox GetCheckBox()
        {
            return new DarkThemeCheckBox();
        }
    }
}
