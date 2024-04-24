using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    internal class Program {
        static void Main(string[] args) {
            //戻り値を受け取る
            List<Sale>sales = ReadSales(@"C:\Users\infosys\source\repos\OOP2024\Chapter02\SalesCounter\bin\Debug\date\Sales.csv");
            

            //戻り値のコレクションを一軒ずつ出力する
            foreach (Sale sale in sales) {
                Console.WriteLine(sale.ShopName + " "+sale.ProductCategory+" "+sale.Amount);

               //Console.WriteLine("店名:{0} カテゴリー:{1} 売上:{2}",sale.ShopName,sale.ProductCategory,sale.Amount);
            }
        }


        //売り上げデートを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(String filePath) {
            List<Sale> sales = new List<Sale>();
            String[] lines = File.ReadAllLines(filePath);
            foreach (String line in lines) {
                string[] item = line.Split(',');
                Sale sale = new Sale {
                    ShopName = item[0],
                    ProductCategory = item[1],
                    Amount = item[2]
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}
