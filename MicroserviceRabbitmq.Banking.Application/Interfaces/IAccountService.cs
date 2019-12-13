using System.Collections.Generic;
using MicroserviceRabbitmq.Banking.Domain.Models;

namespace MicroserviceRabbitmq.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}