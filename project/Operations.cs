using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace project {
    internal class Operations {

        public static int Add(int a, int b) { 
            return a + b;
        }
        public static int Subtraction(int a, int b) {
            return a - b;
        }
        public static int Multiplication(int a, int b) {
            return a * b;
        }
        public static int Division(int a, int b) {
            return a / b;
        }
        public static double Root(int a) {
            return Math.Sqrt(a);
        }
        public static double Pow(int a,int b) {
            return Math.Pow(a, b);
        }



    }
}
