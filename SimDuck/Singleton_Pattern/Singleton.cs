﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Singleton_Pattern
{
    public class Singleton
    {
        private static Singleton uniqueInstance;
        private Singleton() { }

        public static Singleton getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
    }
}
