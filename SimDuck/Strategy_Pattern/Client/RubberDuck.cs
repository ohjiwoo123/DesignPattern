using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {

        }
        public override void display()
        {
            Console.WriteLine("저는 고무 오리 입니다.");
        }
    }
}
