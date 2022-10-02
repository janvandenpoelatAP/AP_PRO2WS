﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace OefeningInterfaces
{
    public class Dog : Animal, IMakeSound
    {
        public void MakeSound()
        {
            Console.WriteLine($"Waf waf, ik ben {Age} jaar");
        }
    }
}
