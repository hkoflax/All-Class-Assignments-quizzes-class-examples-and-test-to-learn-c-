using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W10C1
{
    class Student : Person
    {
        private int studentId;
        public Student(string name, int age): base(name,age)
        {
            Console.WriteLine("I am in Student Constructor");
        }

        public int StudentId
        {
            get
            {
                return studentId;
            }

            set
            {
                studentId = value;
            }
        }
        public override string GetInfo()
        {
            return base.GetInfo() + string.Format(",Studentid: {0}",StudentId);
        }
        //public override string ToString()
        //{
        //    return GetInfo();
        //}
    }
}
