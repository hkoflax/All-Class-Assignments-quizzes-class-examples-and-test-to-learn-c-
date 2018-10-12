using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W10C2
{
    class Teacher : Person
    {
        private int empId;
        private double salary;

        public Teacher(string name,int age) : base(name,age)
        {

        }

        public int EmpId
        {
            get
            {
                return empId;
            }

            set
            {
                empId = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo()+string.Format(",id: {0}, salary: {1}",EmpId,Salary);
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
