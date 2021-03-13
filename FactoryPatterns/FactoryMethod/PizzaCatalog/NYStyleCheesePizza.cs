using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PizzaCatalog
{
    /// <summary>
    /// Concrete product
    /// </summary>
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza() : base()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
        }

    }
}
