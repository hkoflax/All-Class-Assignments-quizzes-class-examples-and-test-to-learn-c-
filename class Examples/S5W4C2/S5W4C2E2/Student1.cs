using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W4C2E2
{
    partial class Student
    {
        string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        partial void DisplayId()
        {
            Console.WriteLine(id);
        }
    }
}
