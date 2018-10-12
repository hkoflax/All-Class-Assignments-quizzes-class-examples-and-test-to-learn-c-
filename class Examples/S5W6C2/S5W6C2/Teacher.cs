using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W6C2
{
    class Teacher
    {
        private int idNumber;
        private string name;
        private int noOfCourses = 0;
        private Course[] listCourses;

        public Teacher(int idNumber, String name)
        {
            IdNumber = idNumber;
            Name = name;
            ListCourses = new Course[10];
        }
        public int NoOfCourses
        {
            get
            {
                return noOfCourses;
            }
            set
            {
                noOfCourses = value;
            }
        }
        public string Name
        {
            get
            {
                //return "not assign if its null and return name otherwise"
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }
        public Course[] ListCourses
        {
            get
            {
                return listCourses;
            }
            set
            {
                listCourses = value;
            }
        }

        public void AddCourse(Course course)
        {
            if (course.Faculty.name != "Not Assigned")
            {
                if (course.Faculty.idNumber != this.IdNumber)
                {
                    Exception error = new Exception(course.Name + " is already been assigned to " + course.Faculty.Name + "\n");
                    Console.WriteLine(error.Message);
                }
                else
                {
                    Exception error = new Exception(course.Faculty.Name + " is already teaching " + course.Name + "\n");
                    Console.WriteLine(error.Message);
                }
            }
            else
            {
                ListCourses[noOfCourses] = course;
                course.Faculty = this;
                noOfCourses++;
            }
        }
        private string displayCourses()
        {
            if (noOfCourses > 0)
            {
                string courseName = "";
                Course aCourse;
                for (int i = 0; i < noOfCourses; i++)
                {
                    aCourse = ListCourses[i];
                    courseName = courseName + aCourse.Name + "\n                ";
                }
                return courseName;
            }
            else
            {
                return "";
            }
        }
        public string GetInfo()
        {
            return string.Format("The id number is: {0} \n" +
                "and the Teacher name: {1}\n" +
                "List of courses:\n"+
                "                {2}", IdNumber, Name, displayCourses());
        }

    }
}
