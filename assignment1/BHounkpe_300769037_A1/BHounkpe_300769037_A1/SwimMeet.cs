using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHounkpe_300769037_A1
{
    class SwimMeet
    {
        private DateTime startDate;
        private DateTime endDate;
        private string name;
        private poolType pType;
        private static int noOfSwimMeet = 1;
        public enum poolType: byte {SCM, SCY, LCM};
        public SwimMeet(): this("Swimm meet #"+noOfSwimMeet, DateTime.Today, DateTime.Today.AddYears(1), poolType.SCM)
        {

        }
        public SwimMeet(string name) : this(name, DateTime.Today, DateTime.Today.AddYears(1), poolType.SCM)
        {

        }
        public SwimMeet(string name, DateTime startDate, DateTime endDate, poolType pType)
        {
            Name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.pType = pType;
            noOfSwimMeet++;
        }
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }
        public String Name
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
        public poolType Ptype
        {
            get
            {
                return pType;
            }
            set
            {
                pType = value;
            }
        }
        public string GetInfo()
        {
            return string.Format(
                "The Swim meet name is {0} \n" +
                "The starting date is {1} \n" +
                "The ending date is {2} \n" +
                "The pool type is: {3} \n" 
                , Name, StartDate.ToString("MMMM dd, yyyy"), EndDate.ToString("MMMM dd, yyyy"), Ptype);
        }
    }
}
