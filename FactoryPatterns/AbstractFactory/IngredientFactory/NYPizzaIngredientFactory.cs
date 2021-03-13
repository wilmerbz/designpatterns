using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Dough;
using AbstractFactory.Ingredients.Cheese;
using AbstractFactory.Ingredients.Clams;
using AbstractFactory.Ingredients.Pepperoni;
using AbstractFactory.Ingredients.Sauce;
using AbstractFactory.Ingredients.Veggies;

namespace AbstractFactory.IngredientFactory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public string Name => "New York Ingredient Factory";

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Veggies[] CreateVeggies()
        {
            var veggies = new Veggies[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }

        public Pepperoni CreatePepperoni()
        {
            return new Slicedpepperoni();
        }

        public Clams CreateClam()
        {
            return new FreshClams();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
