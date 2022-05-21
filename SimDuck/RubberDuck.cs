using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public class RubberDuck : Duck, QuackBehavior, FlyBehavior
    {
        public RubberDuck()
        {

        }
        public override void display()
        {
            Console.WriteLine("저는 고무 오리 입니다.");
        }
        public void fly()
        {
            Console.WriteLine("고무 오리는 못 날아요~");

        }

        public void quack()
        {
            Console.WriteLine("고무 오리 꽥꽥");
        }
    }
}
