using MicroserviceRabbitmq.Domain.Core.Bus;
using MicroserviceRabbitmq.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroserviceRabbitmq.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}