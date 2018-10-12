using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W4C2E2
{
    partial class Student
    {
        int id;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public Student(int id)
        {
            Id = id;
        }

        partial void DisplayId();
    }
}
