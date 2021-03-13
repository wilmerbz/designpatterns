using AbstractFactory.IngredientFactory;
using AbstractFactory.Ingredients.Cheese;
using AbstractFactory.Ingredients.Clams;
using AbstractFactory.Ingredients.Dough;
using AbstractFactory.Ingredients.Pepperoni;
using AbstractFactory.Ingredients.Sauce;
using AbstractFactory.Ingredients.Veggies;
using System;
using System.Text;

namespace AbstractFactory.Catalog
{
    /// <summary>
    /// Product - Abstract class with helpful implementation that can be overridden by the concrete products.
    /// </summary>
    public abstract class Pizza
    {

        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Veggies[] Veggies { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }

        public Clams Clam { get; set; }

        //To make a pizza we need an Ingredient Factory, to provide the Ingredients.
        protected IPizzaIngredientFactory _ingredientFactory;

        public Pizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
            Veggies = new Veggies[0];
        }

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350°.");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting tye Pizza into diagonal slices.");

        }
        public virtual void Box()
        {
            Console.WriteLine("Put the pizza in official PizzaStore box.");
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {Name}.");
            stringBuilder.AppendLine($"Dough: {Dough}");
            stringBuilder.AppendLine($"Sauce: {Sauce}");
            stringBuilder.AppendLine($"Cheese: {Cheese}");
            stringBuilder.AppendLine($"Veggies:");
            foreach (Veggies veggie in Veggies)
            {
                stringBuilder.AppendLine($"- {veggie}");
            }
            stringBuilder.AppendLine($"Pepperoni: {Pepperoni}");
            stringBuilder.AppendLine($"Clams: {Clam}");

            return stringBuilder.ToString();
        }
    }
}
