using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Decorator_Pattern
{
    public abstract class Beverage
    {
        public string description = "제목 없음";
        public abstract string getDescription();
        public abstract double cost();
    }
}
