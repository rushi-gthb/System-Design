namespace Builder_Pattern {
    internal class Program {
        static void Main(string[] args) {
            Student Rushi = new StudentDirector().ConstructBaseStudent("Rushi", "Male");
            Console.WriteLine(Rushi.GetDetails);
        }
    }

    public class StudentDirector {

        // Director which sets only name and gender
        internal Student ConstructBaseStudent(string name, string gender) {
            return new StudentBuilder().SetName(name).SetGender(gender).GetStudent();
        }
    }
}