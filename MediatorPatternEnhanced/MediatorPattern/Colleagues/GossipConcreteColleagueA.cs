using System;
using System.Collections.Generic;
using System.Text;
using MediatorPattern.Mediator;

namespace MediatorPattern.Colleagues
{
    public class GossipConcreteColleagueA : IColleague
    {

        public string Name { get; set; }

        private IMediator Mediator { get; set; }

        public GossipConcreteColleagueA(string name)
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

        public void DoSomething()
        {
            Console.WriteLine($"---------------------------------------------------------");
            Console.WriteLine($"I am {Name}, and I need to notify something to my colleagues:");
            Console.WriteLine("Message Type:");
            var messagType = Console.ReadLine();
            Console.WriteLine("Message Content:");
            var content = Console.ReadLine();

            Console.WriteLine($"[{Name}] - Sending message: {messagType} - {content} -->>");
            Console.WriteLine();

            Mediator.SendMessage(this, messagType, content);
        }

    }
}
