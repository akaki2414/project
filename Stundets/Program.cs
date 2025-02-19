using Stundets;

StudentsManager SM = new StudentsManager();
bool exit = true;
while (exit) {

    Console.WriteLine("\n1.see all students");
    Console.WriteLine("2.add student");
    Console.WriteLine("3.search student");
    Console.WriteLine("4.update stundets grade");
    Console.WriteLine("5.exit");
    var input = Console.ReadKey(true);

    switch (input.Key) {
        case ConsoleKey.D1:
            SM.ShowStudents();
            break;
        case ConsoleKey.D2:
            SM.AddStudent();
            break;
        case ConsoleKey.D3:
            SM.SearchStudents();
            break;
        case ConsoleKey.D4:
            SM.UpdateGrade();
            break;
        case ConsoleKey.D5:
            exit = false;
            break;
        default:
            Console.Clear();
            break;
    }

}