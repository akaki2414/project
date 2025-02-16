using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM {
    public static class Extensions {
        public static int GetInt(this string str) {
            try {
                return int.Parse(str);
            } catch(FormatException) {
                Console.Write("Input only numbers: ");
                return Console.ReadLine()!.GetInt();
            }
        }
        public static void PrintAll<T>(this IEnumerable<T> list) {
            foreach (T item in list) {
                Console.WriteLine(item);
            }
        }
    }
}
