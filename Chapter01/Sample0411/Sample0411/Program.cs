using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample0411 {
    internal class Program {
        static void Main(string[] args) {

            int inputNum = 0;
            int[] nums = new int[10];

            while (inputNum != -1) {
                Console.Write("数値を入力:");
                inputNum = int.Parse(Console.ReadLine());
                if (inputNum != -1) {
                    nums[inputNum]++;//カウント
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            for (int i = 0; i < nums.Length; i++) {
                Console.Write(i + " : ");
                astOut(nums[i]);
                Console.WriteLine();
            }
        }
        //指定した数のアスタリスクを出力
        public static void astOut(int num) {
            while (num != 0) {
                Console.Write('*');
                num--;
            }
        }
    }
}
