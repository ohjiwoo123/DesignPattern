using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior flyBehavior;
            QuackBehavior quackBehavior;
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("저는 물오리 입니다.");
        }

        public void quack()
        {
            Console.WriteLine("물오리 꽥꽥");
        }

        public void fly()
        {
            Console.WriteLine("물오리 훨훨");
        }
    }
}
