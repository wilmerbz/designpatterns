using StatePattern.Context;
using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var message = new Message(2);

            message.ACKSentToSender();
            message.MessageSent();
            message.MessageFailed();

            message.MessageSent();
            message.MessageFailed();

            message.MessageSent();
            message.MessageFailed();

            message.ReceiverACKReceived();

            Console.ReadKey();
        }
    }
}
