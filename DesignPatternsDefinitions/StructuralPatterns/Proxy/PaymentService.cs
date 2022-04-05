namespace DesignPatternsDefinitions.StructuralPatterns.Proxy
{
    public class PaymentService : IPaymentService
    {
        private bool hasAutorization = false;
        public Rights Transaction() => hasAutorization ? Rights.Authorized : Rights.Deny;

        public string GetPrice(string currencyName) => string.Format("The rate is {0} for {1}", 23, currencyName);

        public string SetPrice(string currencyName, int value)
        {
            if (hasAutorization)
                return string.Format("The rate of {0} is set to {1}", currencyName, value);

            return string.Format("Please autheticate yourself");
        }

        public bool Autorization(Rights rights)
        {
            if (rights == Rights.Authorized)
            {
                hasAutorization = true;
                return true;
            }
            return false;
        }
    }
}
