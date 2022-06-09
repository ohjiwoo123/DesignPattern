using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Adapter_Pattern
{
    public class MallardDuck : Duck
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
        public void fly()
        {
            Console.WriteLine("I am Flying");
        }
    }
}
