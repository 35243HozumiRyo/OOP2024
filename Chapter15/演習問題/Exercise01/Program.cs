using Section01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(x=>x.Price);
            var book = Library.Books.Where(x => x.Price == max);
            foreach(var item in book) Console.WriteLine(item);
        }

        private static void Exercise1_3() {
            var count = Library.Books.OrderBy(x => x.PublishedYear).GroupBy(x => x.PublishedYear);
            foreach(var item in count) Console.WriteLine(item.Key + "   " + Library.Books.Count(x => x.PublishedYear==item.Key)+"冊");
        }

        private static void Exercise1_4() {
            var query = Library.Books.Join(Library.Categories, book => book.CategoryId, category => category.Id,(book, category) => new {book.Title,book.PublishedYear,book.Price,CategoryName = category.Name})
                .OrderByDescending(x=>x.PublishedYear).ThenByDescending(x=>x.Price);
            foreach (var item in query) Console.WriteLine("{0}年 {1}円 {2} ({3})", item.PublishedYear, item.Price, item.Title, item.CategoryName);
        }

        private static void Exercise1_5() {
            var Year = Library.Books.Where(x => x.PublishedYear == 2016);
            foreach (var item in Year)

                Console.WriteLine($"{ Library.Categories.Where(x => x.Id == item.CategoryId)}");
        }

        private static void Exercise1_6() {
            
        }
        
        private static void Exercise1_7() {
            
        }

        private static void Exercise1_8() {
            
        }
    }
}
