using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.PizzaCatalog;

namespace FactoryMethod.Stores
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            throw new NotImplementedException();
        }
    }
}
