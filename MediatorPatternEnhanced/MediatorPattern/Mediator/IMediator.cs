using MediatorPattern.Colleagues;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Mediator
{
    public interface IMediator
    {
        void RegisterColleague(IColleague colleague);
        void RemoveColleague(IColleague colleague);

        void SendMessage(IColleague sender, string type, string content);

    }
}
