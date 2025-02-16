using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTN {
    internal class RandomNum {

        public static void Game(int a, int b,int c) {
            bool tf = true;
            int points = 0;

            Random rnd = new Random();
            int BotNum = rnd.Next(a, b);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"botnum: {BotNum}");
            Console.ForegroundColor = ConsoleColor.White;


            int count = 0;

            while (tf) {
                count++;

                Console.WriteLine("try to guess the bot number");
                int PlayerNum = 0;
                try {
                    PlayerNum = int.Parse(Console.ReadLine()!);
                }
                catch (FormatException) {
                    Console.Write("Input only numbers\n");
                }

                if (PlayerNum == BotNum) {
                    Console.WriteLine($"Number is Correct, you got {c} point \n");
                    points += c;
                    

                    BotNum = rnd.Next(a, b);
                    Console.WriteLine($"score: {points}");
                    
                    if (points < 20) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"next botnum: {BotNum}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    

                }
                else {
                    
                    Console.WriteLine("Number is wrong try again");
                    if (PlayerNum < BotNum) {
                        Console.WriteLine("try higher number");
                    }
                    else if (PlayerNum > BotNum) {
                        Console.WriteLine("try lower number");
                    }

                    if(points > 0) {
                        points--;
                    }
                    
                    Console.WriteLine($"score: {points}");
                }

                if (points > 19) {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"!!you won the game in {count} tries !!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    tf = false;
                }

                
            }
            

        }

    }
}
