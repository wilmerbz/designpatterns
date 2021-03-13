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
    public class NYStyleVeggiePizza : NYStyleCheesePizza
    {
        public NYStyleVeggiePizza() : base()
        {
            Name = "NY Style Sauce and Cheese Veggie Pizza";

            Toppings.Add("Tomato");
            Toppings.Add("Lettuce");
        }

    }
}
