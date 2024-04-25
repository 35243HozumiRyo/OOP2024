using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    internal class inchConverter {

        public static readonly double ratio = 0.0254;

        public static void PrintinchToMeterList(int start, int stop) {
            for (int inch = start; inch <= stop; inch++) {
                double meter = FeomMeter(inch);
                Console.WriteLine("{0}inch={1:0.0000}m", inch, meter);
            }
        }

        public static void PrintMeterTinchList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double inch = ToMeter(meter);
                Console.WriteLine("{0}m={1:0.0000}ft", meter, inch);
            }
        }

        public static double FeomMeter(double inch) {
            return inch * ratio;
        }
        public static double ToMeter(double inch) {
            return inch / ratio;
        }
    }
}
