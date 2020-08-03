using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IMessage
    {
        /// <summary>
        /// Implementer in Bridge pattern
        /// </summary>
        /// <param name="to"></param>
        /// <param name="message"></param>
        void SendMessage(string to, string message);
    }
}
