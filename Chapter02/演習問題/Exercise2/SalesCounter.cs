using SalesCounter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    internal class SalesCounter {

        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePass) {
            _sales = ReadSales(filePass);
        }

        private static IEnumerable<Sale> ReadSales(String filePath) {
            List<Sale> sales = new List<Sale>();
            String[] lines = File.ReadAllLines(filePath);
            foreach (String line in lines) {
                string[] item = line.Split(',');
                Sale sale = new Sale {
                    ShopName = item[0],
                    ProductCategory = item[1],
                    Amount = int.Parse(item[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
        public IDictionary<String, int> GetPerProductSale() {

            var dict = new Dictionary<String, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory)) {
                    dict[sale.ProductCategory] += sale.Amount;
                } else {
                    dict[sale.ProductCategory] = sale.Amount;
                }
            }
            return dict;
        }
    }
}
