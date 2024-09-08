using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy_Design_Pattern {
    internal class SportsVehicle_CLS : Vehicle_CLS {
        public SportsVehicle_CLS(DrivingStratergy_INTF drivingStratergy_INTF) : base(drivingStratergy_INTF) {

        }
    }
}
