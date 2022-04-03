using DesignPatternsDefinitions.CreationalPatterns.Factory;
using DesignPatternsDefinitions.CreationalPatterns.Factory.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatternTests.CreationalPatterns
{
    [Collection("CreationPatternsTests")]
    public class FactoryTests
    {
        [Theory]
        [InlineData(CardType.Credit, typeof(CreditCard))]
        [InlineData(CardType.Debit, typeof(DebitCard))]
        public void ShouldCreateSpecificCard(CardType card, Type instanceType)
        {
            ICard card1 = CardFactory.CreateCard(card);
            Assert.Equal(instanceType, card1.GetType());
        }
    }
}
