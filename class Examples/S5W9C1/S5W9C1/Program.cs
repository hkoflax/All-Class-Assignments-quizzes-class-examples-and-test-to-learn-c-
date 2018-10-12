using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W9C1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person("bob",30) {Age=30};
            Console.WriteLine(aPerson.GetInfo());

            Student aStudent = new Student("koflax",24) {Adress = "7 Chanvellor drive, Toronto" };
            aStudent.StudentId = 300;
            Console.WriteLine(aStudent.GetInfo());
        }
    }
}
