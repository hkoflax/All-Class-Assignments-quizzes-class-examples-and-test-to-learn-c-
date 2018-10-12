using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W3C2E2
{
    class Section
    {
        private int noOfStudents;
        private string course;
        private int sectionNo;

        public Section(int sectionNumber, string course, int noOfStudets)
        {
            NoOfStudents = noOfStudets;
            Course = course;
            SectionNo = sectionNumber;
        }
        public int NoOfStudents
        {
            get
            {
                return noOfStudents;
            }

            set
            {
                noOfStudents = value;
            }
        }

        public string Course
        {
            get
            {
                return course;
            }

            set
            {
                course = value;
            }
        }

        public int SectionNo
        {
            get
            {
                return sectionNo;
            }

            set
            {
                sectionNo = value;
            }
        }

        public static Section operator+(Section one, Section two)
        {
            int newNoOfStudents;
            int newSectionNo;
            string newCourse;

            newNoOfStudents = one.NoOfStudents + two.NoOfStudents;
            newCourse = one.Course;
            newSectionNo = one.SectionNo * 10 + two.SectionNo;

            return (new Section(newSectionNo, newCourse, newNoOfStudents));
        }

        public void TellAboutSelf()
        {
            Console.WriteLine("Section:\n\tNumber:{0}\n\tCourse:{1}\n\tSturent number:{2}",
                                SectionNo, Course, NoOfStudents);
        }

        public string GetInfo()
        {
           return String.Format("Section:\n\tNumber:{0}\n\tCourse:{1}\n\tSturent number:{2}",
                                SectionNo, Course, NoOfStudents);
        }
    }
}
