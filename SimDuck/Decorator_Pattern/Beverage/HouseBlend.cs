using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Decorator_Pattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "하우스 블렌드 커피";
        }
        public override double cost()
        {
            return .89;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
