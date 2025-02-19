using ATM;

Account acc = new Account();

ATMManager manager = new ATMManager();

Account? account = null;

while (true) {
    if (account is null) {
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Signup");
        var choice = Console.ReadKey(true);
        switch(choice.Key) {
            case ConsoleKey.D1:
                account = manager.Login();
                break;
            case ConsoleKey.D2:
                manager.Signup();
                break;
        }
        continue;
    }

    Console.WriteLine(
        "1.Check balance\n" +
        "2.Deposit money\n" +
        "3.Withdraw money\n" +
        "4. Log out");
    var CostumerNum = Console.ReadKey(true);

    switch (CostumerNum.Key) {
        case ConsoleKey.D1:
            manager.CheckBalance(account);
            break;
        case ConsoleKey.D2:
            manager.DepositMoney(account);
            break;
        case ConsoleKey.D3:
            manager.WithdrawMoney(account);
            break;
        case ConsoleKey.D4:
            account = null;
            break;
        default:
            Console.Clear();
            break;
    }
}



