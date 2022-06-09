using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Adapter_Pattern
{
    public class WildTurkey : Turkey
    {
        public void gobble()
        {
            Console.WriteLine("Gobble Gobble");
        }
        public void fly()
        {
            Console.WriteLine("I am flying Short Distance");
        }
    }
}
