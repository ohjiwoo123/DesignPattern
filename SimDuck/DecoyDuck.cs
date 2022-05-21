using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public class DecoyDuck : Duck, QuackBehavior, FlyBehavior
    {
        public DecoyDuck()
        {

        }
        public override void display()
        {
            Console.WriteLine("저는 가짜 오리 입니다.");
        }
        public void fly()
        {
            Console.WriteLine("가짜 오리는 못 날아요~");

        }

        public void quack()
        {
            Console.WriteLine("가짜 오리 꽥꽥");
        }
    }
}
