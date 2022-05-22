using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public class DecoyDuck : Duck
    { 
        public DecoyDuck()
        {

        }
        public override void display()
        {
            Console.WriteLine("저는 가짜 오리 입니다.");
        }
    }
}
