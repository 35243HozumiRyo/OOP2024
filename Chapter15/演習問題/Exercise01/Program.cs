using Section01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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
            var query = Library.Books.Where(b => b.PublishedYear ==2016).Join(Library.Categories,book=>book.CategoryId,category=>category.Id,(book,category)=>category.Name).Distinct();
            foreach (var item in query) Console.WriteLine(item);
        }
    
        private static void Exercise1_6() {
            var query = Library.Books.Join(Library.Categories, book => book.CategoryId, category => category.Id, (book, category) => new { book.Title, CategoryName = category.Name }).GroupBy(x=>x.CategoryName).OrderBy(x=>x.Key);
            foreach (var group in query) {
                Console.WriteLine("#{0}", group.Key);
                foreach (var item in group) Console.WriteLine(" {0}", item.Title);
            }
        }
        
        private static void Exercise1_7() {
            var categoryId = Library.Categories.Single(c=>c.Name == "Development").Id;
            var query = Library.Books.Where(b=>b.CategoryId == categoryId).GroupBy(b=>b.PublishedYear).OrderBy(x=>x.Key);
            foreach (var group in query) {
                Console.WriteLine("#{0}", group.Key);
                foreach (var item in group) Console.WriteLine(" {0}", item.Title);
            }
        }

        private static void Exercise1_8() {
            var query = Library.Categories.GroupJoin(Library.Books, c => c.Id, b => b.CategoryId, (c, b) => new { CategoryName = c.Name, Count = b.Count() }).Where(x=>x.Count>=4);
            foreach (var group in query) { Console.WriteLine();}
        }
    }
}
