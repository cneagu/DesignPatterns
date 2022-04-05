namespace DesignPatternsDefinitions.StructuralPatterns.Proxy
{
    public interface IPaymentService
    {
        bool Autorization(Rights rights);
        string GetPrice(string currencyName);
        string SetPrice(string currencyName, int value);
        Rights Transaction();
    }
}