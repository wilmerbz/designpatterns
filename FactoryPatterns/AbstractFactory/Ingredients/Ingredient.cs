using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients
{
    public abstract class Ingredient
    {

        public abstract string Name { get; }

        public Ingredient()
        {

        }

        public override string ToString()
        {
            return Name;
        }

    }
}
