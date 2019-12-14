using System.Collections.Generic;
using MicroserviceRabbitmq.Banking.Application.Interfaces;
using MicroserviceRabbitmq.Banking.Application.Models;
using MicroserviceRabbitmq.Banking.Domain.Commands;
using MicroserviceRabbitmq.Banking.Domain.Interfaces;
using MicroserviceRabbitmq.Banking.Domain.Models;
using MicroserviceRabbitmq.Domain.Core.Bus;

namespace MicroserviceRabbitmq.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;
        
        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.TransferAmount
            );

            _bus.SendCommand(createTransferCommand);
        }
    }
}