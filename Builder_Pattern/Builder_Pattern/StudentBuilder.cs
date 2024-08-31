using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern {
    internal class StudentBuilder {
        int Id { get; set; }

        string Name { get; set; }

        int Age { get; set; }

        string Gender { get; set; }

        public StudentBuilder SetId(int Id) { this.Id = Id; return this; }
        public StudentBuilder SetName(string Name) { this.Name = Name; return this; }
        public StudentBuilder SetAge(int Age) { this.Age = Age; return this; }
        public StudentBuilder SetGender(string Gender) { this.Gender = Gender; return this; }

        public Student GetStudent() {
            return new Student(Id, Name, Age, Gender);
        }
    }
}
