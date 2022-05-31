using SimDuck.Command_Pattern.Appliances;
using SimDuck.Command_Pattern.CommandClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Command_Pattern
{
    public class RemoteControlTest
    {
        public static void Main(String[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);

            remote.setCommand(lightOn);
            remote.buttonWasPressed();
        }
    }
}
