using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PizzaCatalog
{
    /// <summary>
    /// Product - Abstract class with helpful implementation that can be overridden by the concrete products.
    /// </summary>
    public abstract class Pizza
    {

        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; }


        public Pizza()
        {
            Toppings = new List<string>();
        }


        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name}.");
            Console.WriteLine($"Tossing dough: {Dough}...");
            Console.WriteLine($"Adding sauce: {Sauce}...");
            Console.WriteLine($"Adding toppings:");

            foreach (string topping in Toppings)
            {
                Console.WriteLine($"\t - {topping}");

            }
        }

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

    }
}
