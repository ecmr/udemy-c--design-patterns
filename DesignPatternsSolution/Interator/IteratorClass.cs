using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interator
{
    public class IteratorClass: IIterator
    {
        IAggregate Aggregate = null;
        int Index = 0;

        public IteratorClass(Aggregate aggregate)
        {
            Aggregate = aggregate;
        }

        #region IIterator Members

        public User Fist
        {
            get
            {
                Index = 0;
                return Aggregate[Index];
            }
        }

        public User Next
        {
            get
            {
                Index += 1;
                if (IsDone == false)
                {
                    return Aggregate[Index];
                }
                else
                {
                    return null;
                }
            }
        }

        public User Current
        {
            get
            {
                return Aggregate[Index];
            }
        }

        public bool IsDone
        {
            get
            {
                return (Index >= Aggregate.Count);
            }
        }
        
        #endregion
    }
}
