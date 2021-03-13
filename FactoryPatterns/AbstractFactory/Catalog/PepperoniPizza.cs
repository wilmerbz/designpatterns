using System;
using AbstractFactory.IngredientFactory;

namespace AbstractFactory.Catalog
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            Name = "Veggie Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing: {Name} - {_ingredientFactory}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Pepperoni = _ingredientFactory.CreatePepperoni();
        }
    }
}
