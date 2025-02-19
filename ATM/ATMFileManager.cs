using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ATM {
    public static class ATMFileManager {
        public static string ATMFileDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/ATM";
        public static string AccountsJson = ATMFileDir + @"/accounts.json";
        static ATMFileManager() {
            Directory.CreateDirectory(ATMFileDir);
            if (!File.Exists(AccountsJson)) {
                File.WriteAllText(AccountsJson, "[]");
            }
        }
        public static void SaveAccounts(List<Account> accounts) {
            File.WriteAllText(AccountsJson, JsonSerializer.Serialize(accounts));
        }
        public static List<Account> GetAccounts() {
            try {
                return JsonSerializer.Deserialize<List<Account>>(File.ReadAllText(AccountsJson)) ?? new List<Account>();
            } catch {
                Console.WriteLine("Something went wrong accessing the accounts file");
                throw;
            }
        }
    }
}
