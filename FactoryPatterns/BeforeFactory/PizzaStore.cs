using BeforeFactory.PizzaCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeFactory
{
    public class PizzaStore
    {

        public PizzaStore()
        {

        }

        public Pizza OrderPizza(string type)
        {

            Pizza pizza;

            //  - - - - - - THIS IS WHAT VARIES.
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                // Note: This code is not close for modification.
                // If the pizza offering changes, we have to modify this code.
                default:
                    Console.WriteLine("Invalid pizza type!");
                    return null;
            }
            //  - - - - - - - - - - - - - - - - - -

            // THIS IS WHAT WE EXPECT TO STAY THE SAME.
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

    }
}
