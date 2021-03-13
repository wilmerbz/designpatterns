using System;
using System.Collections.Generic;
using System.Text;
using MediatorPattern.Mediator;

namespace MediatorPattern.Colleagues
{
    public class ConcreteColleague : IColleague
    {

        public string Name { get; set; }

        private IMediator Mediator { get; set; }

        public ConcreteColleague(string name)
        {
            Name = name;
        }


        public void ReceiveMessage(string type, string content)
        {
            Console.WriteLine($"[{Name}] - Message received: {type} - {content}");
        }

        public void SetMediator(IMediator mediator)
        {
            Mediator = mediator;
        }

        public void SendMessage(string type, string content)
        {
            Mediator.SendMessage(this, type, content);
        }

    }
}
