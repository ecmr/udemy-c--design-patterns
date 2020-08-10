using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interator
{
    public interface IIterator
    {
        User Fist { get; }
        User Next { get; }
        User Current { get; }
        bool IsDone { get; }
    }
}
