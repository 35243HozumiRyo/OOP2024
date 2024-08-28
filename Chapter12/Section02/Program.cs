using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    internal class Program {
        static void Main(string[] args) {
            var novels = new Novel[] {
                new Novel {
                     Author = "アイザック・アシモフ",
                     Title = "われはロボット",
                     Published = 1950,
                },
                 new Novel {
                     Author = "ジョージ・オーウェル",
                     Title = "一九八四年",
                     Published = 1949,
                },
             };
#if false
            using(var stream = new FileStream("novel.json", FileMode.Create, FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer(novels.GetType());
                serializer.WriteObject(stream, novels);
            }
#else
            var options = new JsonSerializerOptions {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndent = true,
            };

            string jsonString = JsonSerializer.Serialize(novels.option);
            Console.WriteLine(jsonString);

#endif
        }
    }
}
