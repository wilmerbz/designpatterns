using StatePattern.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Context
{
    public class Message
    {


        public MessageState _state;
        public MessageState State
        {
            get { return _state; }
            set
            {
                Console.WriteLine($"* Changing Message State: {_state?.Name} -> {value?.Name} *");
                _state = value;
            }
        }
        public string MessageID { get; set; }
        public string Content { get; set; }
        public int Retries { get; set; }
        public int MaxRetries { get; set; }

        #region States

        public PendingState PendingState { get; private set; }
        public QueuedState QueuedState { get; private set; }
        public InProgressState InProgressState { get; private set; }
        public FailedState FailedState { get; private set; }
        public CompletedState CompletedState { get; private set; }
        #endregion


        public Message(int maxRetries)
        {
            PendingState = new PendingState(this);
            QueuedState = new QueuedState(this);
            InProgressState = new InProgressState(this);
            FailedState = new FailedState(this);
            CompletedState = new CompletedState(this);

            State = PendingState;

            MaxRetries = maxRetries;
            Retries = -1;
        }


        public void ACKSentToSender()
        {
            State.ACKSentToSender();
        }

        public void MessageSent()
        {
            Retries++;
            State.MessageSent();
        }

        public void MessageFailed()
        {
            State.MessageFailed();
        }

        public void ReceiverACKReceived()
        {
            State.ReceiverACKReceived();
        }

    }
}
