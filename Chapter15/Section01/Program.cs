using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var min = Library.Books.Min(X=>X.Title.Length);
            var book = Library.Books.First(x => x.Title.Length == min);
            Console.WriteLine(book);

            var average = Library.Books.Average(x=>x.Title.Length);
            var book2 = Library.Books.Where(b=>b.Price>average);
            foreach(var b in book2) Console.WriteLine(b);

            var query = Library.Books.Select(b => b.PublishedYear).Distinct().OrderBy(y => y);
            foreach(var q in query) Console.WriteLine(q);
        }
    }
}
