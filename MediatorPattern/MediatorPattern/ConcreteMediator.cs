using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class ConcreteMediator : IMediator
    {
        List<IParticipant> participants = new List<IParticipant>();
        public void AddParticipant(IParticipant participant)
        {
            participants.Add(participant);
        }
        public void BroadcastMessage(string message, IParticipant sender)
        {
            Console.WriteLine(sender + ": " + message);
        }
    }
}
