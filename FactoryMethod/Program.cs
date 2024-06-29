namespace FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        var developerManager = new DeveloperManager();
        developerManager.TakeInterview(); //Output : Asking about design patterns!

        var marketingManager = new MarketingManager();
        marketingManager.TakeInterview(); //Output : Asking about community building!
    }
}