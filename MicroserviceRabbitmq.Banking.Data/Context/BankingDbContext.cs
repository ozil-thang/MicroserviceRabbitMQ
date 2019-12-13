using MicroserviceRabbitmq.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceRabbitmq.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions<BankingDbContext> options) : base(options)
        {
            
        }
        public DbSet<Account> Accounts { get; set; }
    }
}