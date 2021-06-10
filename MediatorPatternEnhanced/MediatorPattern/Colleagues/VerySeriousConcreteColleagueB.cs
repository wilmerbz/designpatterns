using MediatorPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Colleagues
{
    public class VerySeriousConcreteColleagueB : IColleague
    {

        public string Name { get; set; }

        private IMediator Mediator { get; set; }

        public VerySeriousConcreteColleagueB(string name)
        {
            Name = name;
        }

        public void ReceiveMessage(string type, string content)
        {
            switch (type)
            {
                case "Important":
                    Console.WriteLine($"[{Name}] - It is {type} - {content}.");

                    break;
                default:
                    Console.WriteLine($"[{Name}] - I don't care.");
                    break;
            }
            
        }

        public void SetMediator(IMediator mediator)
        {
            Mediator = mediator;
        }

    }
}
