namespace Null_Object_Design_Pattern {
    internal class Program {
        static void Main(string[] args) {
            var carType = Console.ReadLine();
            var carObj = VehicleFactory.GetVehicleObject(carType);
            Console.WriteLine(carObj.Describe);
        }
    }
}