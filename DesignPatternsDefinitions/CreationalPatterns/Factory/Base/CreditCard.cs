using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDefinitions.CreationalPatterns.Factory.Base
{
    public class CreditCard : ICard
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string UserName { get; init; }

        public Status Deposit(decimal ammount)
        {
            //somelogic
            if(ammount <= 0)
                return Status.Error;
            return Status.Success;
        }

        public decimal Interogate()
        {
            //somelogic
            return 100;
        }

        public Status Transfer(decimal ammount)
        {
            //somelogic
            if (ammount <= 0)
                return Status.Error;
            return Status.Success;
        }

        public Status Withdraw(decimal ammount)
        {
            //somelogic
            if (ammount <= 0)
                return Status.Error;
            return Status.Success;
        }
    }
}
