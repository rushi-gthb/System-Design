using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy_Design_Pattern {
    internal class Vehicle_CLS {
        readonly DrivingStratergy_INTF drivingStratergy;

        public Vehicle_CLS(DrivingStratergy_INTF drivingStratergy) {
            this.drivingStratergy = drivingStratergy;
        }

        public void Drive() {
            this.drivingStratergy.Drive_FUN();
        }
    }
}
