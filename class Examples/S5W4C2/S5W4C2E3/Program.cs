using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W4C2E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student barbara = new Student(3007);
            Student koflax = new Student(3008);
            Section comp100 = new Section(001,"Comp100",0);
            Section comp200 = new Section(001, "Comp200", 0);
            comp100.AddStudent(barbara);
            comp200.AddStudent(koflax);
            barbara.TellAboutSelf();
            koflax.TellAboutSelf();
            comp100.TellAboutSelf();
            comp200.TellAboutSelf();
            Section combined = comp100 + comp200;
            combined.TellAboutSelf();
        }
    }
}
