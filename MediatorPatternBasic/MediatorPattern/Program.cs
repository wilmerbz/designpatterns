using MediatorPattern.Colleagues;
using MediatorPattern.Mediator;
using System;
using System.Collections.Generic;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IMediator mediator = new MessageMediator();
            int numberOfColleagues = 10;
            List<IColleague> colleagues = new List<IColleague>();
            for (int i = 0; i < numberOfColleagues; i++)
            {
                IColleague colleague = new ConcreteColleague($"Colleague-{i + 1}");
                mediator.RegisterColleague(colleague);

                colleagues.Add(colleague);
            }

            var random = new Random();
            var senderIndex = random.Next(0, colleagues.Count);

            var sender = colleagues[senderIndex] as ConcreteColleague;

            sender.SendMessage("Test", Guid.NewGuid().ToString());

            Console.ReadKey();
        }
    }
}
