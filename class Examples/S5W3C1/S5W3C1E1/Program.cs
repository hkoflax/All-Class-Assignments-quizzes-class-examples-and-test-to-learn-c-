using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W3C1E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student(1);

            aStudent.TellAboutSelf();
            //aStudent.StudentId = 1;
            aStudent.Gpa = 4.0;
            aStudent.Semester = 3;
            aStudent.Program = 1234;

            aStudent.TellAboutSelf();

            Student aStudent1 = new Student(2, 3.0, 2, 1234);

            aStudent1.TellAboutSelf();
        }
    }
}
