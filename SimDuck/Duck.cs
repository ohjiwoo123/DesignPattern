using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public interface FlyBehavior
    {
        public void fly();
    }
    public interface QuackBehavior
    {
        public void quack();
    }
    public abstract class Duck
    {

        public class FlyWithWings : FlyBehavior
        {
            public void fly()
            {
                Console.WriteLine("날고 있어요!!");
            }
        }

        public class FlyNoWay : FlyBehavior
        {
            public void fly()
            {
                Console.WriteLine("저는 못 날아요!!");
            }
        }

       
        public class Quack : QuackBehavior
        {
            public void quack()
            {
                Console.WriteLine("꽥!");
            }
        }
        public class MuteQuack : QuackBehavior
        {
            public void quack()
            {
                Console.WriteLine("<<~조용~>>");
            }
        }

        public class Squeak : QuackBehavior
        {
            public void quack()
            {
                Console.WriteLine("삑");
            }
        }

        FlyBehavior flyBehavior;
        QuackBehavior quackBehavior;

        public Duck()
        {

        }


        public abstract void display();


        public void swim()
        {
            Console.WriteLine("모든 오리는 헤엄을 할 수 있습니다 : 첨벙첨벙~");
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }
        public void performFly()
        {
            flyBehavior.fly();
        }
        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
