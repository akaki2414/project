using project;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

var x = true;


while (x) {

    Console.WriteLine("choose first number");
    int FirstNum;
    while (true) {
        try {
            FirstNum = int.Parse(Console.ReadLine());
            break;
        }
        catch (FormatException) {
            Console.Write("Input only numbers\n");
        }
    }
    Console.WriteLine("enter operation");
    char Operation = '+';
    bool tf = true;

    while (true) {
        try {
            Operation = char.Parse(Console.ReadLine());
            break;
        }
        catch (FormatException) {
            Console.Write("this operand dont exists\n");
        }
    }



    int SecNum = 0;

    if (Operation != 'V') {
        Console.WriteLine("choose second number");
        while (true) {
            try {
                SecNum = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException) {
                Console.Write("Input only numbers\n");
            }
        };

    } 
    switch (Operation) {
            case '+':
                Console.WriteLine($"{FirstNum}{Operation}{SecNum}={Operations.Add(FirstNum, SecNum)}");
                break;
            case '-':
                Console.WriteLine(Operations.Subtraction(FirstNum, SecNum));
                break;
            case '*':
                Console.WriteLine($"{FirstNum}{Operation}{SecNum}={Operations.Multiplication(FirstNum, SecNum)}");
                break;
            case '/':
                Console.WriteLine($"{FirstNum}{Operation}{SecNum}={Operations.Division(FirstNum, SecNum)}");
                break;
            case 'V':
                Console.WriteLine($"sqrt{FirstNum}={Operations.Root(FirstNum)}");
                break;
            case '^':
                Console.WriteLine($"{FirstNum}{Operation}{SecNum}={Operations.Pow(FirstNum, SecNum)}");
                break;
        }

        Console.WriteLine("press backspace to exit, or enter to continue");


        var bs = Console.ReadKey();
        if (bs.Key == ConsoleKey.Backspace) {
            x = false;
        }
        else if (bs.Key == ConsoleKey.Enter) {
            x = true;
        }

    
}
