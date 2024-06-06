using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var capitallocation = new Dictionary<string, string>();

            Console.WriteLine("******県庁所在地の入力******");

            for (int i = 0; i < 5; i++) { 
                var location = new string[5];
                Console.Write("都道府県 : ");
                location[i] = Console.ReadLine();
                Console.Write("県庁所在地 : ");
                capitallocation.Add(location[i], Console.ReadLine());
            }

            Console.WriteLine("******メニュ-******");
            Console.WriteLine("1 ← 一覧表示");
            Console.WriteLine("2 ← 検索");
            Console.WriteLine("3 ← 終了");
            Console.Write("入力 : ");
            int num = int.Parse(Console.ReadLine());
            if(num == 1) {
                foreach (var item in capitallocation)
                    Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です");
            }else if (num == 2) {
                Console.Write("都道府県 : ");
                string str = Console.ReadLine();
                var str2 = (capitallocation.Where(x => x.Key.Equals(str)));
                foreach (var item in str2)
                    Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です");
            } else Console.WriteLine(num);
        }
    }
}
