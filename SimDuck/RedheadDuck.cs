using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public class RedheadDuck : Duck, QuackBehavior, FlyBehavior
    {
        public RedheadDuck()
        {

        }
        public override void display()
        {
            Console.WriteLine("저는 붉은머리 오리 입니다.");
        }
        public void fly()
        {
            Console.WriteLine("붉은머리 오리 훨훨");

        }

        public void quack()
        {
            Console.WriteLine("붉은머리 오리 꽥꽥");
        }
    }
}
