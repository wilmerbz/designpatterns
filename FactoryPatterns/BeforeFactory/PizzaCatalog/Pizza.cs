using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeFactory.PizzaCatalog
{
    public abstract class Pizza
    {


        public Pizza()
        {
        }


        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();

    }
}
