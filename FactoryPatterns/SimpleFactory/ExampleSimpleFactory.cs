using SimpleFactory.Factory;
using SimpleFactory.PizzaCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public static class ExampleSimpleFactory
    {
        public static void RunClient()
        {
            // Create a new instance of the Factory.
            var factory = new SimplePizzaFactory();
            // Create a new instance of the Client, passing the Factory.
            var pizzaStore = new PizzaStore(factory);
            var pizza = pizzaStore.OrderPizza("cheese");
            Console.WriteLine("------------------------------------------------");
            pizza = pizzaStore.OrderPizza("pepperoni");
            
        }

    }
}
