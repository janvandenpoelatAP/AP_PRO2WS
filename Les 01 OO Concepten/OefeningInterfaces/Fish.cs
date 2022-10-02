using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace OefeningInterfaces
{
    public class Fish : Animal, IAmAWaterAnimal
    {
        public void Swim()
        {
            Console.WriteLine("De vis zwemt");
        }
    }
}
