using System;
using AbstractFactory.IngredientFactory;

namespace AbstractFactory.Catalog
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            Name = "Cheese Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing: {Name} - {_ingredientFactory}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
        }
    }
}
