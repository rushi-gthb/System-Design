namespace Factory_Pattern {
    internal class Program {
        static void Main(string[] args) {
            IShape shape = ShapeFactory.GetShape(ShapeEnum.Circle);
            shape.Draw();
            shape = ShapeFactory.GetShape(ShapeEnum.Square);
            shape.Draw();
        }
    }
}


