using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stundets {
    internal class Teacher: Person {
        public string subject { get; set; }

        public override void ShowStats() {
            base.ShowStats();
            Console.Write($" subject:{subject}");
        }
    }
}
