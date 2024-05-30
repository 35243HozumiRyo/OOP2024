using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercis01 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("文字列を入力:");
            var s1 = Console.ReadLine();
            Console.Write("文字列を入力:");
            var s2 = Console.ReadLine();

            if (String.Compare(s1,s2,true) == 0)
                Console.WriteLine("等しい");
            else
                Console.WriteLine("等しくない");



            
        }
    }
}
