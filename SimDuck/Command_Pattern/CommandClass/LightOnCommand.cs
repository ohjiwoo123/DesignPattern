using SimDuck.Command_Pattern.Appliances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Command_Pattern
{
    public class LightOnCommand : Command
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.on();
        }
    }
}
