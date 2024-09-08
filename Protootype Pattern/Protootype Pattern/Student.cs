using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protootype_Pattern {
    internal class Student : IPrototype {
        public int PRT_RollNo { get; private set; }

        public string PRT_StudentName { get; set; }

        public int PRT_Std { get; set; }

        public ENM_Stream PRT_Stream { get; set; }

        public Student(int RollNo, string StudentName, int Std, ENM_Stream Stream) {
            PRT_RollNo = RollNo;
            PRT_StudentName = StudentName;
            PRT_Std = Std;
            PRT_Stream = Stream;
        }

        public string Describe => $"Roll No : {this.PRT_RollNo}\n" +
            $"Student Name : {this.PRT_StudentName}\n" +
            $"Std : {this.PRT_Std}\n" +
            $"Stream : {this.PRT_Stream}\n";

        public IPrototype Clone() {
            return (Student)MemberwiseClone();                
        }
    }
}
