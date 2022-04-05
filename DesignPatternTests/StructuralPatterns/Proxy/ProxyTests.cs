using DesignPatternsDefinitions.StructuralPatterns.Proxy;
using Xunit;

namespace DesignPatternTests.StructuralPatterns.Proxy
{
    [Collection("StructuralPatternsTests")]
    public class ProxyTests
    {
        [Fact]
        public void PaymentServiceProxy_SuccessfulyUsesProxyObject()
        {
            IPaymentService service1 = new PaymentServiceProxy(new PaymentService());
            IPaymentService service2 = new PaymentServiceProxy(new PaymentService());

            service1.Autorization(Rights.Authorized);
            
            Assert.True(service1.Transaction() == Rights.Authorized);
            Assert.False(service2.Autorization(Rights.Deny));
        }
    }
}
