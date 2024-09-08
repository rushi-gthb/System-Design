using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy_Design_Pattern {
    internal class NormalVehicle_CLS : Vehicle_CLS {
        public NormalVehicle_CLS(DrivingStratergy_INTF drivingStratergy_INTF) : base(drivingStratergy_INTF) {

        }
    }
}
