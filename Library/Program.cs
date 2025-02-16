using Library;

BookManager bm = new BookManager();

List<Book> books = bm.books;

BookFileManager.SaveBooks(books);
while (true) {
    Console.WriteLine("1. See books");
    Console.WriteLine("2. search");
    Console.WriteLine("3. add book");
    Console.WriteLine("4. remove book");
    Console.WriteLine("5.categories");
    var input = Console.ReadKey(true);

    switch(input.Key) {
        case ConsoleKey.D1:
            bm.DisplayBooks();
            break;
        case ConsoleKey.D2:
            bm.Search();
            break;
        case ConsoleKey.D3:
            bm.Add();
            break;
        case ConsoleKey.D4:
            bm.DeleteBook();
            break;
        case ConsoleKey.D5:
            bm.categories();
            break;
        default:
            Console.Clear();
            break;
    }
}

