using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLib;

namespace S5W7C1EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Course math = new Course("170", "Math");
            Course physics = new Course("160", "physics");
            Course comp100 = new Course("100", "Comp100");
            Course comp101 = new Course("101", "Comp101");
            Course comp102 = new Course("102", "Comp102");
            Course comp103 = new Course("103", "Comp103");
            Teacher bob = new Teacher(1, "bob");
            Teacher koflax = new Teacher(2, "Koflax");
            Teacher marc = new Teacher(3, "Marc");

            Console.WriteLine(math.GetInfo());
            Console.WriteLine(physics.GetInfo());
            Console.WriteLine(comp100.GetInfo());
            Console.WriteLine(bob.GetInfo());
            Console.WriteLine(koflax.GetInfo());
            Console.WriteLine(marc.GetInfo());

            try
            {
                bob.AddCourse(math);
                koflax.AddCourse(math);
                bob.AddCourse(comp100);
                bob.AddCourse(comp101);
                bob.AddCourse(comp100);
                bob.AddCourse(comp101);
            }
            catch (Exception error)
            {
                throw error;
            }
            Console.WriteLine(math.GetInfo());
            Console.WriteLine(physics.GetInfo());
            Console.WriteLine(comp100.GetInfo());
            Console.WriteLine(bob.GetInfo());
        }
    }
}
