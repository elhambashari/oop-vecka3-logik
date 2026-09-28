BankAccount account = new BankAccount();

bool running = true;

while (running)
{
    MenuHelper.ShowMenu();

    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            Console.Write("Ange belopp att sätta in: ");
            double deposit = double.Parse(Console.ReadLine()!);
            account.Deposit(deposit);
            break;

        case "2":
            Console.Write("Ange belopp att ta ut: ");
            double withdraw = double.Parse(Console.ReadLine()!);
            account.Withdraw(withdraw);
            break;

        case "3":
            account.ShowBalance();
            break;

        case "4":
            running = false;
            Console.WriteLine("Programmet avslutas.");
            break;

        default:
            Console.WriteLine("Ogiltigt val.");
            break;
    }
}

