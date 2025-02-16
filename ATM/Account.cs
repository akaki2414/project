using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM {
    internal class Account {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IDNumber { get; set; }
        public int Balance { get; set; }
        public override string ToString() {
            return $"Name: {FirstName} {LastName}, ID: {IDNumber}, Balance: {Balance}";
        }
    }
}
