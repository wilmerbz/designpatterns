using SimpleFactory.PizzaCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Factory
{
    public class SimplePizzaFactory
    {


        public Pizza CreatePizza(string type)
        {
            Pizza pizza;

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                default:
                    Console.WriteLine("Invalid pizza type!");
                    return null;
            }


            return pizza;
        }


    }
}
