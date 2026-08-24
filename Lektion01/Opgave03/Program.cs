using Opgave03.model;

namespace Opgave03;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount();
        BankAccount account2 = new BankAccount();
        BankAccount account3 = new BankAccount();

        account1.Balance = 500;
        account2.Balance = 1000;
        account3.Balance = 5000;
        
        Console.WriteLine(account1.Balance);
        Console.WriteLine(account1.FormattedBalance);
        
        account1.withdraw(500);

        Console.WriteLine(account1.Balance);
        Console.WriteLine(account1.FormattedBalance);
    }
}

