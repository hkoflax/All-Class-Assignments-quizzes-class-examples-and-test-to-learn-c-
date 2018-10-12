using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W10C2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person("bob",30) {Age=30};
            Console.WriteLine(aPerson.GetInfo());
            Console.WriteLine("\n*************************************");

            Student aStudent = new Student("koflax",24) {Adress = "7 Chancellor drive, Toronto" };
            aStudent.StudentId = 300;
            Console.WriteLine(aStudent.GetInfo());
            Console.WriteLine("\n*************************************");

            Teacher aTeacher = new Teacher("Bob", 40) { Adress = "7 Chan rd, Toronto", EmpId=333, Salary=4000};
            Console.WriteLine(aTeacher.GetInfo());
            Console.WriteLine("\n*************************************");

            Person someone;
            someone = aPerson;
            Console.WriteLine(someone);
            //Console.WriteLine(someone.GetInfo());

            someone = aStudent;
            Console.WriteLine(someone);
            //Console.WriteLine(someone.GetInfo());

            someone = aTeacher;
            Console.WriteLine(someone);
            Console.WriteLine(someone.GetType());
            //Console.WriteLine(someone.GetInfo());

        }
    }
}
