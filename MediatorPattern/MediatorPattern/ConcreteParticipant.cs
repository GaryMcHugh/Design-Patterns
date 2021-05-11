using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class ConcreteParticipant : IParticipant
    {
        protected IMediator mediator;
        public ConcreteParticipant(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void SendMessage(string message)
        {
            mediator.BroadcastMessage(message, this);
        }
    }

    public class ConcreteParticipant2 : IParticipant
    {
        protected IMediator mediator;
        public ConcreteParticipant2(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public void SendMessage(string message)
        {
            mediator.BroadcastMessage(message, this);
        }
    }
}
