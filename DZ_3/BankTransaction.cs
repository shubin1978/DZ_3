namespace DZ_3;

public class BankTransaction
{
    public BankAccount _reciever;
    public BankAccount _sender;
    public int _summ;
    public void Transaction(BankAccount reciever, BankAccount sender, int sum)
    {
        _reciever = reciever;
        _sender = sender;
        _summ = sum;
        reciever.Balance = reciever.Balance + sum;
        sender.Balance = sender.Balance - sum;
    }
}