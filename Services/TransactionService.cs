using EventDrivenProgramingDemo.Events;
using EventDrivenProgramingDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenProgramingDemo.Services
{
    public class TransactionService : ITransactionService
    {
        public event EventHandler<TransactionProcessedEventArgs> OnTransactionProcessed;

        public void MakeDeposit(decimal amount)
        {
            ProcessDeposit(amount);
            if (OnTransactionProcessed != null)
            {
                OnTransactionProcessed(this, new TransactionProcessedEventArgs(amount, TransactionType.Deposit));
            }
        }

        public void MakeWidrawal(decimal amount)
        {
            ProcessWidrawal(amount);
            if (OnTransactionProcessed != null)
            {
                OnTransactionProcessed(this, new TransactionProcessedEventArgs(amount, TransactionType.Withdrawal));
            }
        }

        // Private Methods
        private void ProcessDeposit(decimal amount)
        {
            //
        }
        private void ProcessWidrawal(decimal amount)
        {
            //
        }
    }
}
