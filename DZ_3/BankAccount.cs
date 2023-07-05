namespace DZ_3;

public class BankAccount
{
    private string _name;
    private int _balance;

    public BankAccount(string name, int balance)
    {
        Name = name;
        Balance = balance;
    }

    public string Name { get;}

    public int Balance
    {
        get => _balance;
        set => _balance = value;
    }

    public void PrintAccount()
    {
        Console.WriteLine($"{Name} -> {Balance}");
    }
}