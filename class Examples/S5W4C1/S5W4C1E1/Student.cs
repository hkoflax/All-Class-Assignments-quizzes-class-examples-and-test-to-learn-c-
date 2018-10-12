using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W4C1E1
{
    class Student
    {
        private static int noOfStudents;

        private readonly int studentId;
        private double gpa;
        private int semester;
        private int program;

        static Student()
        {
            Console.WriteLine("I am in static constructor");
            noOfStudents = 0;
            
        }
        public Student(int studentId):this(studentId, 0,1,9999)
        {
            //this.StudentId = 9999;
            //this.Gpa = 0;
            //this.Program = 9999;
            //this.Semester = 1;
        }

        public Student(int studentId, double gpa, int semester, int program)
        {
            Console.WriteLine("I am in non static constructor");
            this.studentId = studentId;
            this.Gpa = gpa;
            this.Program = program;
            this.Semester = semester;
            noOfStudents++;
        }
        public int StudentId
        {
            get
            {
                return studentId;
            }

            //set
            //{
            //    studentId = value;
            //}
        }

        public double Gpa
        {
            get
            {
                return gpa;
            }

            set
            {
                gpa = value;
            }
        }

        public int Semester
        {
            get
            {
                return semester;
            }

            set
            {
                semester = value;
            }
        }

        public int Program
        {
            get
            {
                return program;
            }

            set
            {
                program = value;
            }
        }

        public static int NoOfStudents
        {
            get
            {
                return noOfStudents;
            }

            
        }

        public void TellAboutSelf()
        {
            Console.WriteLine("Number of students is {0}", NoOfStudents);
            Console.WriteLine("Student: \n\tStudentId: {0}\n\tGPA: {1} \n\tSemester: {2}\n\tProgram: {3}",
                               StudentId, Gpa, Semester, Program);
            Console.WriteLine("*********************************************");
        }

        public static void DispleyNoOfStudents()
        {
            Console.WriteLine("Number of students {0}", Student.NoOfStudents);
            //Console.WriteLine(this.gpa); 
        }
    }
}
