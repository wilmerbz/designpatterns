using FactoryMethod.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public static class ExampleFactoryMethod
    {
        public static void RunClient()
        {
            PrintSeparator();
            //Create Store (That provides the Factory Method)
            Console.WriteLine("NY Style:");
            PrintSeparator();

            var nyStore = new NYPizzaStore();
            var nyCheesePizza = nyStore.OrderPizza("cheese");
            PrintSeparator();
            var nyVeggiePizza = nyStore.OrderPizza("veggie");

            PrintSeparator();
            Console.WriteLine("Chicago Style:");
            PrintSeparator();

            var chicagoStore = new ChicagoPizzaStore();
            var chicagoCheesePizza = chicagoStore.OrderPizza("cheese");
            PrintSeparator();
            var chicagoVeggiePizza = chicagoStore.OrderPizza("veggie");

        }

        private static void PrintSeparator()
        {
            Console.WriteLine("------------------------------------------------");
        }
    }
}
