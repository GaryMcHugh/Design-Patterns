using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class MargheritaPizzaBuilder : PizzaBuilder
    {
        public MargheritaPizzaBuilder()
        {
            pizza = new Pizza("MargheritaPizza");
        }

        public override void buildDough()
        {
            pizza["dough"] = "White Dough";
        }

        public override void buildCrustType()
        {
            pizza["crust"] = "Plain Crust";
        }

        public override void buildSauce()
        {
            pizza["sauce"] = "Tomato";
        }
        public override void buildToppings()
        {
            pizza["toppings"] = "Cheese";
        }
    }
}
