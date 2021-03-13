using System;
using AbstractFactory.IngredientFactory;

namespace AbstractFactory.Catalog
{
    public class ClamPizza : Pizza
    {
        public ClamPizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            Name = "Clam Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing: {Name} - {_ingredientFactory}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Clam = _ingredientFactory.CreateClam();
        }
    }
}
