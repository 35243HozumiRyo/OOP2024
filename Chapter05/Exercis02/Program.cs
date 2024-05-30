using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercis02 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("数字を入力:");
            String s3 = Console.ReadLine();
            if(int.TryParse(s3, out int num)) {
                Console.WriteLine(num.ToString("N0"));
            } else {
                Console.WriteLine("変換に失敗しました。");
            }
        }
    }
}
