using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public class MallardDuck : Duck, QuackBehavior
    { 
        public MallardDuck()
        {
            QuackBehavior = new Quack();
        }
    }

    public interface FlyBehavior
    {
        public void fly();
    }

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

    public interface QuackBehavior
    {
        public void quack();
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
    public abstract class Duck
    {
        FlyBehavior flyBehavior;
        QuackBehavior quackBehavior;

        public Duck()
        {

        }

        public void quack()
        {
            Console.WriteLine("꽥꽥");
        }
        public void swim()
        {
            Console.WriteLine("첨벙첨벙");
        }
        public void display()
        {

        }

        public void fly()
        {

        }
    }

    public class MallardDuck : Duck
    {

    }

    public class RedheadDuck : Duck
    {

    }
}
