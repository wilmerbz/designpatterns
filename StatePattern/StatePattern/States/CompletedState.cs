using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.Context;

namespace StatePattern.States
{
    public class CompletedState : MessageState
    {
        public override string Name => "COMPLETED";
        public CompletedState(Message context) : base(context)
        {
        }


        public override void ACKSentToSender()
        {
            Console.WriteLine("[X] Completed Message Already Acknowledged.");
        }

        public override void MessageFailed()
        {
            Console.WriteLine("[X] Completed Message cannot be Failed.");
        }

        public override void MessageSent()
        {
            Console.WriteLine("[X] Completed Message Already Sent.");
        }

        public override void ReceiverACKReceived()
        {
            Console.WriteLine("[X] Completed Message already Acknowledged by Receiver.");
        }
    }
}
