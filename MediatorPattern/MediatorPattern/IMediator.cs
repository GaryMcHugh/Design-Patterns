using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public interface IMediator
    {
        void AddParticipant(IParticipant participant);
        void BroadcastMessage(string message, IParticipant sender);
    }
}
