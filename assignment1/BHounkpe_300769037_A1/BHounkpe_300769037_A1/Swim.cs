using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHounkpe_300769037_A1
{
    class Swim
    {
        private TimeSpan timeSwam;
        private int numberOfTheHeat;
        private int numberOfLane;
        public Swim(): this (new TimeSpan(1,05,52),50,5)
        {

        }
        public Swim(TimeSpan time): this(time,20,2)
        {

        }
        public Swim(TimeSpan time, int nbOfHeat, int nbOflane)
        {
            TimeSwam = time;
            NumberOfTheHeat = nbOfHeat;
            NumberOfLane = nbOflane;
        }

        public TimeSpan TimeSwam
        {
            get
            {
                return timeSwam;
            }
            set
            {
                timeSwam = value;
            }
        }
        public int NumberOfTheHeat
        {
            get
            {
                return numberOfTheHeat;
            }
            set
            {
                numberOfTheHeat = value;
            }
        }
        public int NumberOfLane
        {
            get
            {
                return numberOfLane;
            }
            set
            {
                numberOfLane = value;
            }
        }
        public string GetInfo()
        {
            return String.Format("The final time of the swim is {0}\n"+
                                 "The number of the heat is {1}\n"+
                                 "The number of lane is {2}\n",TimeSwam,numberOfTheHeat,NumberOfLane);
        }
    }
}
