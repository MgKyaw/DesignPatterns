namespace ChainOfResponsibility;

class Bank : Account
{
    public Bank(decimal balance)
    {
        this.mBalance = balance;
    }
}