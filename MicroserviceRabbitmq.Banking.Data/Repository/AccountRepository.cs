using System.Collections.Generic;
using System.Linq;
using MicroserviceRabbitmq.Banking.Data.Context;
using MicroserviceRabbitmq.Banking.Domain.Interfaces;
using MicroserviceRabbitmq.Banking.Domain.Models;

namespace MicroserviceRabbitmq.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }
        
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts.ToList();
        }
    }
}