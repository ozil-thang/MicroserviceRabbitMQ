using System.Reflection.Metadata;
using System.Threading.Tasks;
using MicroserviceRabbitmq.Domain.Core.Commands;
using MicroserviceRabbitmq.Domain.Core.Events;

namespace MicroserviceRabbitmq.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}