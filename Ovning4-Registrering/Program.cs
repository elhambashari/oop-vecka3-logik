Account account = new Account();

bool running = true;

while (running)
{
    MenuHelper.ShowMenu();

    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            Console.Write("Ange användarnamn: ");
            string newUsername = Console.ReadLine()!;

            Console.Write("Ange lösenord: ");
            string newPassword = Console.ReadLine()!;

            if (account.Register(newUsername, newPassword))
            {
                Console.WriteLine("Registreringen lyckades!");
            }
            else
            {
                Console.WriteLine("Registreringen misslyckades.");
                Console.WriteLine("Lösenordet måste ha minst 6 tecken, 1 siffra, 1 stor bokstav och 1 specialtecken.");
            }
            break;

        case "2":
            Console.Write("Ange användarnamn: ");
            string username = Console.ReadLine()!;

            Console.Write("Ange lösenord: ");
            string password = Console.ReadLine()!;

            if (account.Login(username, password))
            {
                Console.WriteLine("Inloggningen lyckades!");
            }
            else
            {
                Console.WriteLine("Fel användarnamn eller lösenord.");
            }
            break;

        case "3":
            running = false;
            Console.WriteLine("Programmet avslutas.");
            break;

        default:
            Console.WriteLine("Ogiltigt val.");
            break;
    }
}
