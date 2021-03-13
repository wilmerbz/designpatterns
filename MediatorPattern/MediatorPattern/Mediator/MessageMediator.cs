using System;
using System.Collections.Generic;
using System.Text;
using MediatorPattern.Colleagues;

namespace MediatorPattern.Mediator
{
    public class MessageMediator : IMediator
    {
        private HashSet<IColleague> Colleagues { get; set; }

        public MessageMediator()
        {
            Colleagues = new HashSet<IColleague>();
        }

        public void RegisterColleague(IColleague colleague)
        {
            if (Colleagues.Contains(colleague)) return;

            colleague.SetMediator(this);

            Colleagues.Add(colleague);
        }

        public void RemoveColleague(IColleague colleague)
        {
            if (!Colleagues.Contains(colleague)) return;

            Colleagues.Remove(colleague);
        }

        public void SendMessage(IColleague sender, string type, string content)
        {
            foreach (IColleague colleague in Colleagues)
            {
                if (colleague == sender) continue;

                colleague.ReceiveMessage(type, content);
            }
        }
    }
}
