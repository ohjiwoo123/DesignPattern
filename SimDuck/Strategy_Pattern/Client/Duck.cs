using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public abstract class Duck 
    {
        private FlyBehavior flyBehavior;
        private QuackBehavior quackBehavior;

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

        //static void Main(string[] args)
        //{
        //    Duck Mallard = new MallardDuck();
        //    Mallard.performFly();
        //    Mallard.performFly();
        //}
    }
}
