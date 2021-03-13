using FactoryMethod.PizzaCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Stores
{

    /// <summary>
    /// The PizzaStore is the abstract creator. Defines the FactoryMethor.
    /// </summary>
    public abstract class PizzaStore
    {

        public Pizza OrderPizza(string type)
        {

            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        //The Factory method is now abstract in Pizza Store.
        protected abstract Pizza CreatePizza(string type);
    }
}
