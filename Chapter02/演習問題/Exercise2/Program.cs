using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    internal class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                inchConverter.PrintinchToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                //メートルからフィートへの対応表を出力
                inchConverter.PrintMeterTinchList(int.Parse(args[1]), int.Parse(args[2]));
            }

            var ProductSales = new SalesCounter(@"data\sales.csv");
            var Product = ProductSales.GetPerProductSale();
            Console.WriteLine("****商品別****");
            foreach (KeyValuePair<String, int> obj in Product) {
                Console.WriteLine("{0},{1}", obj.Key, obj.Value);
            }
        }
    }
}
