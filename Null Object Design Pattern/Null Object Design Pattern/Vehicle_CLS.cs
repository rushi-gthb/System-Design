using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Design_Pattern {
    internal class Vehicle_CLS : VehicleFactory {

        public virtual int WheelCount {  get; set; }    

        public virtual int TankCapacity { get; set; }

        public string Describe => $"WheelCount : {this.WheelCount}\n" +
            $"TankCapacity : {this.TankCapacity}\n";
        
    }
}
