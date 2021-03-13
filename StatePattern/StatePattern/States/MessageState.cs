using StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.States
{
    public abstract class MessageState
    {
        public abstract string Name { get; }
        protected Message Context { get; set; }

        public MessageState(Message context)
        {

            Context = context;

        }


        public abstract void ACKSentToSender();
        public abstract void MessageSent();
        public abstract void MessageFailed();
        public abstract void ReceiverACKReceived();


    }
}
