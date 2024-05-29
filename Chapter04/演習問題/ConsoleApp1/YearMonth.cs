using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {

    public class YearMonth {
        //4.1.1
        public int Year { get; private set; }
        public int Month { get; private set; }

        public YearMonth(int year, int month) {
            this.Year = year;
            this.Month = month;
        }

        //4.1.2
        public bool Is21Century {
            get {
                return 2001 <= this.Year && this.Year <= 2100;

            }
        }

        //4.1.3
        public YearMonth AddOneMonth() {
            if (this.Month == 12) {
                return new YearMonth(this.Year + 1, 1);
            } else {
                return new YearMonth(this.Year + 1, this.Month + 1); ;
            }
        }

        //4.1.4
        public override string ToString() {
            //return Year + "年" + Month + "月"
            return $"{this.Year}年{this.Month}月";
        }
    }
}
