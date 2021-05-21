using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class PepperoniPizzaBuilder : PizzaBuilder
    {
        //constructs and assembles pizzas by implementing the builder interface
        public PepperoniPizzaBuilder()
        {
            pizza = new Pizza("PepperoniPizza");
        }

        public override void buildDough()
        {
            pizza["dough"] = "White Dough";
        }

        public override void buildCrustType()
        {
            pizza["crust"] = "Stuffed Crust";
        }

        public override void buildSauce()
        {
            pizza["sauce"] = "Spicy Tomato";
        }

        public override void buildToppings()
        {
            pizza["toppings"] = "Pepperoni";
        }
    }
}
