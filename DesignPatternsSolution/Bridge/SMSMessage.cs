﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SMSMessage: IMessage
    {
        public void SendMessage(string to, string message)
        {
            // maybe use Twilio?
        }
    }
}
