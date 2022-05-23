using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Decorator_Pattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "에스프레소";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
