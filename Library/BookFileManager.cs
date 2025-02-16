using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Library {
    public static class BookFileManager {
        public static string BookFileDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/Library";
        static BookFileManager() {
            Directory.CreateDirectory(BookFileDir);
        }
        public static void SaveBooks(List<Book> Books) {
            File.WriteAllText($"{BookFileDir}/books.json", JsonSerializer.Serialize(Books));
        }
    }
}
