using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        public HawaiianPizzaBuilder()
        {
            pizza = new Pizza("HawaiianPizza");
        }

        public override void buildDough()
        {
            pizza["dough"] = "Brown Dough";
        }

        public override void buildCrustType()
        {
            pizza["crust"] = "Cheesy Crust";
        }

        public override void buildSauce()
        {
            pizza["sauce"] = "Tomato";
        }
        public override void buildToppings()
        {
            pizza["toppings"] = "Pineapple & Ham";
        }
    }
}
