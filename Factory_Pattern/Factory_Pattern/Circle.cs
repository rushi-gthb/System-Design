using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern {
    internal class Circle : IShape {
        public void Draw() {
            Console.WriteLine("Circle is drawn");
        }
    }
}
