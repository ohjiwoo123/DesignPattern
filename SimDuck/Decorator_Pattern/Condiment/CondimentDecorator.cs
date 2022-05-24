using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Decorator_Pattern.Condiment
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override double cost();


        public abstract override string getDescription();
    }
}
