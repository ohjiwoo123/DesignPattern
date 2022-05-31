using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Factory_Pattern
{
    public class Program
    {
        public static void Main(String[] args)
        {
            SimplePizzaFactory simplePizzaFactory = new SimplePizzaFactory();
            PizzaStore pizzastore = new PizzaStore(simplePizzaFactory);
            pizzastore.OrderPizza("cheese");

        }
    }
}
