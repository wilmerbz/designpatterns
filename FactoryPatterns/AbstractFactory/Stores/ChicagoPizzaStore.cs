using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Catalog;
using AbstractFactory.IngredientFactory;

namespace AbstractFactory.Stores
{
    /// <summary>
    /// Concrete creator. Implements the FactoryMethod, defined by the abstract class PizzaStore.
    /// </summary>
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            type = type.ToLower();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "Chicago Style Cheese Pizza";
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.Name = "Chicago Style Veggie Pizza";
                    break;
                case "clams":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "Chicago Style Clams Pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "Chicago Style Pepperoni Pizza";
                    break;
                default:
                    Console.WriteLine("Invalid Chicago style pizza type!");
                    return null;
            }

            return pizza;
        }
    }
}
