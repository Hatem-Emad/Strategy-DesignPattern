﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal interface IFlys
    {
        public string Fly { get; }
    }
    public class FlyHigh : IFlys
    {
        public string Fly => "I fly high";
        public override string ToString()
            => Fly;
        
    }
    public class CantFly : IFlys
    {
        public string Fly => "I can't fly";
        public override string ToString()
            => Fly;
        
    }
}
