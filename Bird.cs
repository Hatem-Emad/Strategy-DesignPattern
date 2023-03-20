using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Bird : Animal
    {
        public Bird()
        {
            Sound = "sewsew";
            FlyType = new FlyHigh();
        }
    }
}
