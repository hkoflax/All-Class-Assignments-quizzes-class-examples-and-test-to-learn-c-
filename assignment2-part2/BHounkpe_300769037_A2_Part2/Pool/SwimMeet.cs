﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolLib
{
    public class SwimMeet
    {
        private DateTime startDate;
        private DateTime endDate;
        private string name;
        private PoolType pType;
        private int noOfEvents=0;
        private int numberOfLane;
        private Event[] eventList;
        private bool nameInitialized, startDateInitialized, endDateInitialized, pTypeInitialized, numberOflaneInitialized;
        public SwimMeet(): this("", DateTime.Today, DateTime.Today.AddYears(1), PoolType.SCM,8)
        {
            nameInitialized = false;
            startDateInitialized = false;
            endDateInitialized = false;
            pTypeInitialized = false;
            numberOflaneInitialized = false;
        }
        public SwimMeet(string name) : this(name, DateTime.Today, DateTime.Today.AddYears(1), PoolType.SCM,8)
        {
            startDateInitialized = false;
            endDateInitialized = false;
            pTypeInitialized = false;
            numberOflaneInitialized = false;
        }
        public SwimMeet(string name, DateTime startDate, DateTime endDate, PoolType pType, int numberOfLane)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.pType = pType;
            this.numberOfLane = numberOfLane;
            EventList = new Event[50];
            nameInitialized = true;
            startDateInitialized = true;
            endDateInitialized = true;
            pTypeInitialized = true;
            numberOflaneInitialized = true;
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                if (startDateInitialized==false)
                {
                    startDate = value;
                    startDateInitialized = true;
                }
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
                if (endDateInitialized == false)
                {
                    endDate = value;
                    endDateInitialized = true;
                }
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
                if (nameInitialized == false)
                {
                    name = value;
                    nameInitialized = true;
                }
            }
        }
        public PoolType PType
        {
            get
            {
                return pType;
            }
            set
            {
                if (pTypeInitialized == false)
                {
                    pType = value;
                    pTypeInitialized = true;
                }
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
                if (numberOflaneInitialized == false)
                {
                    numberOfLane = value;
                    numberOflaneInitialized = true;
                }
            }
        }

        public Event[] EventList
        {
            get
            {
                return eventList;
            }

            set
            {
                eventList = value;
            }
        }

        public string GetInfo()
        {
            return string.Format(
                "Swim meet name: {0} \n" +
                "From: {1} to: {2}\n" +
                "Pool Type {3} \n" +
                "No Lanes: {4}\n"+
                "Events: \n"+
                "       {5}"
                , Name, StartDate.ToString("yyyy-MM-dd"), EndDate.ToString("yyyy-MM-dd"), PType,NumberOfLane,DisplayEventsList());
        }
        public void AddEvent(Event events)
        {
            EventList[noOfEvents] = events;
            events.SwimMeet = this;
            noOfEvents ++;
        }
        public string DisplayEventsList()
        {
            if (noOfEvents > 0)
            {
                string result = "";
                Event anEvent;
                for (int i = 0; i < noOfEvents; i++)
                {
                    anEvent = EventList[i];
                    result = result + anEvent.GetInfo()+ "\n       ";
                }
                return result;
            }
            else
            {
                return "";
            }
        }
        public void Seed()
        {
            for(int i=0;i<noOfEvents;i++)
            {
                eventList[i].Seed();
            }
        }
    }
    public enum PoolType { SCM, SCY, LCM };
}
