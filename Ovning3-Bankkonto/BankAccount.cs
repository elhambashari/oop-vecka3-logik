class BankAccount
{
    public double Balance { get; private set; } = 0;

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("Insättningen lyckades.");
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Uttaget lyckades.");
        }
        else
        {
            Console.WriteLine("Fel! Du har inte tillräckligt med pengar.");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Saldo: {Balance} kr");
    }
}