using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercis03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            Console.WriteLine(text.Length - text.Replace(' '.ToString(),"").Length);
        }

        private static void Exercise3_2(string text) {
            Console.WriteLine(text.Replace("big","small"));
        }

        private static void Exercise3_3(string text) {
            //Console.WriteLine(text.Length - text.Replace(' '.ToString(), "").Length + 1);
            int count = text.Split(' ').Length;
            Console.WriteLine("単語数:{0}",count );
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(' ').Where(s=>s.Length<=4);
            foreach(var word in words)
                Console.WriteLine(word);
        }

        private static void Exercise3_5(string text) {
            var array =text.Split('　').ToArray();
            var sb = new StringBuilder();
            foreach(var word in array) {
                sb.Append(word);
                sb.Append(' ');
            }
            Console.WriteLine(sb);
        }
    }
}
