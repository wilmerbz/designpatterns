using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.Context;

namespace StatePattern.States
{
    public class PendingState : MessageState
    {
        public override string Name => "PENDING";

        public PendingState(Message context) : base(context)
        {
        }

        public override void ACKSentToSender()
        {
            Console.WriteLine("> Message Reception Confirmed to Sender.");
            Context.State = Context.QueuedState;
        }

        public override void MessageFailed()
        {
            Console.WriteLine("[X] Message is still pending. Cannot be Failed.");
        }

        public override void MessageSent()
        {
            Console.WriteLine("[X] Message is still pending. Cannot be Sent.");
        }

        public override void ReceiverACKReceived()
        {
            Console.WriteLine("[X] Message is still pending. Cannot be Acknowledged.");

        }
    }
}
