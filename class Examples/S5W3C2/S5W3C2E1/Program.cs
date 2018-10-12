using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W3C2E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student(1)
            {
                Gpa = 4.0,
                Semester = 3,
                Program = 1234
            };

            aStudent.TellAboutSelf();

            Student aStudent1 = new Student(2, 3.0, 2, 1234);

            aStudent1.TellAboutSelf();
        }
    }
}
