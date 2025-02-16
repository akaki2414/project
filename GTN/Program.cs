using GTN;

Console.WriteLine("Guess The Number");

List<string> difficulty = new List<string>() {
    "easy","medium","hard",
};
bool PlayAgain = true;

while (PlayAgain) {
    Console.WriteLine("choose difficulty easy(1-10) : medium(1-20) : hard(1-35)");
    string Diff = "kk";
    bool tf = true;
    while (tf) {
        Diff = Console.ReadLine()!;
        if (!difficulty.Contains(Diff)) {
            Console.WriteLine("input only difficult levels");
        }
        else {
            tf = false;
        }
    }


    if (Diff == "easy") {
        RandomNum.Game(1, 10, 2);
    }
    else if (Diff == "medium") {
        RandomNum.Game(1, 20, 4);
    }
    else if (Diff == "hard") {
        RandomNum.Game(1, 35, 5);
    }

    Console.WriteLine("press enter to play again");
    var enter = Console.ReadKey(true);

    if(enter.Key == ConsoleKey.Enter) {
        PlayAgain = true;
    }
    else {
        PlayAgain = false;
    }
}






