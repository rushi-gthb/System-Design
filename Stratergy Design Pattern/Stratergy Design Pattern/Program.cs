namespace Stratergy_Design_Pattern {
    internal class Program {
        static void Main() {
            NormalVehicle_CLS echo = new (new NormalDrivingStratergy_CLS());
            SportsVehicle_CLS xuv700 = new (new SportsDrivingStratergy_CLS());
            OffroadVehicle_CLS thar = new (new SportsDrivingStratergy_CLS());

            echo.Drive();
            xuv700.Drive();
            thar.Drive();
        }
    }
}