using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Abstract_Factory
{
    public class LightThemeCheckBox : ICheckBox
    {
        public string CreateCheckBox()
        {
            return "Light Theme Check Box Created";
        }
    }
}
