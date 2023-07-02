using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.FactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza;
            if (type.Equals("Cheese"))
                pizza = new CheezePizza();
            else if (type.Equals("Clam"))
                pizza = new ClamPizza();
            else if (type.Equals("Pepperoni"))
                pizza = new PepperoniPizza();
            else
                pizza = new VeggiePizza();
            return pizza;
        }
    }
}
