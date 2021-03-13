using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.Context;

namespace StatePattern.States
{
    public class InProgressState : MessageState
    {

        public override string Name => "IN PROGRESS";
        public InProgressState(Message context) : base(context)
        {
        }

        public override void ACKSentToSender()
        {
            Console.WriteLine("[X] In Progress Message Already Acknowledged.");
        }

        public override void MessageFailed()
        {
            if (Context.Retries >= Context.MaxRetries)
            {
                Console.WriteLine("> In Progress Message Failed with MaxRetries reached.!");
                Context.State = Context.FailedState;
            }
            else
            {
                Console.WriteLine("> In Progress Message Failed with Retries available!");
            }
        }

        public override void MessageSent()
        {
            Console.WriteLine("> Message Re-Sent!");
        }

        public override void ReceiverACKReceived()
        {
            Console.WriteLine("> In Progress Message Acknowledged by Receiver!");
            Context.State = Context.CompletedState;
        }
    }
}
