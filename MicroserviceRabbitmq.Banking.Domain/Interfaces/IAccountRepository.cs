using System.Collections.Generic;
using MicroserviceRabbitmq.Banking.Domain.Models;

namespace MicroserviceRabbitmq.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}