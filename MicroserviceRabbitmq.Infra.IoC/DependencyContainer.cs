using MediatR;
using MicroserviceRabbitmq.Banking.Application.Interfaces;
using MicroserviceRabbitmq.Banking.Application.Services;
using MicroserviceRabbitmq.Banking.Data.Context;
using MicroserviceRabbitmq.Banking.Data.Repository;
using MicroserviceRabbitmq.Banking.Domain.CommandHandlers;
using MicroserviceRabbitmq.Banking.Domain.Commands;
using MicroserviceRabbitmq.Banking.Domain.Interfaces;
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
            
            // Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();
            
            
            // Application Services
            services.AddTransient<IAccountService, AccountService>();
            
            // Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
            
            
        }
    }
}