using AbstractFactory.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public static class ExampleAbstractFactory
    {
        public static void RunClient()
        {
            PrintSeparator();
            //Create Store (That provides the Factory Method)
            Console.WriteLine("NY Style:");
            PrintSeparator();

            var nyStore = new NYPizzaStore();
            var nyCheesePizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Result: {nyCheesePizza}");

            PrintSeparator();
            var nyVeggiePizza = nyStore.OrderPizza("veggie");
            Console.WriteLine($"Result: {nyVeggiePizza}");

            PrintSeparator();
            var nyClamPizza = nyStore.OrderPizza("clams");
            Console.WriteLine($"Result: {nyClamPizza}");

            PrintSeparator();
            Console.WriteLine("Chicago Style:");

            PrintSeparator();

            var chicagoStore = new ChicagoPizzaStore();
            var chicagoCheesePizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Result: {chicagoCheesePizza}");
            PrintSeparator();
            var chicagoVeggiePizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine($"Result: {chicagoVeggiePizza}");

            PrintSeparator();
            var chicagoClamPizza = chicagoStore.OrderPizza("clams");
            Console.WriteLine($"Result: {chicagoClamPizza}");


        }

        private static void PrintSeparator()
        {
            Console.WriteLine("------------------------------------------------");
        }
    }
}
