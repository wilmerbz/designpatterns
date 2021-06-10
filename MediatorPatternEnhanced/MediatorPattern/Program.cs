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
            //IMediator mediator2 = new MessageMediator();

            List<IColleague> colleagues = new List<IColleague>();

            int numberOfColleagues = 3;
            List<IColleague> concreteColleaguesGossip = CreateGossipConcreteColleaguesA(mediator, numberOfColleagues);
            
            int numberOfVerySeriousCollegues = 2;
            List<IColleague> concreteColleaguesVerySerious = CreateVerySeriousConcreteColleaguesB(mediator, numberOfVerySeriousCollegues);

            colleagues.AddRange(concreteColleaguesGossip);
            colleagues.AddRange(concreteColleaguesVerySerious);

            var random = new Random();
            

            while (true)
            {
                var senderIndex = random.Next(0, concreteColleaguesGossip.Count);

                var currentColleague = concreteColleaguesGossip[senderIndex] as GossipConcreteColleagueA;

                currentColleague.DoSomething();

                Console.WriteLine();

                //concreteColleaguesGossip = CreateGossipConcreteColleaguesA(mediator, numberOfColleagues);
                //colleagues.AddRange(concreteColleaguesGossip);

            }
        }

        

        private static List<IColleague> CreateGossipConcreteColleaguesA(IMediator mediator, int numberOfColleagues)
        {
            List<IColleague> colleagues = new List<IColleague>();
            for (int i = 0; i < numberOfColleagues; i++)
            {
                IColleague colleague = new GossipConcreteColleagueA($"Gossip Colleague {i + 1}");
                mediator.RegisterColleague(colleague);

                colleagues.Add(colleague);
            }

            return colleagues;
        }


        private static List<IColleague> CreateVerySeriousConcreteColleaguesB(IMediator mediator, int numberOfColleagues)
        {
            List<IColleague> colleagues = new List<IColleague>();
            for (int i = 0; i < numberOfColleagues; i++)
            {
                IColleague colleague = new VerySeriousConcreteColleagueB($"Very Serious Colleague {i + 1}");
                mediator.RegisterColleague(colleague);

                colleagues.Add(colleague);
            }

            return colleagues;
        }

    }
}
