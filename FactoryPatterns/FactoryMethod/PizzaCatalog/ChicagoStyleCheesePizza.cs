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
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza() : base()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("* Cutting the pizza into squeare slices.");
        }
    }
}
