﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stundets {
    internal class Person {
        public string Name { get; set; }

        public virtual void ShowStats() {
            Console.Write($"name:{Name} ");
        }

    }
}
