using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Library {
    internal class BookManager {
        public List<Book> books = new List<Book>()
        {
            new Book()
            {
                Title = "The hobit",
                Author = new Author(){
                    Name = "jrr",
                    Lastname = "Tolkein",
                },
                Year =  1954,
                Categories = ["fantasy"]
            },
            new Book()
            {
                Title = "Lord of the Rings",
                Author = new Author(){
                    Name = "jrr",
                    Lastname = "Tolkein",
                },
                Year =  1954,
                Categories = ["fantasy"]
            },
            new Book ()
            {
                Title = "Harry Potter" ,
                Author = new Author(){
                    Name = "jk",
                    Lastname = "Rowling",
                },
                Year = 1997,
                Categories = ["fantasy","Contemporary Fantasy","Low Fantasy"]
            },
            new Book ()
            {
                Title = "A Murder is Announced" ,
                Author = new Author(){
                    Name = "Agatha",
                    Lastname = "Christie",
                },
                Year = 1997,
                Categories = ["mystery","crime"]
            },
                new Book ()
            {
                Title = "The Murder of Roger Ackroyd " ,
                Author = new Author(){
                    Name = "Agatha",
                    Lastname = "Christie",
                },
                Year = 1997,
                Categories = ["crime","detective"]
            }
        };

        public void Add() {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book author Name:");
            string authorName = Console.ReadLine();


            Console.Write("Enter book author LastName: ");
            string authorLast = Console.ReadLine();

            Console.Write("Enter book year: ");
            int year = Console.ReadLine()!.GetInt();

            Console.WriteLine("what genre is your book");
            string genre = Console.ReadLine();

            Book book = new Book() {

                Title = title,
                Author = new Author() {
                    Name = authorName,
                    Lastname = authorLast,
                },
                Year = year,
                Categories = [genre]
               
            };
            books.Add(book);
            BookFileManager.SaveBooks(books);
            
        }
        public void DisplayBooks() {
            foreach (Book book in books) {
                Console.WriteLine(book);
            }
        }
        public void Search() {
            Console.Write("Search book name or author: ");
            var SearchedBook = Console.ReadLine()!.ToLower().Split(' ').ToList();
            var book = books.Where(b => 
                SearchedBook.Any(str => b.Title.ToLower().Contains(str)) || 
                SearchedBook.Any(str => b.Author.Name.ToLower().Contains(str))||
                SearchedBook.Any(str => b.Author.Lastname.ToLower().Contains(str)) 
            );
            if (book is null) {
                Console.WriteLine($"No results for {SearchedBook}");
                return;
            }
            book.PrintAll();
        }
        public void DeleteBook() {
            Console.WriteLine("enter book title to remove");
            string title = Console.ReadLine();

            Book del = null;
            foreach (var item in books) {
                if (item.Title == title)
                    del = item;
                else {
                    Console.WriteLine(" no book found");
                }
            }
            books.Remove(del);  
        }
        public void categories() {
            Console.WriteLine("\nchoose category \n1.fantasy\n2.mystery\n3.crime fiction\n4.detective fiction\n");
            var CustomerCat = Console.ReadKey(true);

            foreach (var book in books) {
                if (CustomerCat.Key == ConsoleKey.D1) {
                    if (book.Categories.Contains("fantasy")) {
                        Console.WriteLine($"Name: {book.Title}, Director: {book.Author.Name} {book.Author.Lastname}, Year {book.Year}");
                    }
                }
                else if (CustomerCat.Key == ConsoleKey.D2) {
                    if (book.Categories.Contains("mystery")) {
                        Console.WriteLine($"Name: {book.Title}, Director: {book.Author.Name} {book.Author.Lastname}, Year {book.Year}");
                    }
                }
                else if (CustomerCat.Key == ConsoleKey.D3) {
                    if (book.Categories.Contains("crime")) {
                        Console.WriteLine($"Name: {book.Title}, Director: {book.Author.Name} {book.Author.Lastname}, Year {book.Year}");
                    }
                }
                else if (CustomerCat.Key == ConsoleKey.D4) {
                    if (book.Categories.Contains("detective")) {
                        Console.WriteLine($"Name: {book.Title}, Director: {book.Author.Name} {book.Author.Lastname}, Year {book.Year}");
                    }
                }
            }
        }
    }
}
