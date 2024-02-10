using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Abstract_Factory
{
    public class LightThemeButton : IButton
    {
        public string CreateButton()
        {
            return "Light Theme Button Created";
        }
    }
}
