using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stundets {
    internal class Student : Person {
       
        public int RollNumber { get; set; } 
        public int Grade { get; set; }
        

        public override void ShowStats() {
            base.ShowStats();
            Console.WriteLine($"RollNumber:{RollNumber} grade:{Grade}");
        }
    }
}
