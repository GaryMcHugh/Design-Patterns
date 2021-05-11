using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public interface IParticipant
    {
        void SendMessage(string message);
    }
}
