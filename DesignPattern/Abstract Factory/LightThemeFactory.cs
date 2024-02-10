using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Abstract_Factory
{
    public class LightThemeFactory : IThemeFactory
    {
        public IButton GetButton()
        {
            return new LightThemeButton();
        }

        public ICheckBox GetCheckBox()
        {
            return new LightThemeCheckBox();
        }
    }
}
