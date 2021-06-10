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
            List<IColleague> colleagues = new List<IColleague>();

            int numberOfColleagues = 3;
            List<IColleague> concreteColleaguesA = CreateGossipConcreteColleaguesA(mediator, numberOfColleagues);
            
            int numberOfVerySeriousCollegues = 2;
            List<IColleague> concreteColleaguesB = CreateVerySeriousConcreteColleaguesB(mediator, numberOfVerySeriousCollegues);

            colleagues.AddRange(concreteColleaguesA);
            colleagues.AddRange(concreteColleaguesB);

            var random = new Random();
            

            while (true)
            {
                var senderIndex = random.Next(0, colleagues.Count);

                var currentColleague = concreteColleaguesA[senderIndex] as GossipConcreteColleagueA;

                currentColleague.DoSomething();

                Console.WriteLine();

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
