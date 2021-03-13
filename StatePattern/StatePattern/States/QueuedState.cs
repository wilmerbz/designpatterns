using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.Context;

namespace StatePattern.States
{
    public class QueuedState : MessageState
    {
        public override string Name => "QUEUED";
        public QueuedState(Message context) : base(context)
        {
        }

        public override void ACKSentToSender()
        {
            Console.WriteLine("[X] Queued Message Already Acknowledged.");
        }

        public override void MessageFailed()
        {
            Console.WriteLine("[X] Message has not been sent yet. Cannot be Failed.");
        }

        public override void MessageSent()
        {
            Console.WriteLine("> Queued Message Sent!");
            Context.State = Context.InProgressState;

        }

        public override void ReceiverACKReceived()
        {
            Console.WriteLine("[X] Message has not been sent yet. Cannot be acknowledged.");
        }
    }
}
