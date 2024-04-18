using SampleApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            SampleApp.Product karinto = new SampleApp.Product(123, "かりんとう", 180); //完全修飾
            Product daifuku = new Product(123, "大福", 180);
            Product dorayaki = new Product(98, "どらやき", 210);

            int dorayakiprice = dorayaki.Price;
            int dorayakiGettax = dorayaki.GetTax();

            int price2 = daifuku.Price;
            int taxIncluded2 = daifuku.GetPriceIncludingTax();

            int price = karinto.Price;
            int taxIncluded = karinto.GetPriceIncludingTax();

            Console.WriteLine("商品コード"+dorayaki.Code+"の"+dorayaki.Name + "の税込み金額" + dorayakiGettax);
            Console.WriteLine(karinto.Name + "の税込み金額" + taxIncluded + "円【税抜き"+price+"円】");
            Console.WriteLine(daifuku.Name + "の税込み金額" + taxIncluded2 + "円【税抜き" + price2 + "円】");

            Console.WriteLine($"{dorayakiGettax}円");
        }
    }
}
