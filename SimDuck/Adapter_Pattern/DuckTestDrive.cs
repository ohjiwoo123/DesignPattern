using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Adapter_Pattern
{
    public class DuckTestDrive
    {
        public static void Main(String[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");
            turkey.gobble();
            turkey.fly();

            Console.WriteLine("The Duck says...");
            testDuck(duck);

            Console.WriteLine("The TurkeyAdapter says...");
            testDuck(turkeyAdapter);
        
        }
        static void testDuck(Duck duck)
        {
            duck.quack();
            duck.fly();
        }
    }
}
