using MediatorPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Colleagues
{
    public interface IColleague
    {

        void SetMediator(IMediator mediator);

        void ReceiveMessage(string type, string content);

    }
}
