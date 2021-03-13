using BeforeFactory.PizzaCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeFactory
{
    public static class ExampleBeforeFactory
    {

        public static void RunClient()
        {
            var store = new PizzaStore();
            var pizza = store.OrderPizza("cheese");
            Console.WriteLine("------------------------------------------------");
            pizza = store.OrderPizza("pepperoni");
        }

    }
}
