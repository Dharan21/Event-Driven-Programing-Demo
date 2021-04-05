using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenProgramingDemo.Interfaces
{
    public interface IAuditService
    {
        void Subscribe(ITransactionService transactionService);
    }
}
