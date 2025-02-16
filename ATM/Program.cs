using ATM;
using System.ComponentModel.Design;
using System.Security.Principal;

Account acc = new Account();

ATMManager manager = new ATMManager();

Account? account = null;

while(account is null) {
    account = manager.Login();
}


while (true) {

    Console.WriteLine("1.Check balance\n2.Deposite money\n3.Withdraw money");
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
        default:
            Console.Clear();
            break;
    }
}



