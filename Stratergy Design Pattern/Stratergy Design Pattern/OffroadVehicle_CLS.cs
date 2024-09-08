using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy_Design_Pattern {
    internal class OffroadVehicle_CLS : Vehicle_CLS {
        public OffroadVehicle_CLS(DrivingStratergy_INTF drivingStratergy) : base(drivingStratergy) {

        }
    }
}
