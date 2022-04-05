using DesignPatternsDefinitions.CreationalPatterns.Factory;
using DesignPatternsDefinitions.CreationalPatterns.Factory.Base;
using System;
using Xunit;

namespace DesignPatternTests.CreationalPatterns
{
    [Collection("CreationalPatternsTests")]
    public class FactoryTests
    {
        [Theory]
        [InlineData(CardType.Credit, typeof(CreditCard))]
        [InlineData(CardType.Debit, typeof(DebitCard))]
        public void CardFactory_ShouldCreateSpecificCard(CardType card, Type instanceType)
        {
            ICard card1 = CardFactory.CreateCard(card);
            Assert.Same(instanceType, card1.GetType());
        }
    }
}
