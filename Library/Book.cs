using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    public class Book {
        private string _title;
        public string Title {
            get { return _title; } 
            set {
                if (value.Length < 2) {

                }
                _title = value;
            
            } 
        }
        public Author Author { get; set; }
        public int Year { get; set; }
        public List<string> Categories { get; set; }


        public override string ToString() {
            return $"Name: {Title}, Director: {Author.Name} {Author.Lastname}, Year {Year}";
        }
    }
}
