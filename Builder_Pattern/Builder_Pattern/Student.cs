using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern {
    internal class Student {
        int Id { get; set; }

        string Name { get; set; }

        int Age { get; set; }

        string Gender { get; set; }

        public Student(int Id, string Name, int Age, string Gender) {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }

        public string GetDetails => $"Id : {this.Id}\nName : {this.Name}\nAge : {this.Age}\nGender : {this.Gender}";
    }
}
