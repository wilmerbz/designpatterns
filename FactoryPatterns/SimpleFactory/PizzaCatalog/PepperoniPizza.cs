using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.PizzaCatalog
{
    /// <summary>
    /// Concrete product
    /// </summary>
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza() : base()
        {
        }

        public override void Bake()
        {
            Console.WriteLine("Baking pepperoni pizza!");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing pepperoni pizza!");

        }

        public override void Cut()
        {
            Console.WriteLine("Cutting pepperoni pizza!");

        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing pepperoni pizza!");

        }
    }
}
