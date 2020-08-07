using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public abstract class Approver
    {
        protected Approver NextApprover;

        public void SetNextApprover(Approver netApprover)
        {
            this.NextApprover = netApprover;
        }

        public abstract bool ApproveMaterial(Material material, ref string reason);
    }
}
