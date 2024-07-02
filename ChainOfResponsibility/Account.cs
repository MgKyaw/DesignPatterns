namespace ChainOfResponsibility;

abstract class Account
{
    private Account mSuccessor;
    protected decimal mBalance;

    public void SetNext(Account account)
    {
        this.mSuccessor = account;
    }

    public void Pay(decimal amountToPay)
    {
        if(CanPay(amountToPay))
        {
            Console.WriteLine($"Paid {amountToPay:c} using {this.GetType().Name}.");
        }
        else if(mSuccessor is not null)
        {
            Console.WriteLine($"Cannot pay using {this.GetType().Name}. Processing");
            mSuccessor.Pay(amountToPay);
        }
        else
        {
            throw new Exception("None of the accounts have enough balance.");
        }
    }

    private bool CanPay(decimal amountToPay)
    {
        return this.mBalance >= amountToPay;
    }
}