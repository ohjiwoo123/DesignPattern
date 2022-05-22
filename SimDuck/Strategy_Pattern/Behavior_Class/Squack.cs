using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public class Squack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("고무오리가 내는 소리 삑삑~!!");
        }
    }
}
