namespace DesignPatternsDefinitions.StructuralPatterns.Proxy
{
    public class PaymentServiceProxy : IPaymentService
    {
        private readonly IPaymentService provider;
        public PaymentServiceProxy(IPaymentService provider)
        {
            this.provider = provider;
        }
        public bool Autorization(Rights rights)
        {
            //aditional checks pre processing
            return provider.Autorization(rights);
        }

        public string GetPrice(string currencyName)
        {
            return provider.GetPrice(currencyName);
            // post processing
        }

        public string SetPrice(string currencyName, int value)
        {
            //performance improvement if we call paralel 3p services
            return provider.SetPrice(currencyName, value);
        }

        public Rights Transaction()
        {
            //additional security layer
            return provider.Transaction();
        }
    }
}
