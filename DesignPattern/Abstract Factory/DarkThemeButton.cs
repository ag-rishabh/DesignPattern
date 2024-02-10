using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Abstract_Factory
{
    public class DarkThemeButton : IButton
    {
        public string CreateButton()
        {
            return "Dark Theme Button";
        }
    }
}
