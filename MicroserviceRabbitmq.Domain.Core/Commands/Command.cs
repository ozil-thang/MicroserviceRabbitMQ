using System;
using MicroserviceRabbitmq.Domain.Core.Events;

namespace MicroserviceRabbitmq.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
        
    }
}