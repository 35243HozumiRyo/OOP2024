using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    internal class Program {
        static void Main(string[] args) {

            var songs = new Song[] {
                new Song("タイムパラドックス", "Vaundy", 227),
                new Song("アイドル", "yoasobi", 214),
                new Song("Pretender", "Official髭男dism", 326),

              };
            PrintSongs(songs);

        }
        private static void PrintSongs(Song[] songs) {
            for (int i = 0; i < songs.Length; i++) {
                Console.WriteLine(songs[i].Title + ":" + songs[i].ArtistName + ":" + @"{0:mm\:ss}", TimeSpan.FromSeconds(songs[i].Length));
            }
        }
    }
}
