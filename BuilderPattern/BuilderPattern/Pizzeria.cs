using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Pizzeria
    {
        //constructs an object using the builder interface
        public void Construct(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.buildDough();
            pizzaBuilder.buildCrustType();
            pizzaBuilder.buildSauce();
            pizzaBuilder.buildToppings();
        }
    }
}
