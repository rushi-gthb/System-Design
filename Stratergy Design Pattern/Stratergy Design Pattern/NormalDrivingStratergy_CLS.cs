using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy_Design_Pattern {
    internal class NormalDrivingStratergy_CLS : DrivingStratergy_INTF {
        public void Drive_FUN() {
            Console.WriteLine("Normal Mode Drive");
        }
    }
}
