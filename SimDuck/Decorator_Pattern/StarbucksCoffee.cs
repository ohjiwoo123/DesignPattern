using SimDuck.Decorator_Pattern.Condiment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Decorator_Pattern
{
    public class StarbucksCoffee
    {
        // 핵심 포인트
        // Beverage 라는 추상클래스의 서브클래스를 만드는 것이 행동을 상속 받기 위한 것이 아니고,
        // 올바른 형식을 맞추기 위함이다. 행동은 기본구성요소와 다른 데코레이터 등을 인스턴스 변수에
        // 저장하는 식으로 연결 된다. => 인스턴스 변수로 다른 객체를 저장하는 방식
        // 그렇기에 음료와 첨가물을 다양하게 섞어도 유연성을 잃지 않는다. 
        // 상속을 활용했다면, 컴파일시 정적으로 결정되어 슈퍼 클래스에서 받은 것 오버라이드 한 것만
        // 사용 가능하지만, 구성을 활용하면 실행중에 데코레이터를 마음대로 조합해서 사용 가능하다.

        public static void Main(String[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());
            Beverage beverage2 = new DarkRoast();
            Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());
            Beverage beverage3 = new HouseBlend();
            Console.WriteLine(beverage3.getDescription() + " $" + beverage3.cost());
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.getDescription() + " $" + beverage3.cost());
        }
    }
}
