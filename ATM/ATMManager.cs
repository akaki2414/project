using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM {
    internal class ATMManager {
        public static List<Account> accounts = new List<Account>() {
            new Account() {
                FirstName = "Krak",
                LastName = "Khorava",
                IDNumber = "01951004371",
                Balance = 99999999
            },
            new Account() {
                FirstName = "Giorgi",
                LastName = "Lomsadze",
                IDNumber = "01375690019",
                Balance = 15
            }
        };

        public Account? Login() {
            Console.Write("Input your ID number: ");
            var id = Console.ReadLine();
            if (id.Length != 11 || !int.TryParse(id, out _)) {
                Console.WriteLine("Invalid ID");
                return null;
            }
            var account = accounts.FirstOrDefault(a => a.IDNumber == id);
            if (account is null) Console.WriteLine("Couldn't find account");
            return account;
        }

        public void CheckBalance(Account account) {
            Console.WriteLine(account.Balance);   
        }
        public void DepositMoney(Account account) {
            Console.Write("How much to deposit: ");
            int money = Console.ReadLine()!.GetInt();
            account.Balance += money;
            Console.WriteLine("Successfully deposited");
        }
        public void WithdrawMoney(Account account) {
            Console.Write("Enter desired amount to withdraw: ");
            int money = Console.ReadLine()!.GetInt();
            if (account.Balance - money < 0) {
                Console.WriteLine("You don't have enough money"); 
                return;
            }
            account.Balance -= money;
            Console.WriteLine($"Withdrew {money}");
        }

        
    }
}
