using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace SimDuck.Factory_Pattern
{
    public class Pizza
    {
        string name;
        string dough; 
        string sauce; 

        List<string> toppings = new List<string>(); 
        public void prepare() 
        { 
            Console.WriteLine("Preparing : " + name);
            Console.WriteLine("Tossing dough..."); 
            Console.WriteLine("Adding source");
            Console.WriteLine("Adding toppings");
            foreach(var topping in toppings) 
            {
                Console.WriteLine("\ttopping : " + topping);
            } 
        }
        public void bake() { Console.WriteLine("Bake for 25 minutes at 350"); }
        public void cut() { Console.WriteLine("Cutting the pizza into diagonal slices"); }
        public void box() { Console.WriteLine("Place pizza in official PizzaStore box"); }
        public string getname() { return this.name; }
    }
}
