using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    public class SalesCounter {

        private List<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePass) { 
            _sales = ReadSales(filePass);
        }

        //売り上げデートを読み込み、Saleオブジェクトのリストを返す
        private static List<Sale> ReadSales(String filePath) {
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


        //店舗別の売上を求める
        public Dictionary<String,int>GetPerStoreSale() {

            Dictionary <String,int> dict = new Dictionary<String,int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName)) {
                    dict[sale.ShopName] += sale.Amount;
                } else {
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }
        public Dictionary<String, int> GetPerProductSale() {

            Dictionary<String, int> dict = new Dictionary<String, int>();
            foreach (Sale sale in _sales) {
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
