using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using MicroserviceRabbitmq.Banking.Application.Interfaces;
using MicroserviceRabbitmq.Banking.Application.Models;
using MicroserviceRabbitmq.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceRabbitmq.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }
        
        [HttpPost]
        public IActionResult Post ([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}