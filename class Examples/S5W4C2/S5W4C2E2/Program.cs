using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W4C2E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student one = new Student(1);
            one.Name = "Barbara";
            Console.WriteLine(one.Id);
            Console.WriteLine(one.Name);
        }
    }
}
