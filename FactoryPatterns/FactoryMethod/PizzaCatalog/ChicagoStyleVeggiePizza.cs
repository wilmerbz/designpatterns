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
    public class ChicagoStyleVeggiePizza : ChicagoStyleCheesePizza
    {
        public ChicagoStyleVeggiePizza() : base()
        {
            Name = "Chicago Style Deep Dish Veggie Pizza";

            Toppings.Add("Tomato");
            Toppings.Add("Lettuce");
        }
        
    }
}
