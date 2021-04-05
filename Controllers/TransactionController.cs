using EventDrivenProgramingDemo.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenProgramingDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService transactionService;
        private readonly IAuditService auditService;

        public TransactionController(ITransactionService transactionService, IAuditService auditService)
        {
            this.transactionService = transactionService;
            this.auditService = auditService;
            this.auditService.Subscribe(this.transactionService);
        }

        [HttpPost]
        [Route("deposit")]
        public IActionResult MakeDeposit([FromQuery]decimal amount)
        {
            this.transactionService.MakeDeposit(amount);
            return Ok();
        }

        [HttpPost]
        [Route("withdrawal")]
        public IActionResult MakeWithdrawal([FromQuery]decimal amount)
        {
            this.transactionService.MakeWidrawal(amount);
            return Ok();
        }
    }
}
