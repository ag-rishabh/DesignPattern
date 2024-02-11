using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adaptor
{
    public class Vanilla : ICream
    {
        private readonly ICream _cream;
        
        public Vanilla(ICream cream) 
        {
            _cream = cream;
        }

        public string GetIngredient()
        {
            return _cream.GetIngredient() + " Vanilla";
        }

        public int GetCost()
        {
            return _cream.GetCost() + 50;
        }
    }
}
