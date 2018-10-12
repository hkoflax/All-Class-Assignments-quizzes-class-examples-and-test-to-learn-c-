using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W4C1E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student(1);

            first.TellAboutSelf();

            Student second = new Student(2);

            second.TellAboutSelf();

            Student.DispleyNoOfStudents();
            
        }

        
    }
}
