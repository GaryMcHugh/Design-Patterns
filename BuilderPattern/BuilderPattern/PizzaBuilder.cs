using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class PizzaBuilder
    {
        //abstract interface for creating pizza's
        protected Pizza pizza;
        
        public Pizza Pizza
        {
            get { return pizza; }
        }

        public abstract void buildDough();
        public abstract void buildCrustType();
        public abstract void buildSauce();
        public abstract void buildToppings();
    }
}
