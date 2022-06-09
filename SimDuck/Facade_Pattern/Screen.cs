﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Facade_Pattern
{
    public class Screen
    {
        string description;

        public Screen(string description)
        {
            this.description = description;
        }

        public void up()
        {
            Console.WriteLine(description + " going up");
        }

        public void down()
        {
            Console.WriteLine(description + " going down");
        }


        public string toString()
        {
            return description;
        }
    }
}
