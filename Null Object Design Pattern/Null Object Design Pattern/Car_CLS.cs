using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Design_Pattern {
    internal class Car_CLS : Vehicle_CLS {
        public override int WheelCount { get; set; } = 4;

        public override int TankCapacity { get; set; } = 40;
    }
}
