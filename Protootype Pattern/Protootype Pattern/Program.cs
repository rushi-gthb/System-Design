namespace Protootype_Pattern {
    internal class Program {
        static void Main( ) {
            Student var_rushi = new(1159, "Rushi", 12, ENM_Stream.Science);
            Console.WriteLine(var_rushi.Describe);

            Student var_shubh = (Student)var_rushi.Clone();
            var_shubh.PRT_StudentName = "Shubham";
            Console.WriteLine(var_shubh.Describe);

            Console.WriteLine(var_rushi.Describe);
        }
    }
}