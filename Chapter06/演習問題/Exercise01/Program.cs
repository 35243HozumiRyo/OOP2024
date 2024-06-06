using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");
            
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            var Max = numbers.Max();
            Console.WriteLine(Max);
        }

        private static void Exercise1_2(int[] numbers) {
            for(int i = numbers.Length-2 ; i < numbers.Length ; i ++)
                Console.WriteLine(numbers[i]);
            //模範解答
            //var skip = numbers.Length - 2;
            //foreach (int number in numbers.Skip(skip)) Console.WriteLine(number);
        }

        private static void Exercise1_3(int[] numbers) {
            string[] result = numbers.Select(i => i.ToString()).ToArray();
            Console.WriteLine(String.Join(", ", result));
            //模範解答
            //var Strings = numbers.Select(n => n.ToString());
            //foreach (string str in Strings) Console.WriteLine(str);
        }

        private static void Exercise1_4(int[] numbers) {
            var sort = numbers.OrderBy(n => n).ToArray();
            for (int i = 0; i < 3; i++) Console.WriteLine(sort[i]);
            //模範解答
            //foreach (var number in numbers.OrderBy(n => n).Take(3)) {
            //    Console.WriteLine(number);
            //}
        }

        private static void Exercise1_5(int[] numbers) {
            var results = (numbers.Distinct()).Count(n => n > 10);
            Console.WriteLine(results);
        }
    }
}
