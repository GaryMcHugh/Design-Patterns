using System;

namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Builder
            PizzaBuilder builder;

            //Director
            var pizzeria = new Pizzeria();

            // Construct and display pizzas

            builder = new PepperoniPizzaBuilder();
            pizzeria.Construct(builder);
            builder.Pizza.Summarise();

            builder = new HawaiianPizzaBuilder();
            pizzeria.Construct(builder);
            builder.Pizza.Summarise();

            builder = new MargheritaPizzaBuilder();
            pizzeria.Construct(builder);
            builder.Pizza.Summarise();

            Console.ReadLine();
        }
    }
}
