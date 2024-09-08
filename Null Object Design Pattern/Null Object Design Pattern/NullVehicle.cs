using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Design_Pattern {
    internal class NullVehicle : Vehicle_CLS {
        public virtual int WheelCount { get; set; } = 0;

        public virtual int TankCapacity { get; set; } = 0;
    }
}
