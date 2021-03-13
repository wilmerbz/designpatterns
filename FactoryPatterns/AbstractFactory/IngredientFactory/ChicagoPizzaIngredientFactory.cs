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
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public string Name => "Chicago Ingredient Factory";

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Cheese CreateCheese()
        {
            return new Mozzarella();
        }

        public Veggies[] CreateVeggies()
        {
            var veggies = new Veggies[] { new Spinach(), new BlackOlives(), new EggPlant()};
            return veggies;
        }

        public Pepperoni CreatePepperoni()
        {
            return new Slicedpepperoni();
        }

        public Clams CreateClam()
        {
            return new FrozenClams();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
