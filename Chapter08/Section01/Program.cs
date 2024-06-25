using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("生年月日を入力");
            Console.Write("年 : ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("月 : ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("日 : ");
            int day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year, month, day);
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var dayOFWeek = culture.DateTimeFormat.GetDayName(birthday.DayOfWeek);
            Console.WriteLine("あなたは"+dayOFWeek+"曜日に生まれた");
            
            var str = birthday.ToString("ggyy年d日dddd",culture);

            Console.WriteLine("あなたは" + str + "に生まれました");

            
        }
    }
}
