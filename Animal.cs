using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Animal
    {
        public string? Name { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public string? Sound { get; set; }
        public Flys? FlyType { get; set; }
    }
}
