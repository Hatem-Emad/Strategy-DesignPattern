using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Cat : Animal
    {
        public void Scratch() { Console.WriteLine("Cats make scratches"); }

        public Cat()
        {
            Sound = "Meow";
            FlyType = new CantFly();
        }
    }
}
