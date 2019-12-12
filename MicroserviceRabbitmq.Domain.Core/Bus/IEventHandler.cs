using System.Threading.Tasks;
using MicroserviceRabbitmq.Domain.Core.Events;

namespace MicroserviceRabbitmq.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {
        
    }
}