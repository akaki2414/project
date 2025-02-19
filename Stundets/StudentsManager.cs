using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stundets {
    internal class StudentsManager {
        int RollNum = 0; 

        List<Student> students = new List<Student>() {
            new Student() {
                Name = "akaki",
                RollNumber = 0,
                Grade = 12
            },
        };

        public void ShowStudents() {
            foreach (var student in students) {
                    student.ShowStats();
            }
        }
     
        public void AddStudent() {
            Console.Write("\ninput students name:");
            string StudentName = Console.ReadLine()!;
            Console.Write("\ninput students grade:");
            int Grade = int.Parse(Console.ReadLine()!);

            Student student = new Student() {
                Name = StudentName,
                RollNumber = RollNum += 1,
                Grade = Grade
            };

            students.Add(student);
        }
        public void UpdateGrade() {
            Console.Write("\ninput students Rollnumber to change grade:");

            int RollNUm = int.Parse(Console.ReadLine()!);
            foreach(var studen in students) {
                if (RollNum == studen.RollNumber) {

                    Console.Write("change grade: ");
                    int NewGrade = int.Parse(Console.ReadLine()!);

                    studen.Grade = NewGrade;
                }
            }
        }
        public void SearchStudents() {
            Console.Write("input students Rollnumber:");
            int RollNum = int.Parse(Console.ReadLine()!);

            foreach (var student in students) { 
                if(RollNum == student.RollNumber) {
                    student.ShowStats();
                }
            }

        }
        
    }
}
