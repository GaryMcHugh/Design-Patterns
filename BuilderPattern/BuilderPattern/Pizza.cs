using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Pizza
    {
        //represents the complex object that is being created
        private string _pizzaType;
        private Dictionary<string, string> _components = new Dictionary<string, string>();

        public Pizza(string pizzaType)
        {
            this._pizzaType = pizzaType;
        }

        public string this[string key]
        {
            get { return _components[key]; }
            set { _components[key] = value; }
        }

        public void Summarise()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Pizza Type: {0}", _pizzaType);
            Console.WriteLine("Dough : {0}", _components["dough"]);
            Console.WriteLine("Crust : {0}", _components["crust"]);
            Console.WriteLine("Sauce : {0}", _components["sauce"]);
            Console.WriteLine("Toppings : {0}", _components["toppings"]);
        }
    }
}
