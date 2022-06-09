using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Facade_Pattern
{
    public class Tuner
    {
        Amplifier amp;
        string description;
        double frequency;
        public Tuner(string description, Amplifier amp)
        {
            this.description = description;
            this.amp = amp;
        }
        public void on()
        {
            Console.WriteLine(description + " on");
        }
        public void off()
        {
            Console.WriteLine(description + " off");
        }
        public void setAm()
        {
            Console.WriteLine(description + " setting AM mode");
        }
        public void setFm()
        {
            Console.WriteLine(description + " setting FM mode");
        }
        public void setFrequency(double frequency)
        {
            Console.WriteLine(description + " setting frequency to " + frequency);
            this.frequency = frequency;
        }
    }
}
