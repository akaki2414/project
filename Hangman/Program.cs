using Hangman;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
Game game = new Game();
Random random = new Random();

string word = game.HangmanWords[random.Next(game.HangmanWords.Count)];
Console.WriteLine(word);

string guessed = new string('_', word.Length);
Console.WriteLine(guessed);




var lives = 10;

while (lives != 0) {
    foreach (var character in word) {
        var letters = new List<string>();
        Console.Write("Input your letter:");
        string guess = Console.ReadLine();

        letters.Add(guess);

        var charsleft = 0;
        var letter = character.ToString();
        if (letters.Contains(letter)) {
            Console.Write(letter);
            break;
        }
        else {
            Console.Write('_');
            charsleft++;
        }
        if (charsleft == 0) {
                  break;
        }

      
    }
}



