using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter {

    public class ProundUnit : WeightUnit {
        private static List<ProundUnit> units = new List<ProundUnit> {
            new ProundUnit{ Name = "oz",Coefficient = 1,},
            new ProundUnit{ Name = "lb",Coefficient = 1 * 16,},
            new ProundUnit{ Name = "stone",Coefficient = 1 * 16 * 14,},
        };
        public static ICollection<ProundUnit> Units { get { return units; } }

        /// <summary>
        /// グラム単位からOZ単位に変換します
        /// </summary>
        /// <param name="unit">グラム単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromMetricUnit(GramUnit unit, double value) {
            return (value * unit.Coefficient) / 28.35 / this.Coefficient;
        }
    }

}
