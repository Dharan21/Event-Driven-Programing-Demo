using EventDrivenProgramingDemo.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenProgramingDemo.Interfaces
{
    public interface ITransactionService
    {
        event EventHandler<TransactionProcessedEventArgs> OnTransactionProcessed;
        void MakeDeposit(decimal amount);
        void MakeWidrawal(decimal amount);
    }
}
