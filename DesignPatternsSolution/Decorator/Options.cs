using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Memory8Options : ComputerDecorator
    {
        public Memory8Options(Computer computer): base(computer)
        {
            OptionCode = "8RAM";
            Price = 70.0M;
        }
    }

    class Memory16Options : ComputerDecorator
    {
        public Memory16Options(Computer computer) : base(computer)
        {
            OptionCode = "16RAM";
            Price = 150.0M;
        }
    }

    class SSD128Options : ComputerDecorator
    {
        public SSD128Options(Computer computer) : base(computer)
        {
            OptionCode = "128SSD";
            Price = 74.0M;
        }
    }

    class SSD256Options : ComputerDecorator
    {
        public SSD256Options(Computer computer) : base(computer)
        {
            OptionCode = "256SSD";
            Price = 150.0M;
        }
    }
    class SSD512Options : ComputerDecorator
    {
        public SSD512Options(Computer computer) : base(computer)
        {
            OptionCode = "512SSD";
            Price = 300.0M;
        }
    }
}
