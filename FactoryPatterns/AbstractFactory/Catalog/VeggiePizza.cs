using System;
using AbstractFactory.IngredientFactory;

namespace AbstractFactory.Catalog
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            Name = "Veggie Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing: {Name} - {_ingredientFactory}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Veggies = _ingredientFactory.CreateVeggies();
        }
    }
}
