using System.Globalization;

namespace Opgave03.model;

public class BankAccount
{
    public string Accountnumber { get; set; }
    public string Owner { get; set; }
    public decimal Balance { get; set; }
    public bool IsOverdrawn
    {
        get => Balance < 0;
    }
    public string FormattedBalance
    {
        get => Balance.ToString("N2") + " DKK";
        //get => Balance.ToString("C")
    }

    public void deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void withdraw(decimal amount)
    {
        Balance -= amount;
    }
}