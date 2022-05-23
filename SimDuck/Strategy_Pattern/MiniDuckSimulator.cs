using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Strategy_Pattern
{
    // 조건 설명
    // 모든 오리는 헤엄을 칠 수 있다. swim()
    // 각각의 오리는 소리를 다르게 내며, 소리를 낼 수 없는 오리도 있다.
    // 각각의 오리는 날 수 있는 오리가 있고, 날 수 없는 오리도 있다.
    // 각각의 오리의 Fly와 Quack은 interface로 나누고, 각각의 행동은 인터페이스를 상속 받아서 클래스로 만듬
    // 각각의 오리의 행동은 set 함수로 위임하여 행동 세터 메소드로 처리한다. 
    // 각각의 오리를 표시하는 것은 override 처리 
    public class MiniDuckSimulator
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("=============Mallard_Duck 물오리==================");
            Duck mallard = new MallardDuck();
            mallard.setFlyBehavior(new FlyWithWings());
            mallard.setQuackBehavior(new Quack());
            mallard.performQuack();
            mallard.performFly();
            mallard.swim();
            mallard.display();
            Console.WriteLine("==================================================");

            Console.WriteLine("=============RedHead_Duck 빨간머리오리==================");
            Duck redhead = new RedheadDuck();
            redhead.setFlyBehavior(new FlyWithWings());
            redhead.setQuackBehavior(new Quack());
            redhead.performQuack();
            redhead.performFly();
            redhead.swim();
            redhead.display();
            Console.WriteLine("==================================================");

            Console.WriteLine("=============Rubber_Duck 고무오리==================");
            Duck rubber = new RubberDuck();
            rubber.setFlyBehavior(new FlyNoWay());
            rubber.setQuackBehavior(new Squack());
            rubber.performQuack();
            rubber.performFly();
            rubber.swim();
            rubber.display();
            Console.WriteLine("==================================================");

            Console.WriteLine("=============Decoy_Duck 가짜오리==================");
            Duck decoy = new DecoyDuck();
            decoy.setFlyBehavior(new FlyNoWay());
            decoy.setQuackBehavior(new MuteQuack());
            decoy.performQuack();
            decoy.performFly();
            decoy.swim();
            decoy.display();
            Console.WriteLine("==================================================");
        }
    }
}
