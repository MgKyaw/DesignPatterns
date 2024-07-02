namespace ChainOfResponsibility;

class Bitcoin : Account
{
    public Bitcoin(decimal balance)
    {
        this.mBalance = balance;
    }
}