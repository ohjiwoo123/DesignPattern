using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Decorator_Pattern
{
    public class Decaffeination : Beverage
    {
        public Decaffeination()
        {
            description = "디카페인";
        }
        public override double cost()
        {
            return 1.05;
        }
    }
}
