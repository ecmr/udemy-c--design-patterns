﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ComputerBase: Computer
    {
        public override string GetOptionCode() { return ""; }
        public override decimal GetPrice() { return 499.0M; }
    }
}
