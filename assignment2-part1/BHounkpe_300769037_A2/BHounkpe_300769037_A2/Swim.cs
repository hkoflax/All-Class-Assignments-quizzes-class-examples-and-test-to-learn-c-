using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHounkpe_300769037_A2
{
    class Swim
    {
        private string timeSwam;
        private int numberOfTheHeat;
        private int numberOfLane;
        public Swim(): this ("00:00.00",1,0)
        {

        }
        public Swim(string time): this(time,1,0)
        {

        }
        public Swim(string time, int nbOfHeat, int nbOflane)
        {
            TimeSwam = time;
            NumberOfTheHeat = nbOfHeat;
            NumberOfLane = nbOflane;
        }

        public string TimeSwam
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
            return String.Format("H" +NumberOfTheHeat + "L" +NumberOfLane + "\t" + "Time: " +TimeSwam);
        }
    }
}
