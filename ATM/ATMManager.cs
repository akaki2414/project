using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM {
    internal class ATMManager {
        public static List<Account> accounts = ATMFileManager.GetAccounts();

        public void Signup() {
            Console.Write("Input your first name: ");
            var fname = Console.ReadLine();
            Console.Write("Input your last name: ");
            var lname = Console.ReadLine();
            Console.Write("Input your ID Number: ");
            var id = Console.ReadLine()!.Trim();

            var existingAccount = accounts.FirstOrDefault(a => a.IDNumber == id);
            if (id.Length != 11 || !int.TryParse(id, out _)) {
                Console.WriteLine("Invalid ID");
                return;
            }
            if (accounts.Any(a => a.IDNumber == id)) {
                Console.WriteLine("ID is already in use");
                return;
            }
            var account = new Account() {
                FirstName = fname,
                LastName = lname,
                IDNumber = id,
                Balance = 0
            };
            accounts.Add(account);
            ATMFileManager.SaveAccounts(accounts);

        }
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
            ATMFileManager.SaveAccounts(accounts);
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
            ATMFileManager.SaveAccounts(accounts);
            Console.WriteLine($"Withdrew {money}");
        }

        
    }
}
