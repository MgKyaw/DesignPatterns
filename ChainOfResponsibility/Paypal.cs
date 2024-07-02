namespace ChainOfResponsibility;

class Paypal : Account
{
    public Paypal (decimal balance)
    {
        this.mBalance = balance;
    }
}