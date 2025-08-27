namespace BankEncapsulation;

public class BankAccount
{
    private double _balance;

    public void Deposit(double moneyToAdd)
    {
        _balance += moneyToAdd;
    }

    public double CheckBalance()
    {
        return _balance;
    }

    public void Withdraw(double moneyToWithdraw)
    {
        if (_balance < 0)
        {
            throw new Exception("Insufficient balance");
        }
        _balance -= moneyToWithdraw;
    }
    
}