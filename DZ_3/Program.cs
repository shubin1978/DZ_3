using DZ_3;

var acc1 = new BankAccount("Ivan", 320);
var acc2 = new BankAccount("Petr", 500);
var acc3 = new BankAccount("Nic", 200);

var transaction1 = new BankTransaction();
Bank bank = new Bank();
bank.AddAccount(acc1);
bank.AddAccount(acc2);
bank.AddAccount(acc3);
foreach (var item in bank.GetAllAccounts())
{
    item.PrintAccount();
}
Console.WriteLine("=============");
transaction1.Transaction(acc1,acc2,100);

foreach (var item in bank.GetAllAccounts())
{
    item.PrintAccount();
}