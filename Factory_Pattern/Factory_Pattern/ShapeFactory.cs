using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern {
    internal class ShapeFactory {

        public static IShape GetShape(ShapeEnum shapeEnum) {
            switch (shapeEnum) {
                case ShapeEnum.Circle:
                    return new Circle();
                case ShapeEnum.Square:
                    return new Square();
                default:
                    return null;
            }
        }
    }
}
