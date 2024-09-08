using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Design_Pattern {
    internal class VehicleFactory {
        public static Vehicle_CLS GetVehicleObject(string type) {
            if (type == "car") {
                return new Car_CLS();
            }
            return new NullVehicle();
        }
    }
}
