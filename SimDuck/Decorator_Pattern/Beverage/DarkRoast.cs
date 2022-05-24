using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Decorator_Pattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "다크 로스트";
        }
        public override double cost()
        {
            return .99;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
