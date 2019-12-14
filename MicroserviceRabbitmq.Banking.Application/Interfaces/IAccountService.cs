using System.Collections.Generic;
using MicroserviceRabbitmq.Banking.Application.Models;
using MicroserviceRabbitmq.Banking.Domain.Models;

namespace MicroserviceRabbitmq.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}