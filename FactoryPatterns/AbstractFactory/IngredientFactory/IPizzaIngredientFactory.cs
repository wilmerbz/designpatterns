using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Cheese;
using AbstractFactory.Ingredients.Clams;
using AbstractFactory.Ingredients.Dough;
using AbstractFactory.Ingredients.Pepperoni;
using AbstractFactory.Ingredients.Sauce;
using AbstractFactory.Ingredients.Veggies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.IngredientFactory
{
    public interface IPizzaIngredientFactory
    {

        string Name { get; }

        Dough CreateDough();

        Sauce CreateSauce();

        Cheese CreateCheese();

        Veggies[] CreateVeggies();

        Pepperoni CreatePepperoni();

        Clams CreateClam();
    }
}
