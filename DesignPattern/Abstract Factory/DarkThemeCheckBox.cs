using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Abstract_Factory
{
    public class DarkThemeCheckBox : ICheckBox
    {
        public string CreateCheckBox()
        {
            return "Dark Theme Check Box Create";
        }
    }
}
