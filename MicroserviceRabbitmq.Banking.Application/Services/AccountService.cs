using System.Collections.Generic;
using MicroserviceRabbitmq.Banking.Application.Interfaces;
using MicroserviceRabbitmq.Banking.Domain.Interfaces;
using MicroserviceRabbitmq.Banking.Domain.Models;

namespace MicroserviceRabbitmq.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}