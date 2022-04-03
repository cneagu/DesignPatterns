using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDefinitions.CreationalPatterns.Factory
{
    public interface ICard
    {
        Guid Id { get; init; }
        string Name { get; init; }   
        string UserName { get; init; }   

        Status Deposit(decimal ammount);
        
        Status Withdraw(decimal ammount);

        decimal Interogate();

        Status Transfer(decimal ammount);
    }
}
