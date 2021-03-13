using SimpleFactory.Factory;
using SimpleFactory.PizzaCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{

    /// <summary>
    /// Client class
    /// </summary>
    public class PizzaStore
    {
        private SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        public Pizza OrderPizza(string type)
        {

            var pizza = _factory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        //public static Pizza OrderPizza(string type)
        //{
        //    Pizza pizza ;

        //  - - - - - - THIS IS WHAT VARIES.

        //Move to an object that is going to worry only about  

        //switch (type)
        //{
        //    case "cheese":
        //        pizza = new CheesePizza();
        //        break;
        //    case "pepperoni":
        //        pizza = new PepperoniPizza();
        //        break;
        //    // Note: This code is not close for modification.
        //    // If the pizza offering changes, we have to modify this code.
        //    default:
        //        Console.WriteLine("Invalid pizza type!");
        //        return null;
        //}
        //  - - - - - - - - - - - - - - - - - -

        // THIS IS WHAT WE EXPECT TO STAY THE SAME.

        //Move to the Client that receices the factory

        //pizza.Prepare();
        //pizza.Bake();
        //pizza.Cut();
        //pizza.Box();

        //return pizza;

        //}



    }
}
