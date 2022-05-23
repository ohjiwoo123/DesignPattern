using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Decorator_Pattern.Condiment
{
    // Soy == 두유 
    public class SteamMilk : CondimentDecorator
    {
        Beverage beverage;

        public SteamMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", 스팀 밀크";
        }

        public double cost()
        {
            return .10 + beverage.cost();
        }
    }
}
