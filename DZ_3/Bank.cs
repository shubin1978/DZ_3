using System.Diagnostics;

namespace DZ_3;

public class Bank
{
    public List<BankAccount> _AllAccounts = new List<BankAccount>();
    public List<BankAccount> GetAllAccounts() => _AllAccounts;

    public void AddAccount(BankAccount account)
    { 
        GetAllAccounts().Add(account);
    }
}