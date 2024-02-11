using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adaptor
{
    public class Corn : ICream
    {
        public string GetIngredient()
        {
            return "Corn";
        }

        public int GetCost()
        {
            return 15;
        }
    }
}
