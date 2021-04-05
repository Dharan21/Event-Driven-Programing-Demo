using EventDrivenProgramingDemo.Events;
using EventDrivenProgramingDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenProgramingDemo.Services
{
    public class AuditService : IAuditService
    {
        public void Subscribe(ITransactionService transactionService)
        {
            transactionService.OnTransactionProcessed += WriteLog;
        }

        private void WriteLog(object sender, TransactionProcessedEventArgs eventArgs)
        {
            Console.WriteLine($"AUDIT LOG: { eventArgs.TransactionType } for ${ eventArgs.Amount } processed.");
        }
    }
}
