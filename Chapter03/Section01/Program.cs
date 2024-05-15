using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };

            var querty = names.Where(s => s.Length <= 5);
            foreach (var item in querty) {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");

            names[0] = "Osaka";
            foreach (var item in querty) {
                Console.WriteLine(item);
            }
        }
    }
}