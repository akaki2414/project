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
        public static decimal Multiplication(decimal a, decimal b) {
            return a * b;
        }
        public static decimal Division(decimal a, decimal b) {
            return a / b;
        }
        public static double Root(double a, double rootPower = 2) {
            return Math.Pow(a, 1 / rootPower);
        }
        public static double Pow(int a,int b) {
            return Math.Pow(a, b);
        }



    }
}
