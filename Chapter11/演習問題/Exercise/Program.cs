using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise {
    internal class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var sample = xdoc.Root.Elements();
            foreach(var xsample in sample) {
                var name = xsample.Element("name");
                var teammembers = xsample.Element("teammembers");

                Console.WriteLine($"{name.Value}は{teammembers.Value}人");
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var sample = xdoc.Root.Elements().OrderBy(x => x.Elements("firstplayed").Attributes("firstplayed"));
            foreach (var xsample in sample) {
                var kanji = sample.Elements("name").Attributes("kanji");
                var firstplayed = xsample.Element("firstplayed");

                Console.WriteLine("{0}{1}", kanji,firstplayed.Value);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var sample = xdoc.Root.Elements().Max(x => x.Elements("teammembers"));
            foreach (var xsample in sample) {
                var name = xsample.Element("name");
                Console.WriteLine("{0}", name.Value);
            }
        }
    }
}
