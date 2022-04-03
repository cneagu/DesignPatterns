using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDefinitions.CreationalPatterns.Factory.Base
{
    public static class CardFactory 
    {
        public static ICard CreateCard(CardType cardType)
        {
            return cardType switch
            {
                CardType.Credit => new CreditCard(),
                CardType.Debit => new DebitCard(),
                _ => null
            };
        }
    }
}
