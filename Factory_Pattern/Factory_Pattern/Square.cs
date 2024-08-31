using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern {
    internal class Square : IShape {
        public void Draw() {
            Console.WriteLine("Square is drawn");
        }
    }
}
