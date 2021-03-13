using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.PizzaCatalog;

namespace FactoryMethod.Stores
{

    /// <summary>
    /// Concrete creator. Implements the FactoryMethod, defined by the abstract class PizzaStore.
    /// </summary>
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "cheese":
                    pizza = new NYStyleCheesePizza();
                    break;
                case "veggie":
                    pizza = new NYStyleVeggiePizza();
                    break;
                default:
                    Console.WriteLine("Invalid NY style pizza type!");
                    return null;
            }

            return pizza;
        }
    }
}
