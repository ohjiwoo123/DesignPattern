using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("나는 소리 낼 수 없는 오리에요!!");
        }
    }
}
