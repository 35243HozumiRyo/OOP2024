﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
            new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
            new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
            new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
            new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
            new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
            new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
            new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);
            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);
            Console.WriteLine("-----");

            Exercise2_7(books);
        }

        private static void Exercise2_1(List<Book> books) {
            var book = books.Where(n => n.Title.Equals("ワンダフル・C#ライフ"));
            foreach(var i in book)Console.WriteLine("{0},{1}",i.Price,i.Pages);
            //模範解答
            //var books2 = books.Where(b => b.Title == "ワンダフル・C#ライフ");
            //foreach (var book2 in books2) Console.WriteLine("{0},{1}", book2.Price, book2.Pages);
        }

        private static void Exercise2_2(List<Book> books) {
            Console.WriteLine(books.Count(x => x.Title.Contains("C#")));
        }

        private static void Exercise2_3(List<Book> books) {
            Console.WriteLine(books.Where(n => n.Title.Contains("C#"))
                                   .Average(x => x.Pages));
        }

        private static void Exercise2_4(List<Book> books) {
            Console.WriteLine(books.FirstOrDefault(x=>x.Price >= 4000).Title);
            //模範解答
            //var book = books.FirstOrDefault(b => b.Price >= 4000);
            //if(book != null) Console.WriteLine(book.Title);
        }

        private static void Exercise2_5(List<Book> books) {
            Console.WriteLine(books.Where(x => x.Price < 4000).Max(x=>x.Pages));
        }

        private static void Exercise2_6(List<Book> books) {
            var book = books.Where(x => x.Pages >= 400)
                            .OrderByDescending(x => x.Price);
            foreach(var i in book) Console.WriteLine(i.Title,i.Price);
        }

        private static void Exercise2_7(List<Book> books) {
            var book = books.Where(b => b.Title.Contains("C#"))
                            .Where(b=>b.Pages<500);
            foreach (var i in book) Console.WriteLine(i.Title);
            //模範解答
            //var selected = books.Where(b=>b.Title.Contains("C#") && b.Pages<=500);
            //foreach (var i in selected) Console.WriteLine(i.Title);
        }

        class Book {
            public string Title { get; set; }
            public int Price { get; set; }
            public int Pages { get; set; }
        }
    }
}
