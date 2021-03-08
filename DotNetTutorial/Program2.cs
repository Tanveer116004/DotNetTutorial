using System;

namespace DotNetTutorial
{
    class Program2
    {
        public void ChangeStudentName(Student student) {
            student.StudentName = "Tanveer";
            Console.WriteLine("Student Name inside ChangeStudentName function is {0}", student.StudentName);
        }

        public void Example() {
            Student student = new Student();
            student.StudentName = "Veer";
            Console.WriteLine("Student Name inside Example function before calling ChangeStudentName is {0}", student.StudentName);
            ChangeStudentName(student);
            Console.WriteLine("Student Name inside Example function after calling ChangeStudentName is {0}", student.StudentName);
        }
    }
    public class Student {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }
}
