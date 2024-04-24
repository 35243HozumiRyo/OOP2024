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

            SalesCounter StoreSales = new SalesCounter(@"date\sales.csv");
            Dictionary<String, int> amountPerStore = StoreSales.GetPerStoreSale();
            Console.WriteLine("****店舗別****");
            foreach (KeyValuePair<String, int> obj in amountPerStore) {
                Console.WriteLine("{0},{1}", obj.Key, obj.Value);
            }

            SalesCounter ProductSales = new SalesCounter(@"date\sales.csv");
            Dictionary<String, int> Product = ProductSales.GetPerProductSale();
            Console.WriteLine("****商品別****");
            foreach (KeyValuePair<String, int> obj in Product) {
                Console.WriteLine("{0},{1}", obj.Key, obj.Value);
            }
        }
    }
}
