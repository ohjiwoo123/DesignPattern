using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Command_Pattern.Appliances
{
    public class Light
    {
        public void on()
        {
            Console.WriteLine("Light is On");
        }

        public void off()
        {
            Console.WriteLine("Light is Off");
        }
    }
}
