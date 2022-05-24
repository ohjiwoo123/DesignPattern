using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Decorator_Pattern.Condiment
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", 모카";
        }

        public override double cost()
        {
            return .20 + beverage.cost();
        }
    }
}
