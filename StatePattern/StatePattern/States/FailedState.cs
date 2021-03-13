using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.Context;

namespace StatePattern.States
{
    public class FailedState : MessageState
    {
        public override string Name => "FAILED";
        public FailedState(Message context) : base(context)
        {
        }


        public override void ACKSentToSender()
        {
            Console.WriteLine("[X] Failed Message Already Acknowledged.");
        }

        public override void MessageFailed()
        {
            Console.WriteLine("[X] Failed Message Already Failed.");
        }

        public override void MessageSent()
        {
            Console.WriteLine("[X] Failed Message Already Sent.");
        }

        public override void ReceiverACKReceived()
        {
            Console.WriteLine("[X] Failed Message cannot be Acknowledged by Receiver.");
        }

    }
}
