using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W6C2
{
    class Course
    {
        private string code;
        private string name;
        private Teacher faculty = new Teacher(0, "Not Assigned");

        public Course(string code, String name)
        {
            Code = code;
            Name = name;
        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
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
        public Teacher Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
            }
        }

        public string GetInfo()
        {
            return string.Format("The code is: {0} \n" +
                "The course name: {1} \n" +
                "Faculty name is: {2}\n", Code, Name, Faculty.Name);
        }

    }
}
