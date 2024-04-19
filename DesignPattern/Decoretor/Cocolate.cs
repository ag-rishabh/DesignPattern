using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adaptor
{
    public class Cocolate : ICream
    {
        private readonly ICream _cream;

        public Cocolate(ICream cream)
        {
            _cream = cream;
        }

        public string GetIngredient()
        {
            return _cream.GetIngredient() + " Cocolate";
        }

        public int GetCost()
        {
            return _cream.GetCost() + 60;
        }
    }
}
