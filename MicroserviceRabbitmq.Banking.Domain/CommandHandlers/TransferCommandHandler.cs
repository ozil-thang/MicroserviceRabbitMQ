using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MicroserviceRabbitmq.Banking.Domain.Commands;
using MicroserviceRabbitmq.Banking.Domain.Events;
using MicroserviceRabbitmq.Domain.Core.Bus;

namespace MicroserviceRabbitmq.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
            
            return Task.FromResult(true);
        }
    }
}