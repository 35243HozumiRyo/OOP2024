using Section02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {

    // List 17-2
    class GreetingMorning : IGreeting {
        public override string GetMessage() {
            return "おはよう";
        }
    }

    class GreetingAfternoon : IGreeting {
        public override string GetMessage() {
            return "こんにちは";
        }
    }

    class GreetingEvening : IGreeting {
        public override string GetMessage() {
            return "こんばんは";
        }
    }
}
